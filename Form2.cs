using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            
        }

        public void insereDados(int matricula, string nome, string cpf, int idade, string endereco, string celular, string email, float peso, float altura, string aula)
        {
            DataGridViewRow linha = (DataGridViewRow)dgpessoas.Rows[0].Clone();
            linha.Cells[0].Value = matricula;
            linha.Cells[1].Value = nome;
            linha.Cells[2].Value = cpf;
            linha.Cells[3].Value = idade;
            linha.Cells[4].Value = endereco;
            linha.Cells[5].Value = celular;
            linha.Cells[6].Value = email;
            linha.Cells[7].Value = peso;
            linha.Cells[8].Value = altura;
            linha.Cells[9].Value = aula;
            dgpessoas.Rows.Add(linha);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }
    }
}
