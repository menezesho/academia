using academia.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormCadProf : Form
    {
        Conexao conec = new Conexao();

        public FormCadProf()
        {
            InitializeComponent();
        }

        private void FormCadProf_Load(object sender, EventArgs e)
        {
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
            tbUsuario.Clear();
            tbUsuario.Enabled = true;
            tbSenha.Clear();
            tbSenha.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            
            tbUsuario.Clear();
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbSenha.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text == "" || mtbCpf.Text == "___________" || tbIdade.Text == "" || tbEndereco.Text == "" || mtbCelular.Text == "___________" || tbSenha.Text == "" || tbUsuario.Text == "" || tbSenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            string sqlSelect = @"SELECT * FROM professor WHERE cpf=@cpf";
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
                                string sqlInsert = @"INSERT INTO professor (nome, cpf, idade, endereco, celular, email, usuario, senha) VALUES (@nome, @cpf, @idade, @endereco, @celular, @email, @usuario, @senha)";
                                SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                                comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                                comandoInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                comandoInsert.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                                comandoInsert.Parameters.AddWithValue("@endereco", tbEndereco.Text);
                                comandoInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                comandoInsert.Parameters.AddWithValue("@email", tbEmail.Text);
                                comandoInsert.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                                comandoInsert.Parameters.AddWithValue("@senha", tbSenha.Text);

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

        private void FormCadProf_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

        private void lbVerSenha_Click(object sender, EventArgs e)
        {//lbVerSenha
            if (tbSenha.UseSystemPasswordChar.Equals(false))
                tbSenha.UseSystemPasswordChar = true;
            else
                tbSenha.UseSystemPasswordChar = false;
        }
    }
}
