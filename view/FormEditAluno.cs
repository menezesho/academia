using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormEditAluno : Form
    {
        Conexao conec = new Conexao();

        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            dgalunos.DataSource = alunoDAO.listarAlunos();

            dgalunos.Columns["Matri"].Width = 50;
            dgalunos.Columns["Nome"].Width = 180;
            dgalunos.Columns["CPF"].Width = 110;
            dgalunos.Columns["Idade"].Width = 50;
            dgalunos.Columns["Endereço"].Width = 180;
            dgalunos.Columns["Celular"].Width = 110;
            dgalunos.Columns["E-mail"].Width = 220;
            dgalunos.Columns["Peso(kg)"].Width = 70;
            dgalunos.Columns["Altura(cm)"].Width = 80;

            tbMatricula.Clear();
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbPeso.Clear();
            tbAltura.Clear();
            tbMatricula.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            tbBusca.Clear();
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbMatricula.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            tbEndereco.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            tbPeso.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbAltura.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();

            tbMatricula.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {//busca automática
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT matricula AS Matrícula, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)'
                    FROM aluno WHERE nome LIKE @nome ORDER BY nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", "%" + tbBusca.Text + "%");

                conexao.Open();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet resultado = new DataSet();
                da.Fill(resultado);
                dgalunos.DataSource = resultado.Tables[0];
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {//btEditar
            if (tbMatricula.Text != "")
            {
                tbNome.Enabled = true;
                tbIdade.Enabled = true;
                tbEndereco.Enabled = true;
                mtbCelular.Enabled = true;
                tbEmail.Enabled = true;
                tbPeso.Enabled = true;
                tbAltura.Enabled = true;
                btEditar.Enabled = false;
                btCancelar.Enabled = true;
                btSalvar.Enabled = true;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            tbMatricula.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            tbEndereco.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            tbMatricula.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            tbEndereco.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            tbPeso.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbAltura.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (tbMatricula.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM aluno WHERE matricula=@matricula";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@matricula", tbMatricula.Text);

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

                    AlunoDAO alunoDAO = new AlunoDAO();
                    dgalunos.DataSource = alunoDAO.listarAlunos();

                    tbMatricula.Clear();
                    tbNome.Clear();
                    mtbCpf.Clear();
                    tbIdade.Clear();
                    tbEndereco.Clear();
                    mtbCelular.Clear();
                    tbEmail.Clear();
                    tbPeso.Clear();
                    tbAltura.Clear();
                    tbMatricula.Enabled = false;
                    tbNome.Enabled = false;
                    tbIdade.Enabled = false;
                    tbEndereco.Enabled = false;
                    mtbCelular.Enabled = false;
                    tbEmail.Enabled = false;
                    tbPeso.Enabled = false;
                    tbAltura.Enabled = false;
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
                            string sqlUpdate = @"UPDATE aluno SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, peso=@peso, altura=@altura WHERE matricula=@matricula";
                            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                            comandoUpdate.Parameters.AddWithValue("@matricula", tbMatricula.Text);

                            comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
                            comandoUpdate.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                            comandoUpdate.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                            comandoUpdate.Parameters.AddWithValue("@endereco", tbEndereco.Text);
                            comandoUpdate.Parameters.AddWithValue("@celular", mtbCelular.Text);
                            comandoUpdate.Parameters.AddWithValue("@email", tbEmail.Text);
                            comandoUpdate.Parameters.AddWithValue("@peso", tbPeso.Text);
                            comandoUpdate.Parameters.AddWithValue("@altura", tbAltura.Text);

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

                        AlunoDAO alunoDAO = new AlunoDAO();
                        dgalunos.DataSource = alunoDAO.listarAlunos();

                        tbMatricula.Clear();
                        tbNome.Clear();
                        mtbCpf.Clear();
                        tbIdade.Clear();
                        tbEndereco.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        tbPeso.Clear();
                        tbAltura.Clear();
                        tbMatricula.Enabled = false;
                        tbNome.Enabled = false;
                        tbIdade.Enabled = false;
                        tbEndereco.Enabled = false;
                        mtbCelular.Enabled = false;
                        tbEmail.Enabled = false;
                        tbPeso.Enabled = false;
                        tbAltura.Enabled = false;
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

        private void FormListAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
