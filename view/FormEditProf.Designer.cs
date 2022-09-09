
namespace projetofinal
{
    partial class FormEditProf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProf));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btexcluir = new System.Windows.Forms.Button();
            this.lbeditarcadastro = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbcracha = new System.Windows.Forms.TextBox();
            this.lbcracha = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.tbidade = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbidade = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbendereco = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbalunoscadastrados = new System.Windows.Forms.Label();
            this.dgprofs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbbusca = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.bteditar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Lavender;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.Location = new System.Drawing.Point(124, 374);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(69, 66);
            this.btexcluir.TabIndex = 12;
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // lbeditarcadastro
            // 
            this.lbeditarcadastro.AutoSize = true;
            this.lbeditarcadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbeditarcadastro.Location = new System.Drawing.Point(165, 53);
            this.lbeditarcadastro.Name = "lbeditarcadastro";
            this.lbeditarcadastro.Size = new System.Drawing.Size(214, 31);
            this.lbeditarcadastro.TabIndex = 31;
            this.lbeditarcadastro.Text = "EDITAR CADASTRO";
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsalvar.Location = new System.Drawing.Point(199, 411);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(296, 29);
            this.btsalvar.TabIndex = 14;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(45, 153);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 213);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.tbcracha);
            this.tabPage1.Controls.Add(this.lbcracha);
            this.tabPage1.Controls.Add(this.mtbcpf);
            this.tabPage1.Controls.Add(this.tbidade);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbidade);
            this.tabPage1.Controls.Add(this.lbcpf);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(446, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            // 
            // tbcracha
            // 
            this.tbcracha.Location = new System.Drawing.Point(240, 24);
            this.tbcracha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcracha.Name = "tbcracha";
            this.tbcracha.Size = new System.Drawing.Size(63, 27);
            this.tbcracha.TabIndex = 3;
            this.tbcracha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbcracha
            // 
            this.lbcracha.AutoSize = true;
            this.lbcracha.Location = new System.Drawing.Point(161, 27);
            this.lbcracha.Name = "lbcracha";
            this.lbcracha.Size = new System.Drawing.Size(75, 20);
            this.lbcracha.TabIndex = 4;
            this.lbcracha.Text = "N° Crachá";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(116, 95);
            this.mtbcpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(129, 27);
            this.mtbcpf.TabIndex = 5;
            this.mtbcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbidade
            // 
            this.tbidade.Location = new System.Drawing.Point(116, 130);
            this.tbidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbidade.Name = "tbidade";
            this.tbidade.Size = new System.Drawing.Size(53, 27);
            this.tbidade.TabIndex = 6;
            this.tbidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(116, 60);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(269, 27);
            this.tbnome.TabIndex = 4;
            // 
            // lbidade
            // 
            this.lbidade.AutoSize = true;
            this.lbidade.Location = new System.Drawing.Point(63, 133);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(47, 20);
            this.lbidade.TabIndex = 2;
            this.lbidade.Text = "Idade";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(63, 98);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(33, 20);
            this.lbcpf.TabIndex = 1;
            this.lbcpf.Text = "CPF";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(63, 63);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(50, 20);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.mtbcelular);
            this.tabPage2.Controls.Add(this.tbemail);
            this.tabPage2.Controls.Add(this.tbendereco);
            this.tabPage2.Controls.Add(this.lbemail);
            this.tabPage2.Controls.Add(this.lbcelular);
            this.tabPage2.Controls.Add(this.lbendereco);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(446, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            // 
            // mtbcelular
            // 
            this.mtbcelular.Location = new System.Drawing.Point(126, 78);
            this.mtbcelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbcelular.Mask = "(99) 00000-0000";
            this.mtbcelular.Name = "mtbcelular";
            this.mtbcelular.Size = new System.Drawing.Size(127, 27);
            this.mtbcelular.TabIndex = 8;
            this.mtbcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(126, 113);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(273, 27);
            this.tbemail.TabIndex = 9;
            // 
            // tbendereco
            // 
            this.tbendereco.Location = new System.Drawing.Point(126, 43);
            this.tbendereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbendereco.Name = "tbendereco";
            this.tbendereco.Size = new System.Drawing.Size(273, 27);
            this.tbendereco.TabIndex = 7;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(52, 116);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(52, 20);
            this.lbemail.TabIndex = 9;
            this.lbemail.Text = "E-mail";
            // 
            // lbcelular
            // 
            this.lbcelular.AutoSize = true;
            this.lbcelular.Location = new System.Drawing.Point(52, 80);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(55, 20);
            this.lbcelular.TabIndex = 8;
            this.lbcelular.Text = "Celular";
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Location = new System.Drawing.Point(52, 46);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(71, 20);
            this.lbendereco.TabIndex = 7;
            this.lbendereco.Text = "Endereço";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.tbusuario);
            this.tabPage3.Controls.Add(this.lbusuario);
            this.tabPage3.Controls.Add(this.tbsenha);
            this.tabPage3.Controls.Add(this.lbsenha);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(446, 180);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Login";
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(158, 96);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(189, 27);
            this.tbsenha.TabIndex = 10;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Location = new System.Drawing.Point(95, 99);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(49, 20);
            this.lbsenha.TabIndex = 21;
            this.lbsenha.Text = "Senha";
            // 
            // lbalunoscadastrados
            // 
            this.lbalunoscadastrados.AutoSize = true;
            this.lbalunoscadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbalunoscadastrados.Location = new System.Drawing.Point(691, 53);
            this.lbalunoscadastrados.Name = "lbalunoscadastrados";
            this.lbalunoscadastrados.Size = new System.Drawing.Size(333, 31);
            this.lbalunoscadastrados.TabIndex = 26;
            this.lbalunoscadastrados.Text = "PROFESSORES CADASTRADOS";
            // 
            // dgprofs
            // 
            this.dgprofs.AllowUserToAddRows = false;
            this.dgprofs.AllowUserToDeleteRows = false;
            this.dgprofs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgprofs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprofs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgprofs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgprofs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgprofs.Location = new System.Drawing.Point(531, 102);
            this.dgprofs.Name = "dgprofs";
            this.dgprofs.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprofs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgprofs.RowHeadersWidth = 51;
            this.dgprofs.RowTemplate.Height = 29;
            this.dgprofs.Size = new System.Drawing.Size(590, 338);
            this.dgprofs.TabIndex = 14;
            this.dgprofs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprofs_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetofinal.Properties.Resources.logo_academia_t;
            this.pictureBox1.Location = new System.Drawing.Point(624, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retornarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click);
            // 
            // lbbusca
            // 
            this.lbbusca.AutoSize = true;
            this.lbbusca.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbbusca.Location = new System.Drawing.Point(52, 103);
            this.lbbusca.Name = "lbbusca";
            this.lbbusca.Size = new System.Drawing.Size(57, 25);
            this.lbbusca.TabIndex = 35;
            this.lbbusca.Text = "Busca";
            // 
            // tbbusca
            // 
            this.tbbusca.Location = new System.Drawing.Point(112, 102);
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(351, 27);
            this.tbbusca.TabIndex = 0;
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.Lavender;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(49, 374);
            this.bteditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(69, 66);
            this.bteditar.TabIndex = 11;
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Lavender;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.Location = new System.Drawing.Point(199, 374);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(296, 29);
            this.btcancelar.TabIndex = 13;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.FlatAppearance.BorderSize = 0;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btbuscar.Image")));
            this.btbuscar.Location = new System.Drawing.Point(458, 98);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(41, 36);
            this.btbuscar.TabIndex = 1;
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(158, 61);
            this.tbusuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(189, 27);
            this.tbusuario.TabIndex = 22;
            this.tbusuario.UseSystemPasswordChar = true;
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(95, 64);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(59, 20);
            this.lbusuario.TabIndex = 23;
            this.lbusuario.Text = "Usuário";
            // 
            // FormEditProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 480);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.lbbusca);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.lbeditarcadastro);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbalunoscadastrados);
            this.Controls.Add(this.dgprofs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores cadastrados";
            this.Load += new System.EventHandler(this.FormEditProf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEditProf_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Label lbeditarcadastro;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbcracha;
        private System.Windows.Forms.Label lbcracha;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox tbidade;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mtbcelular;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbendereco;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.Label lbalunoscadastrados;
        private System.Windows.Forms.DataGridView dgprofs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retornarToolStripMenuItem;
        private System.Windows.Forms.Label lbbusca;
        private System.Windows.Forms.TextBox tbbusca;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.Label lbusuario;
    }
}