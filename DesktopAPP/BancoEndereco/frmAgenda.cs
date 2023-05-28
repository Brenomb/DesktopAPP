using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoEndereco
{

    public partial class frmAgenda : Form
    {
        private Repositorio repositorio;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            frmUser frm = new frmUser();
            frm.agenda = agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Create(agenda);
                bsAgenda.Add(agenda);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorio.Delete(bsAgenda.Current as Agenda);
            bsAgenda.Remove(bsAgenda.Current as Agenda);
            bsAgenda.ResetBindings(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.agenda = bsAgenda.Current as Agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Udpate(frm.agenda);
                bsAgenda.ResetBindings(false);
            }
        }
    }
}
