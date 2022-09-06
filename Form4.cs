using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void insereDados2(int cracha, string nome, string cpf, int idade, string endereco, string celular, string email, string aula)
        {
            DataGridViewRow linha = (DataGridViewRow)dgprofessores.Rows[0].Clone();
            linha.Cells[0].Value = cracha;
            linha.Cells[1].Value = nome;
            linha.Cells[2].Value = cpf;
            linha.Cells[3].Value = idade;
            linha.Cells[4].Value = endereco;
            linha.Cells[5].Value = celular;
            linha.Cells[6].Value = email;
            linha.Cells[7].Value = aula;
            dgprofessores.Rows.Add(linha);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }
    }
}
