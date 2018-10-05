using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicApiWinClient
{
    public partial class Form1 : Form
    {
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

        private void cmdExecuta_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient();
            restClient.endPoint = textURI.Text;

            //debugOutput("clientul REST a fost creat");

            string strResponse = string.Empty;

            strResponse = restClient.makeRequest();

            debugOutput(strResponse);

        }

        private void cmdDeserializare_Click(object sender, EventArgs e)
        {
            //debugDeserializeOutput(textResponseAPI.Text);
            deserialiseJSON(textResponseAPI.Text);
        }

        private void cmdClearDebug_Click(object sender, EventArgs e)
        {
            textDebugOuput.Text = string.Empty;
        }

        #endregion

        #region JSON functions
        
        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jsonConvertorValutar = JsonConvert.DeserializeObject<dynamic>(strJSON);

                //debugDeserializeOutput("Obiectul JSON: " + jsonConvertorValutar.ToString());

                debugDeserializeOutput("Data de astăzi este: " + jsonConvertorValutar.date);

                debugDeserializeOutput("Moneda de referinta este: " + jsonConvertorValutar.@base);

                debugDeserializeOutput("Rata de schimb pentru coroane cehești este: " + jsonConvertorValutar.rates.CZK);

                debugDeserializeOutput("Rata de schimb pentru lire sterlin(g)e este: " + jsonConvertorValutar.rates.GBP);

                debugDeserializeOutput("Rata de schimb pentru lei românești este: " + jsonConvertorValutar.rates.RON);
            }
            catch (Exception e)
            {
                debugDeserializeOutput("Eroare la deserializare: " + e.Message.ToString());
            }
        }

        #endregion

        #region Debug Output
        private void debugOutput(string strDebugText)
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

        private void debugDeserializeOutput(string strDebugText)
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
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }




        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conversieButton(object sender, EventArgs e)
        {
            string tipModedaDeConvertit = comboBox1.SelectedItem.ToString();
            string tipModedaInConvertit = comboBox2.SelectedItem.ToString();
            switch (tipModedaDeConvertit)
            {
                case "EUR":
                    switch (tipModedaInConvertit)
                    {
                        case "EUR":
                            valoareDupaConversie.Value = sumaDeConvertit.Value;
                        break;

                        case "CZK":
                            //valoareDupaConversie.Value = sumaDeConvertit.Value * jsonConvertorValutar.rates.CZK;
                            break;
                    }


                    break;


                case ".json":
                    //butonSalveazaJson.PerformClick();
                    break;
                case ".bin":
                   //butonSalveazaBinar.PerformClick();
                    break;
                case ".zip":
                    //butonSalveazaZip.PerformClick();
                    break;
            }
        }
    }
}
