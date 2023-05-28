using BLL;
using System.Net;
using System.Text.RegularExpressions;
namespace BancoEndereco
{
    public partial class frmCEP : Form
    {
        public frmCEP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Método 1
            CEndereco Consulta = new CEndereco();
            CEP cep = Consulta.Consultar(mtxtCEP.Text);
            txtLogradouro.Text = cep.logradouro;
            txtUF.Text = cep.uf;
            txtLocalidade.Text = cep.localidade;
            txtDDD.Text = cep.ddd;
            txtBairro.Text = cep.bairro;


            //Método 2
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mtxtCEP.Text + "/json/");
            //request.AllowAutoRedirect = false;
            //HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            //if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            //{
            //    MessageBox.Show("Servidor indisponível");
            //    return; // Sai da rotina
            //}

            //using (Stream webStream = ChecaServidor.GetResponseStream())
            //{
            //    if (webStream != null)
            //    {
            //        using (StreamReader responseReader = new StreamReader(webStream))
            //        {
            //            string response = responseReader.ReadToEnd();
            //            response = Regex.Replace(response, "[{},]", string.Empty);
            //            response = response.Replace("\"", "");

            //            String[] substrings = response.Split('\n');

            //            int cont = 0;
            //            foreach (var substring in substrings)
            //            {
            //                if (cont == 1)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    if (valor[0] == "  erro")
            //                    {
            //                        MessageBox.Show("CEP não encontrado");
            //                        mtxtCEP.Focus();
            //                        return;
            //                    }
            //                }

            //                //Logradouro
            //                if (cont == 2)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    txtLogradouro.Text = valor[1];
            //                }

            //                //Complemento
            //                if (cont == 3)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    txtComplemento.Text = valor[1];
            //                }

            //                //Bairro
            //                if (cont == 4)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    txtBairro.Text = valor[1];
            //                }

            //                //Localidade (Cidade)
            //                if (cont == 5)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    txtLocalidade.Text = valor[1];
            //                }

            //                //Estado (UF)
            //                if (cont == 6)
            //                {
            //                    string[] valor = substring.Split(":".ToCharArray());
            //                    txtUF.Text = valor[1];
            //                }

            //                cont++;
            //            }
            //        }
            //    }
            //}
        }
    }
    }
