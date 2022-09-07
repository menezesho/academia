using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace projetofinal
{
    public partial class Form1 : Form
    {
        int a = 0;
        Aluno[] alunos = new Aluno[20];
        Form2 F2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            F2 = FormPrincipal.F2;
        }
        public Form1(Form2 f)
        {
            InitializeComponent();
            F2 = f;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int nmatricula = a + 1;
            tbmatricula.Text = nmatricula.ToString();

        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
            {
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Close();
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
            }
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || tbpeso.Text == "" || tbaltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //alunos[a] = new Aluno(tbnome.Text, mtbcpf.Text, tbendereco.Text, mtbcelular.Text, tbemail.Text, tbsenha.Text, int.Parse(tbidade.Text), float.Parse(tbpeso.Text), float.Parse(tbaltura.Text), a + 1);
                a++;
                F2.insereDados(int.Parse(tbmatricula.Text), tbnome.Text, mtbcpf.Text, int.Parse(tbidade.Text), tbendereco.Text, mtbcelular.Text, tbemail.Text, tbsenha.Text, float.Parse(tbpeso.Text), float.Parse(tbaltura.Text));

                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = "INSERT INTO aluno VALUES (@matricula, @nome, @cpf, @idade, @endereco, @celular, @email, @senha, @peso, @altura)";
                
                try
                {
                    conexao.Open();
                    for (int i = 0; i < F2.dgpessoas.Rows.Count - 1; i++)
                    {
                        SqlCommand comando = new SqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@matricula", F2.dgpessoas.Rows[i].Cells[0].Value);
                        comando.Parameters.AddWithValue("@nome", F2.dgpessoas.Rows[i].Cells[1].Value);
                        comando.Parameters.AddWithValue("@cpf", F2.dgpessoas.Rows[i].Cells[2].Value);
                        comando.Parameters.AddWithValue("@idade", F2.dgpessoas.Rows[i].Cells[3].Value.ToString());
                        comando.Parameters.AddWithValue("@endereco", F2.dgpessoas.Rows[i].Cells[4].Value);
                        comando.Parameters.AddWithValue("@celular", F2.dgpessoas.Rows[i].Cells[5].Value);
                        comando.Parameters.AddWithValue("@email", F2.dgpessoas.Rows[i].Cells[6].Value);
                        comando.Parameters.AddWithValue("@senha", F2.dgpessoas.Rows[i].Cells[7].Value);
                        comando.Parameters.AddWithValue("@peso", F2.dgpessoas.Rows[i].Cells[8].Value.ToString());
                        comando.Parameters.AddWithValue("@altura", F2.dgpessoas.Rows[i].Cells[9].Value.ToString());

                        comando.CommandText = sql;
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
                F2.dgpessoas.Rows.Clear();

                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
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
            tbmatricula.Text = (a + 1).ToString();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//btbuscar
            string cpf = mtbcpf.Text;
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
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
