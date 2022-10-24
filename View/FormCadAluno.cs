using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using academia.Class;

namespace projetofinal
{
    public partial class FormCadAluno : Form
    {
        Conexao conec = new Conexao();

        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void FormCadAluno_Load(object sender, EventArgs e)
        {
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbPeso.Clear();
            tbAltura.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbNome.Clear();
                mtbCpf.Clear();
                tbIdade.Clear();
                tbEndereco.Clear();
                mtbCelular.Clear();
                tbEmail.Clear();
                tbPeso.Clear();
                tbAltura.Clear();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text == "" || mtbCpf.Text == "___________" || tbIdade.Text == "" || tbEndereco.Text == "" || mtbCelular.Text == "___________" || tbEmail.Text == "" || tbPeso.Text == "" || tbAltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                if (cpfVerificado)
                {
                    if (celularVerificado)
                    {
                        try
                        {
                            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                            string sqlSelect = @"SELECT * FROM aluno WHERE cpf=@cpf";
                            SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                            comandoSelect.Parameters.AddWithValue("@cpf", mtbCpf.Text);

                            conexao.Open();
                            SqlDataReader dados = comandoSelect.ExecuteReader();
                            if (dados.Read())
                            {
                                MessageBox.Show("CPF já cadastrado, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                conexao.Close();
                            }
                            else
                            {
                                conexao.Close();
                                SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                                string sqlInsert = @"INSERT INTO aluno (nome, cpf, idade, endereco, celular, email, peso, altura) VALUES (@nome, @cpf, @idade, @endereco, @celular, @email, @peso, @altura)";
                                SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                                comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                                comandoInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                comandoInsert.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                                comandoInsert.Parameters.AddWithValue("@endereco", tbEndereco.Text);
                                comandoInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                comandoInsert.Parameters.AddWithValue("@email", tbEmail.Text);
                                comandoInsert.Parameters.AddWithValue("@peso", tbPeso.Text);
                                comandoInsert.Parameters.AddWithValue("@altura", tbAltura.Text);

                                conexao2.Open();
                                comandoInsert.CommandText = sqlInsert;
                                comandoInsert.ExecuteNonQuery();
                                conexao2.Close();
                                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Retornar

        private void FormCadAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
