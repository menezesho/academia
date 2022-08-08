using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form3 : Form
    {
        int p = 0;
        Professor[] professores = new Professor[20];
        Form4 F4 = new Form4();
        FormAjuda Fajuda = new FormAjuda();

        public Form3()
        {
            InitializeComponent();
            F4 = FormPrincipal.F4;
        }
        public Form3(Form4 f)
        {
            InitializeComponent();
            F4 = f;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cbaula.SelectedIndex = 0;
            int ncracha = p + 1;
            tbcracha.Text = ncracha.ToString();
        }
        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> RETORNAR
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {//se a resposta do retorno for positiva o programa apaga as informações preenchidas e retorna a janela anterior
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
                cbaula.SelectedIndex = 0;
                cbaula.Enabled = true;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btsalvar_Click_1(object sender, EventArgs e)
        {//SALVAR | salva os dados inseridos
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || cbaula.Text == "Selecione")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                professores[p] = new Professor(tbnome.Text, mtbcpf.Text, tbendereco.Text, mtbcelular.Text, tbemail.Text, int.Parse(tbidade.Text), cbaula.Text, p + 1);
                p++;
                F4.insereDados2(int.Parse(tbcracha.Text), tbnome.Text, mtbcpf.Text, int.Parse(tbidade.Text), tbendereco.Text, mtbcelular.Text, tbemail.Text, cbaula.Text);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
                cbaula.SelectedIndex = 0;
                tbcracha.Text = (p + 1).ToString();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//LIMPAR | limpa os dados preenchidos dentro do forms
            tbnome.Enabled = true;
            mtbcpf.Enabled = true;
            tbidade.Enabled = true;
            tbendereco.Enabled = true;
            mtbcelular.Enabled = true;
            tbemail.Enabled = true;
            cbaula.Enabled = true;
            btsalvar.Enabled = true;
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            cbaula.SelectedIndex = 0;
            tbcracha.Text = (p + 1).ToString();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//BUSCAR | percorre os registros cadastrados e busca aquele que corresponde ao cpf procurado
            string cpf = mtbcpf.Text;
            bool achou = false;
            if (mtbcpf.Text == "   .   .   -") //verifica se o cpf não for digitado, imprime erro na tela
                MessageBox.Show("Nenhum CPF foi digitado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else //caso contrário, prossegue com o código
            {
                for (int i = 0; i < p; i++) //percorre os cadastros
                {
                    if (professores[i].cpf == cpf) //caso encontre um cpf já cadastrado, mostra o cadastro na tela
                    {
                        tbcracha.Text = professores[i].cracha.ToString();
                        tbnome.Enabled = false;
                        tbnome.Text = professores[i].nome;
                        mtbcpf.Enabled = false;
                        mtbcpf.Text = professores[i].cpf;
                        tbidade.Enabled = false;
                        tbidade.Text = professores[i].idade.ToString();
                        tbendereco.Enabled = false;
                        tbendereco.Text = professores[i].endereco;
                        mtbcelular.Enabled = false;
                        mtbcelular.Text = professores[i].celular;
                        tbemail.Enabled = false;
                        tbemail.Text = professores[i].email;
                        cbaula.Enabled = false;
                        cbaula.Text = professores[i].aula;
                        btsalvar.Enabled = false;
                        achou = true;
                        MessageBox.Show("Professor localizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!achou) //caso não encontre o cadastro, imprime erro na tela
                    MessageBox.Show("Professor não cadastrado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btretornar_Click(object sender, EventArgs e)
        {//RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
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
                cbaula.SelectedIndex = 0;
                cbaula.Enabled = true;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {//ESC PARA RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
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
                    cbaula.SelectedIndex = 0;
                    cbaula.Enabled = true;
                    tabControl1.SelectedTab = tabPage1;
                }
            }
        }
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> AJUDA
            Fajuda.ShowDialog();
        }

        private void tbcracha_TextChanged(object sender, EventArgs e)
        {
            //recebe o cracha
        }

        private void tbnome_TextChanged(object sender, EventArgs e)
        {
            //recebe o nome
        }

        private void mtbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //recebe o cpf
        }

        private void tbidade_TextChanged(object sender, EventArgs e)
        {
            //recebe idade
        }

        private void tbendereco_TextChanged(object sender, EventArgs e)
        {
            //recebe endereço
        }

        private void mtbcelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //recebe o numero do celular
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            //recebe o email
        }

        private void cbaula_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recebe a aula que o professor vai dar
        }
    }
}
