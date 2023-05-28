using BancoEndereco;

namespace MDICrud
{
    public partial class CRUD : Form
    {
        frmAgenda? FormAgenda;
        frmCEP? FormCEP;
        frmSobre? FormSobre;
        frmUser? FormUser;


        public CRUD()
        {
            InitializeComponent();
        }
        private void MenuAgenda_Click(object sender, EventArgs e)
        {
            if (FormAgenda == null)
            {
                FormAgenda = new frmAgenda();
                FormAgenda.MdiParent = this;
                FormAgenda.WindowState = FormWindowState.Maximized;
                FormAgenda.Show();
            }
            else
            {
                FormAgenda.Activate();
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormCEP == null)
            {
                FormCEP = new frmCEP();
                FormCEP.MdiParent = this;
                FormCEP.WindowState = FormWindowState.Maximized;
                FormCEP.Show();
            }
            else
            {
                FormCEP.Activate();
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FormSobre == null)
            {
                FormSobre = new frmSobre();
                FormSobre.Show();
            }
            else
            {
                FormSobre.Activate();
            }
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FormUser == null)
            {
                FormUser = new frmUser();
                FormUser.MdiParent = this;
                FormUser.Show();
            }
            else
            {
                FormUser.Activate();
            }
        }
    }
}