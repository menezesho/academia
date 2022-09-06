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
    public partial class Form2 : Form
    {
        FormAjuda Fajuda = new FormAjuda();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = "INSERT INTO Alunos VALUES (@matricula, @nome, @cpf, @idade, @endereco, @celular, @email, @peso, @altura, @aula)";
            try
            {
                conexao.Open();
                for (int i = 0; i < dgpessoas.Rows.Count - 1; i++)
                {
                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@matricula", dgpessoas.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@nome", dgpessoas.Rows[i].Cells[1].Value);
                    comando.Parameters.AddWithValue("@cpf", dgpessoas.Rows[i].Cells[2].Value);
                    comando.Parameters.AddWithValue("@idade", dgpessoas.Rows[i].Cells[3].Value.ToString());
                    comando.Parameters.AddWithValue("@endereco", dgpessoas.Rows[i].Cells[4].Value);
                    comando.Parameters.AddWithValue("@celular", dgpessoas.Rows[i].Cells[5].Value);
                    comando.Parameters.AddWithValue("@email", dgpessoas.Rows[i].Cells[6].Value);
                    comando.Parameters.AddWithValue("@peso", dgpessoas.Rows[i].Cells[7].Value.ToString());
                    comando.Parameters.AddWithValue("@altura", dgpessoas.Rows[i].Cells[8].Value.ToString());
                    comando.Parameters.AddWithValue("@aula", dgpessoas.Rows[i].Cells[9].Value);

                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados upados com sucesso!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            dgpessoas.Rows.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            
        }

        public void insereDados(int matricula, string nome, string cpf, int idade, string endereco, string celular, string email, float peso, float altura, string aula)
        {
            DataGridViewRow linha = (DataGridViewRow)dgpessoas.Rows[0].Clone();
            linha.Cells[0].Value = matricula;
            linha.Cells[1].Value = nome;
            linha.Cells[2].Value = cpf;
            linha.Cells[3].Value = idade;
            linha.Cells[4].Value = endereco;
            linha.Cells[5].Value = celular;
            linha.Cells[6].Value = email;
            linha.Cells[7].Value = peso;
            linha.Cells[8].Value = altura;
            linha.Cells[9].Value = aula;
            dgpessoas.Rows.Add(linha);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }
    }
}
