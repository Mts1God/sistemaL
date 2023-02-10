using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            carregaCombo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        private void btnCadEsp_Click(object sender, EventArgs e)
        {
            frmEspecialidades abrir = new frmEspecialidades();
            abrir.ShowDialog();
        }

        public void carregaCombo()
        {
            cbbEspecialidades.Items.Add("Clinico Geral");
            cbbEspecialidades.Items.Add("Cardiologista");
            cbbEspecialidades.Items.Add("Pediatria");
            cbbEspecialidades.Items.Add("Neurologia");
            cbbEspecialidades.Items.Add("Plastica");
        }
    }
}
