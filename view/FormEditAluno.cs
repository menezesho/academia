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
        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {//load
            Funcoes funcoes = new Funcoes();
            dgalunos.DataSource = funcoes.listarAlunos();

            tbmatricula.Clear();
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            tbpeso.Clear();
            tbaltura.Clear();
            tbmatricula.Enabled = false;
            tbnome.Enabled = false;
            mtbcpf.Enabled = false;
            tbidade.Enabled = false;
            tbendereco.Enabled = false;
            mtbcelular.Enabled = false;
            tbemail.Enabled = false;
            tbsenha.Enabled = false;
            tbpeso.Enabled = false;
            tbaltura.Enabled = false;
            bteditar.Enabled = true;
            bteditar.Text = "EDITAR";
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;
            btbuscar.Enabled = true;
            tbbusca.Clear();
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbmatricula.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbcpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            tbidade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            tbendereco.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            mtbcelular.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            tbemail.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            tbsenha.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbpeso.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
            tbaltura.Text = dgalunos.CurrentRow.Cells[9].Value.ToString();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//btbuscar
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT matricula AS Matrícula, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', senha AS Senha, peso AS 'Peso(kg)', altura AS 'Altura(cm)' FROM aluno WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgalunos.DataSource = tabela.Tables[0];
            conexao.Close();
        }

        private void bteditar_Click_1(object sender, EventArgs e)
        {//bteditar
            if (tbmatricula.Text != "")
            {
                tbmatricula.Enabled = true;
                tbnome.Enabled = true;
                mtbcpf.Enabled = true;
                tbidade.Enabled = true;
                tbendereco.Enabled = true;
                mtbcelular.Enabled = true;
                tbemail.Enabled = true;
                tbsenha.Enabled = true;
                tbpeso.Enabled = true;
                tbaltura.Enabled = true;
                bteditar.Enabled = false;
                bteditar.Text = "EDITANDO...";
                btcancelar.Enabled = true;
                btsalvar.Enabled = true;
                btbuscar.Enabled = false;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btcancelar_Click_1(object sender, EventArgs e)
        {//btcancelar
            tbmatricula.Clear();
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            tbpeso.Clear();
            tbaltura.Clear();
            tbmatricula.Enabled = false;
            tbnome.Enabled = false;
            mtbcpf.Enabled = false;
            tbidade.Enabled = false;
            tbendereco.Enabled = false;
            mtbcelular.Enabled = false;
            tbemail.Enabled = false;
            tbsenha.Enabled = false;
            tbpeso.Enabled = false;
            tbaltura.Enabled = false;
            bteditar.Enabled = true;
            bteditar.Text = "EDITAR";
            btsalvar.Enabled = false;
            btcancelar.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
            btbuscar.Enabled = true;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir
            if (tbmatricula.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Aluno alunos = new Aluno();
                    alunos.matricula = int.Parse(tbmatricula.Text);
                    Funcoes funcoes = new Funcoes();
                    funcoes.excluirAluno(alunos);
                    dgalunos.DataSource = funcoes.listarAlunos();

                    tbmatricula.Clear();
                    tbnome.Clear();
                    mtbcpf.Clear();
                    tbidade.Clear();
                    tbendereco.Clear();
                    mtbcelular.Clear();
                    tbemail.Clear();
                    tbsenha.Clear();
                    tbpeso.Clear();
                    tbaltura.Clear();
                    tbmatricula.Enabled = false;
                    tbnome.Enabled = false;
                    mtbcpf.Enabled = false;
                    tbidade.Enabled = false;
                    tbendereco.Enabled = false;
                    mtbcelular.Enabled = false;
                    tbemail.Enabled = false;
                    tbsenha.Enabled = false;
                    tbpeso.Enabled = false;
                    tbaltura.Enabled = false;
                    bteditar.Enabled = true;
                    bteditar.Text = "EDITAR";
                    btsalvar.Enabled = false;
                    btcancelar.Enabled = false;
                    tabControl1.SelectedTab = tabPage1;
                    btbuscar.Enabled = true;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || tbsenha.Text == "" || tbpeso.Text == "" || tbaltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                funcoes.editarAluno(alunos);
                dgalunos.DataSource = funcoes.listarAlunos();

                tbmatricula.Clear();
                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
                tbsenha.Clear();
                tbpeso.Clear();
                tbaltura.Clear();
                tbmatricula.Enabled = false;
                tbnome.Enabled = false;
                mtbcpf.Enabled = false;
                tbidade.Enabled = false;
                tbendereco.Enabled = false;
                mtbcelular.Enabled = false;
                tbemail.Enabled = false;
                tbsenha.Enabled = false;
                tbpeso.Enabled = false;
                tbaltura.Enabled = false;
                bteditar.Enabled = true;
                bteditar.Text = "EDITAR";
                btcancelar.Enabled = false;
                tabControl1.SelectedTab = tabPage1;
                btsalvar.Enabled = false;
                btbuscar.Enabled = true;
            }
        }

        #region Retornar

        private void FormListAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion
    }
}
