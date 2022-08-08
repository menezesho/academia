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
        FormAjuda Fajuda = new FormAjuda();

        public Form4()
        {
            InitializeComponent();
        }

        public void insereDados2(int cracha, string nome, string cpf, int idade, string endereco, string celular, string email, string aula)
        {
            //percorre e preenche todos os campos do datagrid para a exibição de dados
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> SAIR | verifica a ação de retorno, e pergunta ao usuário se deseja mesmo voltar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {//ESC PARA RETORNAR
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void dgprofessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> AJUDA
            Fajuda.ShowDialog();
        }
    }
}
