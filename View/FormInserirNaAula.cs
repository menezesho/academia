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

namespace academia
{
    public partial class FormInserirNaAula : Form
    {
        Conexao conec = new Conexao();

        public FormInserirNaAula()
        {
            InitializeComponent();
        }

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            rbAluno.Checked = true;

            AulaDAO aulaDAO = new AulaDAO();
            cbAula.DataSource = aulaDAO.listarAulas();
            cbAula.DisplayMember = "Nome";
            cbAula.ValueMember = "id";

            if (rbAluno.Checked)
            {
                AlunoDAO alunoDAO = new AlunoDAO();
                cbNome.DataSource = alunoDAO.listarAlunos();
                cbNome.ValueMember = "matricula";
                //cbNome.DisplayMember = "Nome";
                
            }
            else
            {
                ProfessorDAO professorDAO = new ProfessorDAO();
                cbNome.DataSource = professorDAO.listarProfs();
                cbNome.ValueMember = "cracha";
                //cbNome.DisplayMember = "Nome";
                
            }

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();
        }

        private void rbProfessor_CheckedChanged(object sender, EventArgs e)
        {//Professor check

        }

        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {//Aluno check

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cbNome.SelectedIndex = 0;
                mtbCpf.Clear();
                mtbCelular.Clear();
                cbAula.SelectedIndex = 0;
                mtbData.Clear();
                tbHora.Clear();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {//brInserir
            if (cbNome.Text == "Selecione" || cbAula.Text == "Selecione")
                MessageBox.Show("Preencha os campos vazios!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                
                
            }
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed NOME
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = "";
                if (rbAluno.Checked)
                    sql = @"SELECT * FROM aluno WHERE matricula=@id";
                else
                    sql = @"SELECT * FROM professor WHERE cracha=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", cbNome.ValueMember);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    mtbCpf.Text = dados["cpf"].ToString();
                    mtbCelular.Text = dados["celular"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT * FROM aula WHERE nome=@nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", cbAula.Text);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    mtbData.Text = dados["dia"].ToString();
                    tbHora.Text = dados["hora"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
