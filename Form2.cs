using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form2 : Form
    {
        FormAjuda Fajuda = new FormAjuda();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> AJUDA
            Fajuda.ShowDialog();
        }

        public void insereDados(int matricula, string nome, string cpf, int idade, string endereco, string celular, string email, float peso, float altura, string aula)
        {
            //percorre os registros e coloca no data grid as informações de maneira organizada para visualização
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
        {//ESC PARA RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }
        private void dgpessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbalunoscadastrados_Click(object sender, EventArgs e)
        {

        }
    }
}
