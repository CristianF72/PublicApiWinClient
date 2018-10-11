using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PublicApiWinClient
{
    public partial class Form1 : Form
    {
        
        private readonly decimal _czk = (decimal)DeserializeJson(textResponseAPI.Text).rates.CZK;
        private readonly decimal _gbp = (decimal)DeserializeJson(textResponseAPI.Text).rates.GBP;
        private readonly decimal _ron = (decimal)DeserializeJson(textResponseAPI.Text).rates.RON;
        private readonly decimal _eur = (decimal)DeserializeJson(textResponseAPI.Text).rates.EUR;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("EUR");
            comboBox1.Items.Add("CZK");
            comboBox1.Items.Add("GBP");
            comboBox1.Items.Add("RON");

            comboBox2.Items.Add("EUR");
            comboBox2.Items.Add("CZK");
            comboBox2.Items.Add("GBP");
            comboBox2.Items.Add("RON");
        }

        #region UI Event Handler

        //https://www.youtube.com/watch?v=11f5KzVNQ90&t=5s
        //web-api --> http://data.fixer.io/api/latest?access_key=82317600e69a22e0938a30092fbfa178
        private void CmdExecute_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient();
            restClient.endPoint = textURI.Text;

            //restClient.userName = textUserName.Text;
            //restClient.userPassword = textPassword.Text;


            //debugOutput("clientul REST a fost creat");

            string strResponse = string.Empty;

            strResponse = restClient.makeRequest();

            DebugOutput(strResponse);

        }

        private void CmdDeserialize_Click(object sender, EventArgs e)
        {
            //debugDeserializeOutput(textResponseAPI.Text);
            DeserializeJson(textResponseAPI.Text);
        }

        private void CmdClearDebug_Click(object sender, EventArgs e)
        {
            textDebugOuput.Text = string.Empty;
        }

        #endregion

        #region JSON functions

        private static dynamic DeserializeJson(string strJson)
        {
            if (strJson == null) throw new ArgumentNullException(nameof(strJson));
            dynamic jsonCurrencyConvertor = null;
            try
            {
                jsonCurrencyConvertor = JsonConvert.DeserializeObject<dynamic>(strJson);

                //debugDeserializeOutput("Obiectul JSON: " + jsonConvertorValutar.ToString());

                DebugDeserializeOutput("Data de astăzi este: " + jsonCurrencyConvertor.date);

                DebugDeserializeOutput("Moneda de referinta este: " + jsonCurrencyConvertor.@base);

                DebugDeserializeOutput("Rata de schimb pentru coroane cehești este: " + jsonCurrencyConvertor.rates.CZK);

                DebugDeserializeOutput("Rata de schimb pentru lire sterlin(g)e este: " + jsonCurrencyConvertor.rates.GBP);

                DebugDeserializeOutput("Rata de schimb pentru lei românești este: " + jsonCurrencyConvertor.rates.RON);
            }
            catch (Exception e)
            {
                DebugDeserializeOutput("Eroare la deserializare: " + e.Message.ToString());
            }
            return jsonCurrencyConvertor;
        }

        #endregion

        #region Debug Output
        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textResponseAPI.Text = textResponseAPI.Text + strDebugText + Environment.NewLine;
                textResponseAPI.SelectionStart = textResponseAPI.TextLength;
                textResponseAPI.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private static void DebugDeserializeOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textDebugOuput.Text = textDebugOuput.Text + strDebugText + Environment.NewLine;
                textDebugOuput.SelectionStart = textDebugOuput.TextLength;
                textDebugOuput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, /*ToString()*/ Environment.NewLine);
            }
        }



        #endregion

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ConversionButton(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.LoadFrom("currencyconversion.dll");

            //object currencyConversion = assembly.CreateInstance("CurrencyConversion.CurrencyConversion");

            //if (currencyConversion != null)
            //{
                //Type type = currencyConversion.GetType();
            //}

            //BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;

           // MethodInfo methodInfo = Type.GetMethod("ConverseCurrency", bindingFlags);

           // methodInfo.Invoke(currencyConversion, null);

            //Console.ReadKey();

            string fromCurrency = comboBox1.SelectedItem.ToString();

            string toCurrency = comboBox2.SelectedItem.ToString();

            CurrencyConversion.CurrencyConversion currencyConversion = new CurrencyConversion.CurrencyConversion();

            currencyConversion.ConverseCurrency(fromCurrency, toCurrency, valueForConversion.Value);

        }



        
    }
}
