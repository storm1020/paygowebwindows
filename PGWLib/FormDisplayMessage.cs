using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGWLib
{
    public partial class FormDisplayMessage : Form
    {
        int _timeout = 0;
        private static Timer _timer = new Timer();


        public FormDisplayMessage()
        {
            InitializeComponent();

            _timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Show(string message, int timeout = 30000)
        {
            if(string.IsNullOrEmpty(message))
            {
                this.Close();
                return;
            }
            LblMessage.Text = message;
            _timeout = timeout;

            this.Show();
        }

        private void FormDisplayMessage_Load(object sender, EventArgs e)
        {
            if (_timeout != 0)
            {
                _timer.Interval = _timeout;
                _timer.Start();
            }
        }

    }

}
