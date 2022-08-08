using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormPrincipal : Form
    {
        public static Form2 F2 = new Form2();
        public static Form1 F1 = new Form1();
        public static Form4 F4 = new Form4();
        public static Form3 F3 = new Form3(F4);
        FormAjuda Fajuda = new FormAjuda();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            //sai do programa
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chama o forms para o cadastro de aluno
            F1.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chama o forms para o cadastro de professor
            F3.ShowDialog();

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chama o forms que mostra os dados cadastrados em alunos e os mostra numa tabela
            F2.ShowDialog();

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chama o forms que mostra os dados cadastrados de professores em uma tabela, como a de alunos
            F4.ShowDialog();

        }
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> AJUDA
            Fajuda.ShowDialog();
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {//ESC PARA SAIR
            if (e.KeyValue.Equals(27))
            {
                if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
