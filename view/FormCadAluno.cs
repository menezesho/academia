using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace projetofinal
{
    public partial class FormCadAluno : Form
    {
        int a = 0;

        public FormCadAluno()
        {
            InitializeComponent();
        }
        /*public Form1(Form2 f)
        {
            InitializeComponent();
            F2 = f;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            int nmatricula = a + 1;
            tbmatricula.Text = nmatricula.ToString();

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
            tbsenha.Clear();
            tbsenha.Enabled = true;
            tbpeso.Clear();
            tbpeso.Enabled = true;
            tbaltura.Clear();
            tbaltura.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
        }

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

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == ""  || tbsenha.Text == "" || tbpeso.Text == "" || tbaltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Aluno alunos = new Aluno();

                alunos.matricula = int.Parse(tbmatricula.Text);
                alunos.nome = tbnome.Text;
                alunos.cpf = mtbcpf.Text;
                alunos.idade = int.Parse(tbidade.Text);
                alunos.endereco = tbendereco.Text;
                alunos.celular = mtbcelular.Text;
                alunos.email = tbemail.Text;
                alunos.senha = tbsenha.Text;
                alunos.peso = float.Parse(tbpeso.Text);
                alunos.altura = float.Parse(tbaltura.Text);

                Funcoes funcoes = new Funcoes();
                funcoes.cadastrarAluno(alunos);

                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
                tbsenha.Clear();
                tbpeso.Clear();
                tbaltura.Clear();
                tabControl1.SelectedTab = tabPage1;
                tbmatricula.Text = (a + 1).ToString();
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbnome.Enabled = true;
            mtbcpf.Enabled = true;
            tbidade.Enabled = true;
            tbendereco.Enabled = true;
            mtbcelular.Enabled = true;
            tbemail.Enabled = true;
            tbsenha.Enabled = true;
            tbpeso.Enabled = true;
            tbaltura.Enabled = true;
            btsalvar.Enabled = true;
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            tbpeso.Clear();
            tbaltura.Clear();
            tbmatricula.Text = (a + 1).ToString();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//btbuscar
            /*string cpf = mtbcpf.Text;
            bool achou = false;
            if (mtbcpf.Text == "   .   .   -")
                MessageBox.Show("Nenhum CPF foi digitado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < a; i++)
                {
                    if (alunos[i].cpf == cpf)
                    {
                        tbmatricula.Text = alunos[i].matricula.ToString();
                        tbnome.Enabled = false;
                        tbnome.Text = alunos[i].nome;
                        mtbcpf.Enabled = false;
                        mtbcpf.Text = alunos[i].cpf;
                        tbidade.Enabled = false;
                        tbidade.Text = alunos[i].idade.ToString();
                        tbendereco.Enabled = false;
                        tbendereco.Text = alunos[i].endereco;
                        mtbcelular.Enabled = false;
                        mtbcelular.Text = alunos[i].celular;
                        tbemail.Enabled = false;
                        tbemail.Text = alunos[i].email;
                        tbpeso.Enabled = false;
                        tbpeso.Text = alunos[i].peso.ToString();
                        tbaltura.Enabled = false;
                        tbaltura.Text = alunos[i].altura.ToString();
                        btsalvar.Enabled = false;
                        achou = true;
                        MessageBox.Show("Aluno localizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!achou)
                    MessageBox.Show("Aluno não cadastrado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
