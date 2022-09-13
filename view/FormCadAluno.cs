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
            tbnome.Clear();
            tbnome.Enabled = true;
            mtbcpf.Clear();
            mtbcpf.Enabled = true;
            tbidade.Clear();
            tbidade.Enabled = true;
            tbendereco.Clear();
            tbendereco.Enabled = true;
            mtbcelular.Clear();
            mtbcelular.Enabled = true;
            tbemail.Clear();
            tbemail.Enabled = true;
            tbpeso.Clear();
            tbpeso.Enabled = true;
            tbaltura.Clear();
            tbaltura.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbnome.Enabled = true;
            mtbcpf.Enabled = true;
            tbidade.Enabled = true;
            tbendereco.Enabled = true;
            mtbcelular.Enabled = true;
            tbemail.Enabled = true;
            tbpeso.Enabled = true;
            tbaltura.Enabled = true;
            btsalvar.Enabled = true;
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbpeso.Clear();
            tbaltura.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbcpf.Text == "___________" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "___________" || tbemail.Text == "" || tbpeso.Text == "" || tbaltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var cpfValido = Funcoes.validarCpf(mtbcpf.Text);
                var celularValido = Funcoes.validarCelular(mtbcelular.Text);
                if (cpfValido)
                {
                    if (celularValido)
                    {
                        Aluno alunos = new Aluno();

                        alunos.nome = tbnome.Text;
                        alunos.cpf = mtbcpf.Text;
                        alunos.idade = int.Parse(tbidade.Text);
                        alunos.endereco = tbendereco.Text;
                        alunos.celular = mtbcelular.Text;
                        alunos.email = tbemail.Text;
                        alunos.peso = float.Parse(tbpeso.Text);
                        alunos.altura = float.Parse(tbaltura.Text);

                        Funcoes funcoes = new Funcoes();

                        string cpf = mtbcpf.Text;
                        funcoes.verificarCpfAluno(cpf, alunos);
                        tabControl1.SelectedTab = tabPage1;
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
