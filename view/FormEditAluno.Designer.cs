
namespace projetofinal
{
    partial class FormEditAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAluno));
            this.dgalunos = new System.Windows.Forms.DataGridView();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.lbbusca = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbAlunosCadastrados = new System.Windows.Forms.Label();
            this.lbcm = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbkg = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.lbaltura = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbidade = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.Button();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgalunos
            // 
            this.dgalunos.AllowUserToAddRows = false;
            this.dgalunos.AllowUserToDeleteRows = false;
            this.dgalunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgalunos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgalunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgalunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgalunos.Location = new System.Drawing.Point(446, 143);
            this.dgalunos.MultiSelect = false;
            this.dgalunos.Name = "dgalunos";
            this.dgalunos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgalunos.RowHeadersVisible = false;
            this.dgalunos.RowHeadersWidth = 51;
            this.dgalunos.RowTemplate.Height = 29;
            this.dgalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalunos.Size = new System.Drawing.Size(664, 363);
            this.dgalunos.TabIndex = 13;
            this.dgalunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalunos_CellClick);
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBusca.Location = new System.Drawing.Point(514, 59);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(552, 29);
            this.tbBusca.TabIndex = 12;
            this.tbBusca.TextChanged += new System.EventHandler(this.tbBusca_TextChanged);
            // 
            // lbbusca
            // 
            this.lbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbusca.AutoSize = true;
            this.lbbusca.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbbusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbbusca.Location = new System.Drawing.Point(446, 60);
            this.lbbusca.Name = "lbbusca";
            this.lbbusca.Size = new System.Drawing.Size(57, 25);
            this.lbbusca.TabIndex = 5;
            this.lbbusca.Text = "Busca";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCancelar.Location = new System.Drawing.Point(249, 437);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(141, 30);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditar.BackColor = System.Drawing.Color.GhostWhite;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(80, 437);
            this.btEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(78, 69);
            this.btEditar.TabIndex = 8;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExcluir.BackColor = System.Drawing.Color.GhostWhite;
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(165, 437);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(78, 69);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(249, 475);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(141, 30);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbAlunosCadastrados
            // 
            this.lbAlunosCadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAlunosCadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAlunosCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbAlunosCadastrados.Location = new System.Drawing.Point(446, 95);
            this.lbAlunosCadastrados.Name = "lbAlunosCadastrados";
            this.lbAlunosCadastrados.Size = new System.Drawing.Size(664, 45);
            this.lbAlunosCadastrados.TabIndex = 25;
            this.lbAlunosCadastrados.Text = "ALUNOS CADASTRADOS";
            this.lbAlunosCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcm
            // 
            this.lbcm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcm.AutoSize = true;
            this.lbcm.Location = new System.Drawing.Point(359, 321);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(31, 21);
            this.lbcm.TabIndex = 43;
            this.lbcm.Text = "cm";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCelular.BackColor = System.Drawing.Color.White;
            this.mtbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbCelular.Location = new System.Drawing.Point(248, 201);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(142, 29);
            this.mtbCelular.TabIndex = 2;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lbkg
            // 
            this.lbkg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbkg.AutoSize = true;
            this.lbkg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbkg.Location = new System.Drawing.Point(243, 319);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(27, 21);
            this.lbkg.TabIndex = 42;
            this.lbkg.Text = "kg";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCpf.BackColor = System.Drawing.Color.White;
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCpf.Enabled = false;
            this.mtbCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbCpf.Location = new System.Drawing.Point(80, 201);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(135, 29);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbAltura
            // 
            this.tbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAltura.BackColor = System.Drawing.Color.White;
            this.tbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAltura.Location = new System.Drawing.Point(287, 317);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAltura.MaxLength = 3;
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(68, 29);
            this.tbAltura.TabIndex = 6;
            this.tbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(80, 259);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(310, 29);
            this.tbEmail.TabIndex = 3;
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPeso.BackColor = System.Drawing.Color.White;
            this.tbPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPeso.Location = new System.Drawing.Point(171, 317);
            this.tbPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPeso.MaxLength = 3;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(68, 29);
            this.tbPeso.TabIndex = 5;
            this.tbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbaltura
            // 
            this.lbaltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbaltura.AutoSize = true;
            this.lbaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbaltura.Location = new System.Drawing.Point(287, 292);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(52, 21);
            this.lbaltura.TabIndex = 41;
            this.lbaltura.Text = "Altura";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEndereco.BackColor = System.Drawing.Color.White;
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEndereco.Location = new System.Drawing.Point(80, 375);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEndereco.MaxLength = 100;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(310, 29);
            this.tbEndereco.TabIndex = 7;
            // 
            // lbpeso
            // 
            this.lbpeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbpeso.AutoSize = true;
            this.lbpeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbpeso.Location = new System.Drawing.Point(171, 292);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(42, 21);
            this.lbpeso.TabIndex = 40;
            this.lbpeso.Text = "Peso";
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbemail.AutoSize = true;
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbemail.Location = new System.Drawing.Point(80, 234);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(54, 21);
            this.lbemail.TabIndex = 39;
            this.lbemail.Text = "E-mail";
            // 
            // tbIdade
            // 
            this.tbIdade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdade.BackColor = System.Drawing.Color.White;
            this.tbIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIdade.Location = new System.Drawing.Point(80, 317);
            this.tbIdade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIdade.MaxLength = 3;
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(48, 29);
            this.tbIdade.TabIndex = 4;
            this.tbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbcelular
            // 
            this.lbcelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcelular.AutoSize = true;
            this.lbcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbcelular.Location = new System.Drawing.Point(248, 176);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(59, 21);
            this.lbcelular.TabIndex = 38;
            this.lbcelular.Text = "Celular";
            // 
            // lbendereco
            // 
            this.lbendereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbendereco.AutoSize = true;
            this.lbendereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbendereco.Location = new System.Drawing.Point(80, 350);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(74, 21);
            this.lbendereco.TabIndex = 36;
            this.lbendereco.Text = "Endereço";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.Location = new System.Drawing.Point(80, 143);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(310, 29);
            this.tbNome.TabIndex = 0;
            // 
            // lbidade
            // 
            this.lbidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbidade.AutoSize = true;
            this.lbidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbidade.Location = new System.Drawing.Point(80, 292);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(48, 21);
            this.lbidade.TabIndex = 30;
            this.lbidade.Text = "Idade";
            // 
            // lbcpf
            // 
            this.lbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcpf.AutoSize = true;
            this.lbcpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbcpf.Location = new System.Drawing.Point(80, 176);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(37, 21);
            this.lbcpf.TabIndex = 29;
            this.lbcpf.Text = "CPF";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbnome.Location = new System.Drawing.Point(80, 118);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 26;
            this.lbnome.Text = "Nome";
            // 
            // btbuscar
            // 
            this.btbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.FlatAppearance.BorderSize = 0;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btbuscar.Image")));
            this.btbuscar.Location = new System.Drawing.Point(1064, 54);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(46, 38);
            this.btbuscar.TabIndex = 1;
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // lbMatricula
            // 
            this.lbMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMatricula.Location = new System.Drawing.Point(197, 60);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(75, 21);
            this.lbMatricula.TabIndex = 44;
            this.lbMatricula.Text = "Matrícula";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMatricula.BackColor = System.Drawing.Color.White;
            this.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMatricula.Enabled = false;
            this.tbMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMatricula.Location = new System.Drawing.Point(197, 85);
            this.tbMatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatricula.MaxLength = 3;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(75, 29);
            this.tbMatricula.TabIndex = 45;
            this.tbMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormEditAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1183, 565);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.lbcm);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lbaltura);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbidade);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbAlunosCadastrados);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.lbbusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.dgalunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1201, 612);
            this.Name = "FormEditAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgalunos;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label lbbusca;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbAlunosCadastrados;
        private System.Windows.Forms.Label lbcm;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lbaltura;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.TextBox tbMatricula;
    }
}