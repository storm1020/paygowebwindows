using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGWLib
{
    /// <summary>
    /// Classe de Enums referente constantes que recebem funções/retornos/parametros, contendo assinatura e valores.
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// Acionamento/controle do PIN-pad. TESTE
        /// </summary>
        public enum E_PWPPEVT : int
        {
            /// <summary>
            /// Foi passado um cartão magnético.
            /// </summary>
            PWPPEVT_MAGSTRIPE = 0x01,

            /// <summary>
            /// Foi detectada a presença de um cartão com chip. 
            /// </summary>
            PWPPEVT_ICC = 0x02,

            /// <summary>
            /// Foi detectada a presença de um cartão sem contato.
            /// </summary>
            PWPPEVT_CTLS = 0x03,

            /// <summary>
            /// Foi pressionada a tecla [OK].
            /// </summary>
            PWPPEVT_KEYCONF = 0x11,

            /// <summary>
            /// Foi pressionada a tecla [CORRIGE]. 
            /// </summary>
            PWPPEVT_KEYBACKSP = 0x12,

            /// <summary>
            /// Foi pressionada a tecla [CANCELA]. 
            /// </summary>
            PWPPEVT_KEYCANC = 0x13,

            /// <summary>
            /// Foi pressionada a tecla [F1]. 
            /// </summary>
            PWPPEVT_KEYF1 = 0x21,

            /// <summary>
            /// Foi pressionada a tecla [F2]. 
            /// </summary>
            PWPPEVT_KEYF2 = 0x22,

            /// <summary>
            /// Foi pressionada a tecla [F3]. 
            /// </summary>
            PWPPEVT_KEYF3 = 0x23,

            /// <summary>
            /// Foi pressionada a tecla [F4]. 
            /// </summary>
            PWPPEVT_KEYF4 = 0x24
        }

        /// <summary>
        /// Enum: Tipos de transações (formas de executar uma tarefa, sendo ela equivalente ou não).
        /// </summary>
        public enum E_PWOPER : int
        {
            /// <summary>
            /// Testa comunicação com a infraestrutura do PayGo Web.
            /// </summary>
            PWOPER_NULL = 0,

            /// <summary>
            /// Registra o Ponto de captura perante a infraestrutura do PayGo Web, para que seja autorizado realizar a trnasação.
            /// </summary>
            PWOPER_INSTALL = 1,

            /// <summary>
            /// Obtém da infraestrutura do Paygo Web os parâmetros de operação atualizados do Ponto de captura.
            /// </summary>
            PWOPER_PARAMUPD = 2,

            /// <summary>
            /// Obtém o último comprovante gerado por uma transação.
            /// </summary>
            PWOPER_REPRINT = 16,

            /// <summary>
            /// Obtém um relatório sintético das transações realizadas desde a última obtenção deste relatório.
            /// </summary>
            PWOPER_RPTTRUNC = 17,

            /// <summary>
            /// Relatório detalhado das transações realizadas na data informada, ou data atual.
            /// </summary>
            PWOPER_RPTDETAIL = 18,

            /// <summary>
            /// Acessa qualquer transação que não seja disponibilizada pelo Comando PWOPER_SALE. É apresentado um menu para o operador selecionar a transação desejada.
            /// </summary>
            PWOPER_ADMIN = 32,

            /// <summary>
            /// (VENDA) Realiza o pagamento de mercadorias e/ou serviços vendidos pelo Estabelecimento ao Cliente. (débito/crédito), transferindo fundos entre as respectivas contas.
            /// </summary>
            PWOPER_SALE = 33,

            /// <summary>
            /// Cancelamento de venda.
            /// </summary>
            PWOPER_SALEVOID = 34,

            /// <summary>
            /// Realiza aquisição de créditos pré-pagos(ex: recarga de celular).
            /// </summary>
            PWOPER_PREPAID = 35,

            /// <summary>
            /// Consulta a validade de um cheque papel.
            /// </summary>
            PWOPER_CHECKINQ = 36,

            /// <summary>
            /// Consulta saldo/limite do Estabelecimento(limite de crédito).
            /// </summary>
            PWOPER_RETBALINQ = 37,

            /// <summary>
            /// Consulta o saldo do cartão do Cliente
            /// </summary>
            PWOPER_CRDBALINQ = 38,

            /// <summary>
            /// Inicializa a operação junto ao provedor, e, ou obtém e atualiza os parâmetros de operação mantidos por este.
            /// </summary>
            PWOPER_INITIALIZ = 39,

            /// <summary>
            /// Finaliza operação junto ao Provedor.
            /// </summary>
            PWOPER_SETTLEMNT = 40,

            /// <summary>
            /// Reserva uma venda no limite do cartão do cliente, porém sem efetivar a venda.
            /// </summary>
            PWOPER_PREAUTH = 41,

            /// <summary>
            /// Cancelamento de pré-autorização
            /// </summary>
            PWOPER_PREAUTVOID = 42,

            /// <summary>
            /// (Saque) Registra a retirada de um valor em espeécie pelo Cliente no estabelecimento para transferência de fundo nas respectivas contas.
            /// </summary>
            PWOPER_CASHWDRWL = 43,

            /// <summary>
            /// (Baixa técnica) Registra uma intervenção técnica no estabelecimento perante o Provedor.
            /// </summary>
            PWOPER_LOCALMAINT = 44,

            /// <summary>
            /// Consulta taxas de financimento referentes a uma possível venda parcelada, sem efetivar a transferência de fundos ou impactar o limite de crédito do Cliente.
            /// </summary>
            PWOPER_FINANCINQ = 45,

            /// <summary>
            /// Verifica o endereço do Cliente (Utiliza o Provedor para tal).
            /// </summary>
            PWOPER_ADDRVERIF = 46,

            /// <summary>
            /// Efetiva pré-autorização, previamente realizada, efetuando uma transferência de fundos entre as contas do Estabelecimento e do Cliente.
            /// </summary>
            PWOPER_SALEPRE = 47,

            /// <summary>
            /// Registra o acúmulo de pontos pelo Cliente, a partir de um programa de fidelidade.
            /// </summary>
            PWOPER_LOYCREDIT = 48,

            /// <summary>
            /// Cancela uma transação PWOPER_LOYDEBIT.
            /// </summary>
            PWOPER_LOYCREDVOID = 49,

            /// <summary>
            /// Registra pontos do Cliente (programa de fidelidade).
            /// </summary>
            PWOPER_LOYDEBIT = 50,

            /// <summary>
            /// Cancela uma transação LOYDEBIT
            /// </summary>
            PWOPER_LOYDEBVOID = 51,

            /// <summary>
            /// Exibe um menu com os cancelamentos disponíveis, caso só exista um tipo, este é seleiconado automaticamente.
            /// </summary>
            PWOPER_VOID = 39,

            /// <summary>
            /// Permite consultar a versão da biblioteca atualmente em uso.
            /// </summary>
            PWOPER_VERSION = 252,

            /// <summary>
            /// (configuração), Visualiza e altera os parâmetros de operação locais da biblioteca.
            /// </summary>
            PWOPER_CONFIG = 253,

            /// <summary>
            /// Manutenção, apaga todas as configurações do Ponto de captura, devendo ser novamente realizada uma transação de instalaçao.
            /// </summary>
            PWOPER_MAINTENANCE = 254
        }

        /// <summary>
        /// Enum: Contém os valores e descrições que compõe os tipos de cartão aceitos e processados pelo Paygo Web.
        /// </summary>
        public enum E_PWCardTypes : int
        {
            naoDefinido = 0,
            credito = 1,
            debito = 2,
            voucher = 4,
            outros = 8
        }

        /// <summary>
        /// 
        /// </summary>
        public enum E_PWFinancingTypes : int
        {
            naoDefinido = 0,
            aVista = 1,
            parceladoEmissor = 2,
            parceladoEstabelecimento = 4,
            preDatado = 8
        }

        /// <summary>
        /// 
        /// </summary>
        public enum E_PWCNF : int
        {
            /// <summary>
            /// Transação confirmada pelo Ponto de captura sem intervenção do usuário.
            /// </summary>
            PWCNF_CNF_AUTO = 289,

            PWCNF_CNF_MANU_POS = 4641,

            PWCNF_REV_AUTO_PRN = 65841,

            PWCNF_REV_AUTO_DISP = 131377,

            PWCNF_REV_AUTO_ABORT = 262449,

            PWCNF_REV_MANUAL_POS = 4657
        }

        /// <summary>
        /// Enum: Parâmetros passados para métodos visando completar uma função de acordo com requerimento da DLL.
        /// </summary>
        public enum E_PWINFO : int
        {
            /// <summary>
            /// Preenche (PWOPER_xxx), Consultar os valores possíveis na descrição da função (PW_iNewTransac).
            /// </summary>
            PWINFO_OPERATION = 2,

            /// <summary>
            /// Identificador do Ponto de Captura.
            /// </summary>
            PWINFO_POSID = 17,

            /// <summary>
            /// Nome do aplicativo da Automação Comercial.
            /// </summary>
            PWINFO_AUTNAME = 21,

            /// <summary>
            /// Versão do aplicativo de Automaçao.
            /// </summary>
            PWINFO_AUTVER = 22,

            /// <summary>
            /// Empresa desenvolvedor do aplicativo de automação.
            /// </summary>
            PWINFO_AUTDEV = 23,

            /// <summary>
            /// Endereço TCP/IP para comunicação com a infraestrutura PayGo Web, no formato endereço IP:porta TCP ou nome do servidor:porta TCP
            /// </summary>
            PWINFO_DESTTCPIP = 27,

            /// <summary>
            ///  CNPJ/CPF do estabelecimento, sem formatação. Se utilizadas mais de um estabecilemento de afiliação campo é usado para selecionar o estabelcimento a ser utilizado para determinada transação. Caso não, um menu para escolha manual com váris estabelecimentos deve ser exibido.
            /// </summary>
            PWINFO_MERCHCNPJCPF = 28,

            /// <summary>
            /// Capacidade da Automação (SOMA DOS VALORES)
            /// 1: Funcionalidade de troco/saque;
            /// 2: Funcionalidade de desconto;
            /// 4: Valor fixo, sempre incluir;
            /// 8: impressão das vias diferenciadas do comprovante para Cliente/Estabelecimento;
            /// 16:Impressão do cupom reduzido;
            /// 32: Utiliação de saldo total do voucher para abatimento do valor da compra.
            /// </summary>
            PWINFO_AUTCAP = 36,

            /// <summary>
            /// Valor total da operação.
            /// </summary>
            PWINFO_TOTAMNT = 37,

            /// <summary>
            /// Moeda (padrão ISO4217, 986 parao real).
            /// </summary>
            PWINFO_CURRENCY = 38,

            /// <summary>
            /// Expoente da moeda (2 para centavos).
            /// </summary>
            PWINFO_CURREXP = 39,

            /// <summary>
            /// Identificador do documento fiscal.
            /// </summary>
            PWINFO_FISCALREF = 40,

            /// <summary>
            /// Tipo de cartão utilizado 
            /// 1: crédito;
            /// 2: débito;
            /// 4: voucher/PAT;
            /// 8: outros
            /// </summary>
            PWINFO_CARDTYPE = 41,

            /// <summary>
            /// Nome/Tipo do prorduto utilizado, na nomenclatura do provedor.
            /// </summary>
            PWINFO_PRODUCTNAME = 42,

            /// <summary>
            /// Data e hora local da transação. Formato = AAAAMMDDhhmmss
            /// </summary>
            PWINFO_DATETIME = 49,

            /// <summary>
            /// Referência local da transação
            /// </summary>
            PWINFO_REQNUM = 50,

            /// <summary>
            /// Nome do Provedor: "ELAVON"; "FILLIP"; "LIBERCARD"; "RV"; etc..
            /// </summary>
            PWINFO_AUTHSYST = 53,

            /// <summary>
            /// identificador do Estabelecimento.
            /// </summary>
            PWINFO_VIRTMERCH = 54,

            /// <summary>
            /// Identificador do estabelecimento para o Provedor.
            /// </summary>
            PWINFO_AUTMERCHID = 56,

            /// <summary>
            /// Número do telefone, com DDD (10 ou 11 dígitos).
            /// </summary>
            PWINFO_PHONEFULLNO = 58,

            /// <summary>
            /// Modalidade de financiamento da transação:
            /// 1:à vista;
            /// 2: parcelado pelo emissor,
            /// 4: parcelado pelo estabelcimento;
            /// 8: pré-datado.
            /// </summary>
            PWINFO_FINTYPE = 59,

            /// <summary>
            /// Quantidade de parcelas.
            /// </summary>
            PWINFO_INSTALLMENTS = 60,

            /// <summary>
            /// Data de vencimento do pré-datado, ou da primeira parcela Formato "DDMMAA".
            /// </summary>
            PWINFO_INSTALLMDATE = 61,

            /// <summary>
            /// Identificação do produto utilizado, de acordo com a nomenclatura do Provedor.
            /// </summary>
            PWINFO_PRODUCTID = 62,

            /// <summary>
            /// Msg descrevendo o resultado final da transação. (independe do sucesso). Interface com o usuário..
            /// </summary>
            PWINFO_RESULTMSG = 66,

            /// <summary>
            /// Necessidade de confirmação:
            /// 0: não requer confirmação;
            /// 1: requer confirmação.
            /// </summary>
            PWINFO_CNFREQ = 67,

            /// <summary>
            /// Referência da transação para a infraestrutura Paygo.
            /// </summary>
            PWINFO_AUTLOCREF = 68,

            /// <summary>
            /// Referê cia da transação para o Provedor.
            /// </summary>
            PWINFO_AUTEXTREF = 69,

            /// <summary>
            /// Código de autorização.
            /// </summary>
            PWINFO_AUTHCODE = 70,

            /// <summary>
            /// Cd de resposta da transação.
            /// </summary>
            PWINFO_AUTRESPCODE = 71,

            /// <summary>
            /// Valor do desconto concedido pelo Provedor, considerando PWINFO_CURREXP já reduzido em PWINFO_TOTAMNT.
            /// </summary>
            PWINFO_DISCOUNTAMT = 73,

            /// <summary>
            /// Valor do saque/troco.
            /// </summary>
            PWINFO_CASHBACKAMT = 74,

            /// <summary>
            /// Nome do cartção ou do emissor do cartão.
            /// </summary>
            PWINFO_CARDNAME = 75,

            /// <summary>
            /// Modalidade da transação. 1: Online; 2: off-line.
            /// </summary>
            PWINFO_ONOFF = 76,

            /// <summary>
            /// Valor da taxa de embarque, pconsidera valores já inclsusos em outras funções.
            /// </summary>
            PWINFO_BOARDINGTAX = 77,

            /// <summary>
            /// Valor da taxa de serviço (gorjeta), considera outros valores já inclusos.
            /// </summary>
            PWINFO_TIPAMOUNT = 78,

            /// <summary>
            /// Valor da entrada para um pagamento parcelado, considera outros valores já inclusos.
            /// </summary>
            PWINFO_INSTALLM1AMT = 79,

            /// <summary>
            /// Valor da parcela, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.
            /// </summary>
            PWINFO_INSTALLMAMNT = 80,

            /// <summary>
            /// Comprovante para impressão - Via completa. Até 40 colunas, quebras de linha identificadas pelo Caractere 0Dh
            /// </summary>
            PWINFO_RCPTFULL = 82,

            /// <summary>
            /// Comprovante para impressão - Via diferenciada para o Estabelecimento.
            /// </summary>
            PWINFO_RCPTMERCH = 83,

            /// <summary>
            /// Via diferenciada para o Cliente.
            /// </summary>
            PWINFO_RCPTCHOLDER = 84,

            /// <summary>
            /// Cupom reduzido (para o cliente).
            /// </summary>
            PWINFO_RCPTCHSHORT = 85,

            /// <summary>
            /// Data de transação original. (no caso de um cancelamento ou pré-autorização).
            /// </summary>
            PWINFO_TRNORIGDATE = 87,

            /// <summary>
            /// NSU da transação original, no caso de um cancelamento ou uma confi de pré-autorização.
            /// </summary>
            PWINFO_TRNORIGNSU = 88,

            /// <summary>
            /// Valor da transação original, no caso de um cancelamento ou uma confirmaçao de pré-autorização.
            /// </summary>
            PWINFO_TRNORIGAMNT = 96,

            /// <summary>
            /// Idioma a ser utilizado para a interface com o cliente:
            /// 0: Português;
            /// 1: Inglês;
            /// 2: Espanhol.
            /// </summary>
            PWINFO_LANGUAGE = 108,

            /// <summary>
            /// Código de autorização da transação original (caso cancel ou pré-auto).
            /// </summary>
            PWINFO_TRNORIGAUTH = 98,

            /// <summary>
            /// Número da solicitção da transação original, no casol de um cancelm ou pré-autor..
            /// </summary>
            PWINFO_TRNORIGREQNUM = 114,

            /// <summary>
            /// Hora da transação original, no caso de um canc, ou transac pré.. (HHMMSS).
            /// </summary>
            PWINFO_TRNORIGTIME = 115,

            /// <summary>
            /// Msg a ser exibida para o operador no terminal no caso da transação ser abortada (cancel ou timeout).
            /// </summary>
            PWINFO_CNCDSPMSG = 116,

            /// <summary>
            /// Mensagem a ser exibida para o portador no PIN-pad no caso da transação ser abortada (cancelamento ou timeout).s
            /// </summary>
            PWINFO_CNCPPMSG = 117,

            /// <summary>
            /// Msg a ser exibida caso a operação seja abortada. Modos de entrada do cartão: 1: digitado; 2: tj magnética; 4: chip com contato; 16: fallback de  chip p/tarja; 32: chip sem contato simulando tarja(cliente informa tipo efetivamente utilizado); 64: chip sem contato EMV (cli informa); 256: fallback de tj para digitado.
            /// </summary>
            PWINFO_CARDENTMODE = 192,

            /// <summary>
            /// número de cartão completo para transação digitada.
            /// </summary>
            PWINFO_CARDFULLPAN = 193,

            /// <summary>
            /// Dt Vencimento do cartão MMAA
            /// </summary>
            PWINFO_CARDEXPDATE = 194,

            /// <summary>
            /// Número do cartão truncado ou mascarado.
            /// </summary>
            PWINFO_CARDPARCPAN = 200,

            /// <summary>
            /// Verificação do portador, soma dos seguintes valores:
            /// 1: assinatura do portador em papel;
            /// 2: Senha verificada off-line;
            /// 4: Senha off-line bloqueada no decorrer desta transação;
            /// 8: Senha verificada online.
            /// </summary>
            PWINFO_CHOLDVERIF = 207,

            /// <summary>
            /// Mod de entrada do código de barras:
            /// 1: digitado;
            /// 2: lido através de dispositivo eletrônico.
            /// </summary>
            PWINFO_BARCODENTMODE = 233,

            /// <summary>
            /// Cd de barras completo lido ou digitado.
            /// </summary>
            PWINFO_BARCODE = 234,

            /// <summary>
            /// Dados adicionais relevantes para automação (#1).
            /// </summary>
            PWINFO_MERCHADDDATA1 = 240,

            /// <summary>
            /// Dados adicionais relevantes para automação (#2).
            /// </summary>
            PWINFO_MERCHADDDATA2 = 241,

            /// <summary>
            /// Dados adicionais relevantes para automação (#3).
            /// </summary>
            PWINFO_MERCHADDDATA3 = 242,

            /// <summary>
            /// Dados adicionais relevantes para automação (#4).
            /// </summary>
            PWINFO_MERCHADDDATA4 = 243,

            /// <summary>
            /// Indica quais vias de comprovante devem ser impressas:
            /// 0: não há comprovante;
            /// 1: imprimir somente a via do Cliente;
            /// 2: imprimir somente a via do Estabelecimento;
            /// 3: imprimir mabas as vias doCliente e do Estabelecimento.
            /// </summary>
            PWINFO_RCPTPRN = 244,

            /// <summary>
            /// Identificador do usuário autenticado com a senha do lojista
            /// </summary>
            PWINFO_AUTHMNGTUSER = 245,

            /// <summary>
            /// Identificador do usuário autenticado com a senha técnica.
            /// </summary>
            PWINFO_AUTHTECHUSER = 246,

            /// <summary>
            /// Modalidade de pagamento:
            /// 1: cartão;
            /// 2: dinheiro;
            /// 3: cheque.
            /// </summary>
            PWINFO_PAYMNTTYPE = 7969,

            /// <summary>
            /// Indica se o ponto de captura faz ou nao o uso de PIN-pad.
            /// </summary>
            PWINFO_USINGPINPAD = 32513,

            /// <summary>
            /// Número da porta serial à qual o PIN-pad está conectado. O Valor 0 indica uma busca automática desta porta.
            /// </summary>
            PWINFO_PPCOMMPORT = 32514,

            /// <summary>
            /// Próxima data e horário que pw_iIdleProc deve ser chamada pela Automação. AAMMDDHHMMSS
            /// </summary>
            PWINFO_IDLEPROCTIME = 32516,

            /// <summary>
            /// Nome do provedor para o qual existe uma transação pendente.
            /// </summary>
            PWINFO_PNDAUTHSYST = 32517,

            /// <summary>
            /// Identificador do estabelecimento para o qual existe uma transação pendente.
            /// </summary>
            PWINFO_PNDVIRTMERCH = 32518,

            /// <summary>
            /// Referência da transação que está pendente.
            /// </summary>
            PWINFO_PNDREQNUM = 32519,

            /// <summary>
            /// Referência para infraestrutura Paygo da transação pendente.
            /// </summary>
            PWINFO_PNDAUTLOCREF = 32520,

            /// <summary>
            /// Referência para o Provedor da transaçsão que está pendente.
            /// </summary>
            PWINFO_PNDAUTEXTREF = 32521,

            /// <summary>
            /// Texto exibido para um item de menu selecionado pelo usuário.
            /// </summary>
            PWINFO_LOCALINFO1 = 32522,

            /// <summary>
            /// Indica se oponto de captura possui alguma pendência a ser resolvida com o Paygo. 1: Possui
            /// </summary>
            PWINFO_SERVERPND = 32523,

            /// <summary>
            /// 
            /// </summary>
            PWINFO_PPINFO = 0x7F15,

            /// <summary>
            /// Valor devido pelo usuário considerando PWINFO_TOTAMNT e PWINFO_CURREXP.
            /// </summary>
            PWINFO_DUEAMNT = 0xBF06,

            /// <summary>
            /// Valor total da transação reajustado, este campo será utilizado caso o autorizador, por alguma regra de negócio específica dele, resolva alterar o valor total que foi solictado para atransação.
            /// </summary>
            PWINFO_READJUSTEDAMNT = 0xBF09
        }

        /// <summary>
        /// Enum: Retornos da DLL de acordo com funções executadas.
        /// </summary>
        public enum E_PWRET
        {
            /// <summary>
            /// Sucesso!
            /// </summary>
            PWRET_OK = 0,

            /// <summary>
            /// Transação Pendente
            /// </summary>
            PWRET_FROMHOSTPENDTRN = -2599,

            /// <summary>
            /// Falha de autenticação de ponto de captura
            /// </summary>
            PWRET_FROMHOSTPOSAUTHERR = -2598,

            /// <summary>
            /// Falha de autenticação do usuário
            /// </summary>
            PWRET_FROMHOSTUSRAUTHERR = -2597,

            /// <summary>
            /// Erro interno da infraestrutura Paygo
            /// </summary>
            PWRET_FROMHOST = -2596,

            /// <summary>
            /// Codificação da mensagem = Falha de comunicação com a infraestrutura Paygo
            /// </summary>
            PWRET_TLVERR = -2595,

            /// <summary>
            /// Parâmetro inválido : Falha de comunicação com ifraestrutura Paygo
            /// </summary>
            PWRET_SRVINVPARAM = -2594,

            /// <summary>
            /// Falta de parâmetro obrigatório : Falha de comunicação com infraestrutura Paygo
            /// </summary>
            PWRET_REQPARAM = -2593,

            /// <summary>
            /// Conexão ao host : Erro interno da biblioteca
            /// </summary>
            PWRET_HOSTCONNUNK = -2592,

            /// <summary>
            /// Erro interno da biblioteca
            /// </summary>
            PWRET_INTERNALERR = -2591,

            /// <summary>
            /// Ponto de Captura bloqueado para uso
            /// </summary>
            PWRET_BLOCKED = -2590,

            /// <summary>
            /// Transação referenciada não encontrada. Cancelamento, confirmação, etc..
            /// </summary>
            PWRET_FROMHOSTTRNNFOUND = -2589,

            /// <summary>
            /// Inconsistência dos parâmetros recebidos.
            /// </summary>
            PWRET_PARAMSFILEERR = -2588,

            /// <summary>
            /// Ponto de captura não cacpacitado de efetuar captura do cartão através dos parâmetros de entrada.
            /// </summary>
            PWRET_NOCARDENTMODE = -2587,

            /// <summary>
            /// Código de Afiliação Inválida
            /// </summary>
            PWRET_INVALIDVIRTMERCH = -2586,

            /// <summary>
            /// Tempo de resposta esgotado
            /// </summary>
            PWRET_HOSTTIMEOUT = -2585,

            /// <summary>
            /// Erro de configuração (acionar a função de config)
            /// </summary>
            PWRET_CONFIGREQUIRED = -2584,

            /// <summary>
            /// Falha de conexão
            /// </summary>
            PWRET_HOSTCONNERR = -2583,

            /// <summary>
            /// Conexão interrompida
            /// </summary>
            PWRET_HOSTCONNLOST = -2582,

            /// <summary>
            /// Falho no acesso da biblioteca de integração.
            /// </summary>
            PWRET_FILEERR = -2581,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (aplicação)
            /// </summary>
            PWRET_PINPADERR = -2580,

            /// <summary>
            /// Formato de Tarja magnética não reconhecido
            /// </summary>
            PWRET_MAGSTRIPEERR = -2579,

            /// <summary>
            /// Falha de comunicação com o PIN-pad, comunicação não segura.
            /// </summary>
            PWRET_PPCRYPTERR = -2578,

            /// <summary>
            /// Falha no certificado SSL.
            /// </summary>
            PWRET_SSLCERTERR = -2577,

            /// <summary>
            /// Falha ao tentar estabelecer conexão SSL.
            /// </summary>
            PWRET_SSLNCONN = -2576,

            /// <summary>
            /// Falha no registroo GPRS.
            /// </summary>
            PWRET_GPRSATTACHFAILED = -2575,

            /// <summary>
            /// Parâmetro inválido passado à função.
            /// </summary>
            PWRET_INVPARAM = -2499,

            /// <summary>
            /// Ponto de captura não instalado, acionar função para
            /// </summary>
            PWRET_NOTINST = -2498,

            /// <summary>
            /// Falta de dados para transação ser realizada
            /// </summary>
            PWRET_MOREDATA = -2497,

            /// <summary>
            /// Informação solicitada indisponível
            /// </summary>
            PWRET_NODATA = -2496,

            /// <summary>
            /// A automação deve apresentar uma mensagem para o usuário.
            /// </summary>
            PWRET_DISPLAY = -2495,

            /// <summary>
            /// Função chamada no momento incorreto
            /// </summary>
            PWRET_INVCALL = -2494,

            /// <summary>
            /// Nada a fazer, continuar procedimento
            /// </summary>
            PWRET_NOTHING = -2493,

            /// <summary>
            /// Tamanho da área de memória informado é insuficiente
            /// </summary>
            PWRET_BUFOVFLW = -2492,

            /// <summary>
            /// Operação cancelada pelo operador.
            /// </summary>
            PWRET_CANCEL = -2491,

            /// <summary>
            /// Tempo limite excedido para ação do operador
            /// </summary>
            PWRET_TIMEOUT = -2490,

            /// <summary>
            /// PIN-pad não encontrado na busca efetuada.
            /// </summary>
            PWRET_PPNOTFOUND = -2489,

            /// <summary>
            /// Função PW_iNewTransac não foi chamada
            /// </summary>
            PWRET_TRNNOTINIT = -2488,

            /// <summary>
            /// PW_iInit não foi chamada
            /// </summary>
            PWRET_DLLNOTINIT = -2487,

            /// <summary>
            /// Erro no cartão magnético, passar a aceitar o cartão ditiado caso já não esteja sendo aceito.
            /// </summary>
            PWRET_FALLBACK = -2486,

            /// <summary>
            /// Falha de gravação no diretório de trabalho.
            /// </summary>
            PWRET_WRITERR = -2485,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (protocolo).
            /// </summary>
            PWRET_PPCOMERR = -2484,

            /// <summary>
            /// Alguns dos parâmetros obrigatórios não foram adicionados.
            /// </summary>
            PWRET_NOMANDATORY = -2483,

            /// <summary>
            /// Confirmação inexistente ou já confirmada.
            /// </summary>
            PWRET_INVALIDTRN = -2482,

            /// <summary>
            /// Erros do PIN-pad
            /// </summary>
            PWRET_PPS_XXX = -2200
        }
        
        /// <summary>
        /// Enum: Possibilidades de fornecimento/recolhimento de dados.
        /// </summary>
        public enum E_PWDAT
        {
            /// <summary>
            /// Menu de opções
            /// </summary>
            PWDAT_MENU = 1,

            /// <summary>
            /// Entrada digitada
            /// </summary>
            PWDAT_TYPED = 2,

            /// <summary>
            /// Dados do cartão, obtidos do PIN-pad ou digitados.
            /// </summary>
            PWDAT_CARDINF = 3,

            /// <summary>
            /// Informação digitada pelo Cliente no PIN-pad.
            /// </summary>
            PWDAT_PPENTRY = 5,

            /// <summary>
            /// Dado criptografado digitado pelo Cliente no PIN-pad (senha/dados crip).
            /// </summary>
            PWDAT_PPENCPIN = 6,

            /// <summary>
            /// Dados resultantes do processasmento off-line do cartão com chip, obtidos do PIN-pad.
            /// </summary>
            PWDAT_CARDOFF = 9,

            /// <summary>
            /// Dados resultantes do processamento on-line do cartção com chip, obtidos do PIN-pad.
            /// </summary>
            PWDAT_CARDONL = 10,

            /// <summary>
            /// Confirmação pelo Cliente no PIN-pad.
            /// </summary>
            PWDAT_PPCONF = 11,

            /// <summary>
            /// Código de barras, lido ou digitado
            /// </summary>
            PWDAT_BARCODE = 12,

            /// <summary>
            /// Remoção do cartão do PIN-pad.
            /// </summary>
            PWDAT_PPREMCRD = 13,

            /// <summary>
            /// Validação de senha.
            /// </summary>
            PWDAT_USERAUTH = 17
        }
    }
}
