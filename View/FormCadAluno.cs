using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace projetofinal
{
    public partial class FormCadAluno : Form
    {
        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//load
            tbNome.Clear();
            tbNome.Enabled = true;
            mtbCpf.Clear();
            mtbCpf.Enabled = true;
            tbIdade.Clear();
            tbIdade.Enabled = true;
            tbEndereco.Clear();
            tbEndereco.Enabled = true;
            mtbCelular.Clear();
            mtbCelular.Enabled = true;
            tbEmail.Clear();
            tbEmail.Enabled = true;
            tbPeso.Clear();
            tbPeso.Enabled = true;
            tbAltura.Clear();
            tbAltura.Enabled = true;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbNome.Enabled = true;
            mtbCpf.Enabled = true;
            tbIdade.Enabled = true;
            tbEndereco.Enabled = true;
            mtbCelular.Enabled = true;
            tbEmail.Enabled = true;
            tbPeso.Enabled = true;
            tbAltura.Enabled = true;
            btsalvar.Enabled = true;
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbPeso.Clear();
            tbAltura.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbNome.Text == "" || mtbCpf.Text == "___________" || tbIdade.Text == "" || tbEndereco.Text == "" || mtbCelular.Text == "___________" || tbEmail.Text == "" || tbPeso.Text == "" || tbAltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var cpfValido = Funcoes.validarCpf(mtbCpf.Text);
                var celularValido = Funcoes.validarCelular(mtbCelular.Text);
                if (cpfValido)
                {
                    if (celularValido)
                    {
                        Aluno alunos = new Aluno();

                        alunos.nome = tbNome.Text;
                        alunos.cpf = mtbCpf.Text;
                        alunos.idade = int.Parse(tbIdade.Text);
                        alunos.endereco = tbEndereco.Text;
                        alunos.celular = mtbCelular.Text;
                        alunos.email = tbEmail.Text;
                        alunos.peso = float.Parse(tbPeso.Text);
                        alunos.altura = float.Parse(tbAltura.Text);

                        Funcoes funcoes = new Funcoes();

                        string cpf = mtbCpf.Text;
                        funcoes.verificarCpfAluno(cpf, alunos);
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Retornar

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        #endregion
    }
}
