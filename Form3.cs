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
                cbaula.SelectedIndex = 0;
                cbaula.Enabled = true;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
                    cbaula.SelectedIndex = 0;
                    cbaula.Enabled = true;
                    tabControl1.SelectedTab = tabPage1;
                }
            }
        }

        private void btlimpar_Click_1(object sender, EventArgs e)
        {//btlimpar
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

        private void btbuscar_Click_1(object sender, EventArgs e)
        {//btbuscar
            string cpf = mtbcpf.Text;
            bool achou = false;
            if (mtbcpf.Text == "   .   .   -") 
                MessageBox.Show("Nenhum CPF foi digitado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < p; i++)
                {
                    if (professores[i].cpf == cpf)
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
                if (!achou)
                    MessageBox.Show("Professor não cadastrado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
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
    }
}
