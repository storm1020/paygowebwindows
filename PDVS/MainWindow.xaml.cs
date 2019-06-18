﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static PGWLib.CustomObjects;
using static PGWLib.Enums;

namespace PDVS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PGWLib.PGWLib eft;

        public MainWindow()
        {
            //1.0
            InitializeComponent();

            eft = new PGWLib.PGWLib();

            // 1.3
            foreach (string item in Enum.GetNames(typeof(E_PWOPER)))
            {
                cmbOper.Items.Add(item);
            }

            // 1.4
            addMandatoryParameters();
        }

        #region Interface Elements

        private void btnAddParam_Click(object sender, RoutedEventArgs e)
        {
            openParamWindow();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstParameters.Items.Clear();
            addMandatoryParameters();
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            // 1.6
            if (!validateFields())
            {
                MessageBox.Show("Preencha os campos corretamente.");
                return;
            }
            // 1.7
            executeTransaction();

            confirmUndoTransaction(getTransactionResult());

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstParameters.SelectedIndex == -1) return;
            lstParameters.Items.RemoveAt(lstParameters.SelectedIndex);
        }

        private void lstParameters_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstParameters.SelectedIndex == -1) return;
            PW_Parameter param = (PW_Parameter)lstParameters.SelectedItem;
            openParamWindow(param.parameterName, param.parameterValue, lstParameters.SelectedIndex);
        }

        #endregion

        // 1.4
        private void addMandatoryParameters()
        {
            lstParameters.Items.Add(new PW_Parameter(E_PWINFO.PWINFO_AUTNAME.ToString(), (int)E_PWINFO.PWINFO_AUTNAME, "PDVS"));
            lstParameters.Items.Add(new PW_Parameter(E_PWINFO.PWINFO_AUTVER.ToString(), (int)E_PWINFO.PWINFO_AUTVER, "1.0"));
            lstParameters.Items.Add(new PW_Parameter(E_PWINFO.PWINFO_AUTDEV.ToString(), (int)E_PWINFO.PWINFO_AUTDEV, "NTK Solutions Ltda"));
            lstParameters.Items.Add(new PW_Parameter(E_PWINFO.PWINFO_AUTCAP.ToString(), (int)E_PWINFO.PWINFO_AUTCAP, "28"));
        }

        private void openParamWindow(string param = "", string value = "", int itemPosition = -1)
        {
            AddParamWindow addParamWindow = new AddParamWindow(param, value);
            addParamWindow.ShowDialog(ref param, ref value);

            if (!string.IsNullOrEmpty(param) & !string.IsNullOrEmpty(value) & !string.IsNullOrWhiteSpace(value))
            {
                PW_Parameter parameterObject = new PW_Parameter();

                E_PWINFO receivedParam = (E_PWINFO)Enum.Parse(typeof(E_PWINFO), param);

                parameterObject.parameterName = param;
                parameterObject.parameterCode = (ushort)receivedParam;
                parameterObject.parameterValue = value;

                foreach (PW_Parameter item in lstParameters.Items)
                {
                    if (item.parameterName == parameterObject.parameterName)
                    {
                        MessageBox.Show("Você não pode inserir duas vezes o mesmo parâmetro");
                        return;
                    }
                }

                if (itemPosition != -1) lstParameters.Items.RemoveAt(itemPosition);
                lstParameters.Items.Add(parameterObject);
            }
        }

        private bool validateFields()
        {
            if (cmbOper.SelectedIndex == -1) return false;
            if (lstParameters.Items.Count == 0) return false;
            return true;
        }

        private void executeTransaction()
        {
            // 1.8
            E_PWOPER operation = (E_PWOPER)Enum.Parse(typeof(E_PWOPER), cmbOper.SelectedValue.ToString());

            // 1.9
            PGWLib.PGWLib eft = new PGWLib.PGWLib();

            // 2.0
            int ret = eft.startTransaction(operation, lstParameters.Items.Cast<PW_Parameter>().ToList());
            if (ret != 0)
            {
                MessageBox.Show(string.Format("Erro ao executar a transação: {0}{1}{2}", ret, Environment.NewLine, ((E_PWRET)ret).ToString()));
            }
        }

        private List<PW_Parameter> getTransactionResult()
        {
            List<PW_Parameter> ret = new List<PW_Parameter>();
            
            ret = eft.getTransactionResult();

            ResultWindow rw = new ResultWindow(ret);
            rw.Show();

            return ret;

        }

        private int confirmUndoTransaction(List<PW_Parameter> transactionResult)
        {
            int ret = 0;

            foreach (PW_Parameter item in transactionResult)
            {
                if(item.parameterCode == (uint)E_PWINFO.PWINFO_CNFREQ & item.parameterValue == "1")
                {
                    ConfirmationWindow cw = new ConfirmationWindow();
                    E_PWCNF transactionStatus = E_PWCNF.PWCNF_REV_AUTO_ABORT;
                    cw.ShowDialog(ref transactionStatus);
                    ret = eft.confirmUndoTransaction(transactionStatus, transactionResult);
                }
            }

            return ret;

        }

    }
}
