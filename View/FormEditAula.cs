using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace academia
{
    public partial class FormEditAula : Form
    {
        public FormEditAula()
        {
            InitializeComponent();
        }

        private void FormEditAula_Load(object sender, EventArgs e)
        {
            AulaDAO aulaDAO = new AulaDAO();
            dgaulas.DataSource = aulaDAO.listarAulas();

            dgaulas.Columns["ID"].Width = 50;
            dgaulas.Columns["Nome"].Width = 420;
            dgaulas.Columns["Data"].Width = 120;
            dgaulas.Columns["Horário"].Width = 80;

            tbId.Clear();
            tbNome.Clear();
            tbId.Clear();
            mtbData.Clear();
            cbHora.SelectedIndex = 0;
            tbId.Enabled = false;
            tbNome.Enabled = false;
            mtbData.Enabled = false;
            cbHora.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            tbBusca.Clear();
        }
    }
}
