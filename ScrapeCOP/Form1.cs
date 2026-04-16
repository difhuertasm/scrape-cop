using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;




namespace WebScrapping1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string textCop = textBox1.Text;
                double cop;

                //Validad si una entrada se ingresó con punto decimal y se corrige por coma decimal para su conversión a double.
                if (textCop.Contains("."))
                {
                    textCop = textCop.Replace(".", ",");
                }

                //Valida si una entrada de texto es en efecto un valor numérico de tipo double.
                if (double.TryParse(textCop, out cop))
                {
                    //Valida si una entrada de texto es un valor mayor a cero.
                    if (cop >= 0)
                    {
                        /*Realización de web scrapin mediante html agility pack*/

                        string url = "https://www.riamoneytransfer.com/es-us/rates-conversion/?From=COP&To=EUR&Amount=1"; //Enlace objetivo
                        var web = new HtmlWeb(); //Definición del método html agilty pack
                        var doc = web.Load(url); //Carga el html
                        var spanNode = doc.DocumentNode.SelectSingleNode("//span[@class='']"); //Etiqueta donde se encuentra el contenido a extraer.
                        string valor = spanNode.InnerText.Replace(".", ","); // Obtiene el valor en string y reemplaza punto por coma decimal
                        double eurIn = Convert.ToDouble(valor);//Conversión a valor decimal
                        double euro = Math.Round(eurIn * cop, 4); //Cálculo en Euros a partir del peso colombiano ingresado.


                        string url2 = "https://www.riamoneytransfer.com/es-us/rates-conversion/?From=COP&To=USD&Amount=1";
                        var web2 = new HtmlWeb();
                        var doc2 = web2.Load(url2);
                        var spanNode2 = doc2.DocumentNode.SelectSingleNode("//span[@class='']");
                        string valor2 = spanNode2.InnerText.Replace(".", ",");
                        double usdIn = Convert.ToDouble(valor2);
                        double usd = Math.Round(usdIn * cop, 4);

                        string url3 = "https://www.riamoneytransfer.com/es-us/rates-conversion/?From=COP&To=MXN&Amount=1";
                        var web3 = new HtmlWeb();
                        var doc3 = web3.Load(url3);
                        var spanNode3 = doc3.DocumentNode.SelectSingleNode("//span[@class='']");
                        string valor3 = spanNode3.InnerText.Replace(".", ",");
                        double mxnIn = Convert.ToDouble(valor3);
                        double mxn = Math.Round(mxnIn * cop, 4);

                        string url4 = "https://www.riamoneytransfer.com/es-us/rates-conversion/?From=COP&To=BRL&Amount=1";
                        var web4 = new HtmlWeb();
                        var doc4 = web4.Load(url4);
                        var spanNode4 = doc4.DocumentNode.SelectSingleNode("//span[@class='']");
                        string valor4 = spanNode4.InnerText.Replace(".", ",");
                        double brlIn = Convert.ToDouble(valor4);
                        double brl = Math.Round(brlIn * cop, 4);

                        string url5 = "https://www.riamoneytransfer.com/es-us/rates-conversion/?From=COP&To=JPY&Amount=1";
                        var web5 = new HtmlWeb();
                        var doc5 = web5.Load(url5);
                        var spanNode5 = doc5.DocumentNode.SelectSingleNode("//span[@class='']");
                        string valor5 = spanNode5.InnerText.Replace(".", ",");
                        double jpyIn = Convert.ToDouble(valor5);
                        double jpy = Math.Round(jpyIn * cop, 4);

                        /* Asignación de valores a las correspondientes cajas de texto (salida).*/
                        textBox2.Text = euro.ToString();
                        textBox3.Text = usd.ToString();
                        textBox4.Text = mxn.ToString();
                        textBox5.Text = brl.ToString();
                        textBox6.Text = jpy.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor numérico y sin espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) {
                MessageBox.Show($"Ocurrió un error de tipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
