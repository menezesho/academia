﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormEditProf : Form
    {
        public FormEditProf()
        {
            InitializeComponent();
        }

        private void FormEditProf_Load(object sender, EventArgs e)
        {//load
            Funcoes funcoes = new Funcoes();
            dgprofs.DataSource = funcoes.listarProfs();

            tbcracha.Clear();
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            tbcracha.Enabled = false;
            tbnome.Enabled = false;
            mtbcpf.Enabled = false;
            tbidade.Enabled = false;
            tbendereco.Enabled = false;
            mtbcelular.Enabled = false;
            tbemail.Enabled = false;
            tbsenha.Enabled = false;
            bteditar.Enabled = true;
            bteditar.Text = "EDITAR";
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;
            btbuscar.Enabled = true;
            tbbusca.Clear();
        }

        private void dgprofs_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbcracha.Text = dgprofs.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgprofs.CurrentRow.Cells[1].Value.ToString();
            mtbcpf.Text = dgprofs.CurrentRow.Cells[2].Value.ToString();
            tbidade.Text = dgprofs.CurrentRow.Cells[3].Value.ToString();
            tbendereco.Text = dgprofs.CurrentRow.Cells[4].Value.ToString();
            mtbcelular.Text = dgprofs.CurrentRow.Cells[5].Value.ToString();
            tbemail.Text = dgprofs.CurrentRow.Cells[6].Value.ToString();
            tbsenha.Text = dgprofs.CurrentRow.Cells[7].Value.ToString();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//btbuscar
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT cracha AS Crachá, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', senha AS Senha FROM professor WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgprofs.DataSource = tabela.Tables[0];
            conexao.Close();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {//bteditar
            if (tbcracha.Text != "")
            {
                tbcracha.Enabled = true;
                tbnome.Enabled = true;
                mtbcpf.Enabled = true;
                tbidade.Enabled = true;
                tbendereco.Enabled = true;
                mtbcelular.Enabled = true;
                tbemail.Enabled = true;
                tbsenha.Enabled = true;
                bteditar.Enabled = false;
                bteditar.Text = "EDITANDO...";
                btcancelar.Enabled = true;
                btsalvar.Enabled = true;
                btbuscar.Enabled = false;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            tbcracha.Clear();
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            tbcracha.Enabled = false;
            tbnome.Enabled = false;
            mtbcpf.Enabled = false;
            tbidade.Enabled = false;
            tbendereco.Enabled = false;
            mtbcelular.Enabled = false;
            tbemail.Enabled = false;
            tbsenha.Enabled = false;
            bteditar.Enabled = true;
            bteditar.Text = "EDITAR";
            btsalvar.Enabled = false;
            btcancelar.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
            btbuscar.Enabled = true;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir
            if (tbcracha.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Professor profs = new Professor();
                    profs.cracha = int.Parse(tbcracha.Text);
                    Funcoes funcoes = new Funcoes();
                    funcoes.excluirProf(profs);
                    dgprofs.DataSource = funcoes.listarProfs();

                    tbcracha.Clear();
                    tbnome.Clear();
                    mtbcpf.Clear();
                    tbidade.Clear();
                    tbendereco.Clear();
                    mtbcelular.Clear();
                    tbemail.Clear();
                    tbsenha.Clear();
                    tbcracha.Enabled = false;
                    tbnome.Enabled = false;
                    mtbcpf.Enabled = false;
                    tbidade.Enabled = false;
                    tbendereco.Enabled = false;
                    mtbcelular.Enabled = false;
                    tbemail.Enabled = false;
                    tbsenha.Enabled = false;
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
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || tbsenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Professor profs = new Professor();

                profs.cracha = int.Parse(tbcracha.Text);
                profs.nome = tbnome.Text;
                profs.cpf = mtbcpf.Text;
                profs.idade = int.Parse(tbidade.Text);
                profs.endereco = tbendereco.Text;
                profs.celular = mtbcelular.Text;
                profs.email = tbemail.Text;
                profs.senha = tbsenha.Text;

                Funcoes funcoes = new Funcoes();
                funcoes.editarProf(profs);
                dgprofs.DataSource = funcoes.listarProfs();

                tbcracha.Clear();
                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
                tbsenha.Clear();
                tbcracha.Enabled = false;
                tbnome.Enabled = false;
                mtbcpf.Enabled = false;
                tbidade.Enabled = false;
                tbendereco.Enabled = false;
                mtbcelular.Enabled = false;
                tbemail.Enabled = false;
                tbsenha.Enabled = false;
                bteditar.Enabled = true;
                bteditar.Text = "EDITAR";
                btcancelar.Enabled = false;
                tabControl1.SelectedTab = tabPage1;
                btsalvar.Enabled = false;
                btbuscar.Enabled = true;
            }
        }

        #region Retornar

        private void FormEditProf_KeyDown(object sender, KeyEventArgs e)
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