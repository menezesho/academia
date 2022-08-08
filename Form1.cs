using System;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form1 : Form
    {
        int a = 0;
        Aluno[] alunos = new Aluno[20];
        Form2 F2 = new Form2();
        FormAjuda Fajuda = new FormAjuda();
        public Form1()
        {
            InitializeComponent();
            F2 = FormPrincipal.F2;
        }
        public Form1(Form2 f)
        {
            InitializeComponent();
            F2 = f;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbaula.SelectedIndex = 0;
            int nmatricula = a + 1;
            tbmatricula.Text = nmatricula.ToString();

        }
        private void btsalvar_Click(object sender, EventArgs e)
        {//SALVAR
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || tbpeso.Text == "" || tbaltura.Text == "" || cbaula.Text == "Selecione")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                alunos[a] = new Aluno(tbnome.Text, mtbcpf.Text, tbendereco.Text, mtbcelular.Text, tbemail.Text, int.Parse(tbidade.Text), cbaula.Text, float.Parse(tbpeso.Text), float.Parse(tbaltura.Text), a + 1);
                a++;
                F2.insereDados(int.Parse(tbmatricula.Text), tbnome.Text, mtbcpf.Text, int.Parse(tbidade.Text), tbendereco.Text, mtbcelular.Text, tbemail.Text, float.Parse(tbpeso.Text), float.Parse(tbaltura.Text), cbaula.Text);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnome.Clear();
                mtbcpf.Clear();
                tbidade.Clear();
                tbendereco.Clear();
                mtbcelular.Clear();
                tbemail.Clear();
                tbpeso.Clear();
                tbaltura.Clear();
                cbaula.SelectedIndex = 0;
                tabControl1.SelectedTab = tabPage1;
                tbmatricula.Text = (a + 1).ToString();
            }
        }
        private void btlimpar_Click(object sender, EventArgs e)
        {//LIMPAR
            tbnome.Enabled = true;
            mtbcpf.Enabled = true;
            tbidade.Enabled = true;
            tbendereco.Enabled = true;
            mtbcelular.Enabled = true;
            tbemail.Enabled = true;
            tbpeso.Enabled = true;
            tbaltura.Enabled = true;
            cbaula.Enabled = true;
            btsalvar.Enabled = true;
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbpeso.Clear();
            tbaltura.Clear();
            cbaula.SelectedIndex = 0;
            tbmatricula.Text = (a + 1).ToString();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btsair_Click(object sender, EventArgs e)
        {//SAIR
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
                tbpeso.Clear();
                tbpeso.Enabled = true;
                tbaltura.Clear();
                tbaltura.Enabled = true;
                cbaula.SelectedIndex = 0;
                cbaula.Enabled = true;
                tabControl1.SelectedTab = tabPage1;
            }
        }
        private void btbuscar_Click(object sender, EventArgs e)
        {//BUSCAR
            string cpf = mtbcpf.Text;
            bool achou = false;
            if (mtbcpf.Text == "   .   .   -") //verifica se o cpf não for digitado, imprime erro na tela
                MessageBox.Show("Nenhum CPF foi digitado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else //caso contrário, prossegue com o código
            {
                for (int i = 0; i < a; i++) //percorre os cadastros
                {
                    if (alunos[i].cpf == cpf) //caso encontre um cpf já cadastrado, mostra o cadastro na tela
                    {
                        tbmatricula.Text = alunos[i].matricula.ToString();
                        tbnome.Enabled = false;
                        tbnome.Text = alunos[i].nome;
                        mtbcpf.Enabled = false;
                        mtbcpf.Text = alunos[i].cpf;
                        tbidade.Enabled = false;
                        tbidade.Text = alunos[i].idade.ToString();
                        tbendereco.Enabled = false;
                        tbendereco.Text = alunos[i].endereco;
                        mtbcelular.Enabled = false;
                        mtbcelular.Text = alunos[i].celular;
                        tbemail.Enabled = false;
                        tbemail.Text = alunos[i].email;
                        tbpeso.Enabled = false;
                        tbpeso.Text = alunos[i].peso.ToString();
                        tbaltura.Enabled = false;
                        tbaltura.Text = alunos[i].altura.ToString();
                        cbaula.Enabled = false;
                        cbaula.Text = alunos[i].aula;
                        btsalvar.Enabled = false;
                        achou = true;
                        MessageBox.Show("Aluno localizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!achou) //caso não encontre o cadastro, imprime erro na tela
                    MessageBox.Show("Aluno não cadastrado!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//STRIP >> RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
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
                tbpeso.Clear();
                tbpeso.Enabled = true;
                tbaltura.Clear();
                tbaltura.Enabled = true;
                cbaula.SelectedIndex = 0;
                cbaula.Enabled = true;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//ESC PARA RETORNAR | sai do forms e apaga os dados que antes foram digitados da tela
            if (e.KeyValue.Equals(27))
            {
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
                    tbpeso.Clear();
                    tbpeso.Enabled = true;
                    tbaltura.Clear();
                    tbaltura.Enabled = true;
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
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void cbaula_SelectedIndexChanged(object sender, EventArgs e)
        {
        //especifica a aula que será matriculado o aluno
        }
        private void tbpeso_TextChanged(object sender, EventArgs e)
        {
        //recebe peso
        }
        private void tbaltura_TextChanged(object sender, EventArgs e)
        {
            //recebe altura
        }
        private void tbendereco_TextChanged(object sender, EventArgs e)
        {
        //recebe o endereço do aluno
        }
        private void tbmatricula_TextChanged(object sender, EventArgs e)
        {
        //recebe o numero da matrícula do aluno
        }
        private void mtbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        //recebe o cpf do aluno cadastrado
        }
    }
}
