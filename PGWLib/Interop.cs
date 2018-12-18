using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static PGWLib.CustomObjects;

namespace PGWLib
{
    /// <summary>
    /// PGWLib recebe todos os métodos com assinatura exata para comunicação com a biblioteca (DLL) Paygo.
    /// </summary>
    public class Interop
    {
        /// <summary>
        /// Método que inicia a biblíoteca Paygo, só reutilizar caso a ligação com a biblioteca (DLL) seja perdida ou reiniciada.
        /// </summary>
        /// <param name="pszWorkingDir">(string). Diretório de trabalho (caminho completo, com final nulo) para uso exclusivo do PayGo Web</param>
        /// <returns>(Int16). DLL Paygo retorna um valor, o Enum E_PWRET contem todas as possibilidades de retorno.</returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iInit(string pszWorkingDir);

        /// <summary>
        /// Método utilizado para iniciar uma nova transação através do Paygo Web, seu retorno é imediato.
        /// </summary>
        /// <param name="bOper">Tipo de transação a ser realizada. E_PWINFO contém as possibilidades de preenchimento.</param>
        /// <returns>(Int16). DLL Paygo retorna um valor, o Enum E_PWRET contem todas as possibilidades de retorno.</returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iNewTransac(byte bOper);

        /// <summary>
        /// Método utilizado para alimentar a biblioteca com informações da transação a ser realizada, seu retorno é imediato.
        /// </summary>
        /// <param name="wParam">Identificador do parâmetro. E_PWINFO contém as possibilidades de preenchimento.</param>
        /// <param name="pszValue">Valor do parâmetro (ASCII com final nulo).</param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iAddParam(ushort wParam, string pszValue);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vstParam"></param>
        /// <param name="piNumParam"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iExecTransac([Out] PW_GetData[] vstParam, ref short piNumParam);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iInfo"></param>
        /// <param name="pszData"></param>
        /// <param name="ulDataSize"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iGetResult(short iInfo, StringBuilder pszData, uint ulDataSize);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ulResult"></param>
        /// <param name="pszReqNum"></param>
        /// <param name="pszLocRef"></param>
        /// <param name="pszExtRef"></param>
        /// <param name="pszVirtMerch"></param>
        /// <param name="pszAuthSyst"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iConfirmation(uint ulResult, string pszReqNum, string pszLocRef,
                                               string pszExtRef, string pszVirtMerch, string pszAuthSyst);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iIdleProc();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bOperType"></param>
        /// <param name="vstOperations"></param>
        /// <param name="piNumOperations"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iGetOperations(byte bOperType, ref PW_Operations[] vstOperations, ref short piNumOperations);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszDisplay"></param>
        /// <param name="ulDisplaySize"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPEventLoop( StringBuilder pszDisplay, uint ulDisplaySize);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPAbort();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPGetCard(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPGetPIN(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPGetData(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPGoOnChip(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPFinishChip(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPConfirmData(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPRemoveCard();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszMsg"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPDisplay(string pszMsg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pulEvent"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPWaitEvent(ref uint pulEvent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPGenericCMD(ushort uiIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiIndex"></param>
        /// <returns></returns>
        [DllImport("PGWebLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short PW_iPPPositiveConfirmation(ushort uiIndex);
    }
}
