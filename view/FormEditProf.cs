using academia.Class;
using academia.DAO;
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
    public partial class FormEditProf : Form
    {
        Conexao conec = new Conexao();

        public FormEditProf()
        {
            InitializeComponent();
        }

        private void FormEditProf_Load(object sender, EventArgs e)
        {
            ProfessorDAO professorDAO = new ProfessorDAO();
            dgprofs.DataSource = professorDAO.listarProfs();

            dgprofs.Columns["Crachá"].Width = 60;
            dgprofs.Columns["Nome"].Width = 180;
            dgprofs.Columns["CPF"].Width = 110;
            dgprofs.Columns["Idade"].Width = 50;
            dgprofs.Columns["Endereço"].Width = 180;
            dgprofs.Columns["Celular"].Width = 110;
            dgprofs.Columns["E-mail"].Width = 220;
            dgprofs.Columns["Usuário"].Width = 180;
            dgprofs.Columns["Senha"].Visible = false;

            tbCracha.Clear();
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbUsuario.Clear();
            tbSenha.Clear();
            tbCracha.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            tbBusca.Clear();
        }

        private void dgprofs_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid           
            tbCracha.Text = dgprofs.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgprofs.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgprofs.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgprofs.CurrentRow.Cells[3].Value.ToString();
            tbEndereco.Text = dgprofs.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgprofs.CurrentRow.Cells[5].Value.ToString();
            tbEmail.Text = dgprofs.CurrentRow.Cells[6].Value.ToString();
            tbUsuario.Text = dgprofs.CurrentRow.Cells[7].Value.ToString();
            tbSenha.Text = dgprofs.CurrentRow.Cells[8].Value.ToString();

            tbCracha.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {//busca automática
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT cracha AS Crachá, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', usuario AS Usuário, senha AS Senha
                    FROM professor WHERE nome LIKE @nome ORDER BY nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", "%" + tbBusca.Text + "%");

                conexao.Open();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet resultado = new DataSet();
                da.Fill(resultado);
                dgprofs.DataSource = resultado.Tables[0];
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {//btEditar
            if (tbCracha.Text != "")
            {
                tbNome.Enabled = true;
                tbIdade.Enabled = true;
                tbEndereco.Enabled = true;
                mtbCelular.Enabled = true;
                tbEmail.Enabled = true;
                tbUsuario.Enabled = true;
                tbSenha.Enabled = true;
                btEditar.Enabled = false;
                btCancelar.Enabled = true;
                btSalvar.Enabled = true;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            tbCracha.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            tbCracha.Text = dgprofs.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgprofs.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgprofs.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgprofs.CurrentRow.Cells[3].Value.ToString();
            tbEndereco.Text = dgprofs.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgprofs.CurrentRow.Cells[5].Value.ToString();
            tbEmail.Text = dgprofs.CurrentRow.Cells[6].Value.ToString();
            tbUsuario.Text = dgprofs.CurrentRow.Cells[7].Value.ToString();
            tbSenha.Text = dgprofs.CurrentRow.Cells[8].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (tbCracha.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM professor WHERE cracha=@cracha";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@cracha", tbCracha.Text);

                        conexao.Open();
                        comandoDelete.CommandText = sqlDelete;
                        comandoDelete.ExecuteNonQuery();
                        conexao.Close();

                        MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ProfessorDAO professorDAO = new ProfessorDAO();
                    dgprofs.DataSource = professorDAO.listarProfs();

                    tbCracha.Clear();
                    tbNome.Clear();
                    mtbCpf.Clear();
                    tbIdade.Clear();
                    tbEndereco.Clear();
                    mtbCelular.Clear();
                    tbEmail.Clear();
                    tbUsuario.Clear();
                    tbSenha.Clear();
                    tbCracha.Enabled = false;
                    tbNome.Enabled = false;
                    tbIdade.Enabled = false;
                    tbEndereco.Enabled = false;
                    mtbCelular.Enabled = false;
                    tbEmail.Enabled = false;
                    tbUsuario.Enabled = false;
                    tbSenha.Enabled = false;
                    btEditar.Enabled = true;
                    btSalvar.Enabled = false;
                    btCancelar.Enabled = false;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbNome.Text == "" || mtbCpf.Text == "___________" || tbIdade.Text == "" || tbEndereco.Text == "" || mtbCelular.Text == "___________" || tbEmail.Text == "" || tbUsuario.Text == "" || tbSenha.Text == "")
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
                            string sqlUpdate = @"UPDATE professor SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, usuario=@usuario, senha=@senha WHERE cracha=@cracha";
                            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                            comandoUpdate.Parameters.AddWithValue("@cracha", tbCracha.Text);

                            comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
                            comandoUpdate.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                            comandoUpdate.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                            comandoUpdate.Parameters.AddWithValue("@endereco", tbEndereco.Text);
                            comandoUpdate.Parameters.AddWithValue("@celular", mtbCelular.Text);
                            comandoUpdate.Parameters.AddWithValue("@email", tbEmail.Text);
                            comandoUpdate.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                            comandoUpdate.Parameters.AddWithValue("@senha", tbSenha.Text);

                            conexao.Open();
                            comandoUpdate.CommandText = sqlUpdate;
                            comandoUpdate.ExecuteNonQuery();
                            conexao.Close();
                            MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ProfessorDAO professorDAO = new ProfessorDAO();
                        dgprofs.DataSource = professorDAO.listarProfs();

                        tbCracha.Clear();
                        tbNome.Clear();
                        mtbCpf.Clear();
                        tbIdade.Clear();
                        tbEndereco.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        tbUsuario.Clear();
                        tbSenha.Clear();
                        tbCracha.Enabled = false;
                        tbNome.Enabled = false;
                        tbIdade.Enabled = false;
                        tbEndereco.Enabled = false;
                        mtbCelular.Enabled = false;
                        tbEmail.Enabled = false;
                        tbUsuario.Enabled = false;
                        tbSenha.Enabled = false;
                        btEditar.Enabled = true;
                        btCancelar.Enabled = false;
                        btSalvar.Enabled = false;
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Insira o CPF corretamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Retornar

        private void FormEditProf_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Todos os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
