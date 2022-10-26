
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCracha = new System.Windows.Forms.TextBox();
            this.lbCracha = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbidade = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbProfessoresCadastrados = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.lbbusca = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.dgprofs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCracha
            // 
            this.tbCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCracha.BackColor = System.Drawing.Color.White;
            this.tbCracha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCracha.Enabled = false;
            this.tbCracha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCracha.Location = new System.Drawing.Point(205, 85);
            this.tbCracha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCracha.MaxLength = 3;
            this.tbCracha.Name = "tbCracha";
            this.tbCracha.Size = new System.Drawing.Size(58, 29);
            this.tbCracha.TabIndex = 74;
            this.tbCracha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCracha
            // 
            this.lbCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCracha.AutoSize = true;
            this.lbCracha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCracha.Location = new System.Drawing.Point(205, 60);
            this.lbCracha.Name = "lbCracha";
            this.lbCracha.Size = new System.Drawing.Size(58, 21);
            this.lbCracha.TabIndex = 73;
            this.lbCracha.Text = "Crachá";
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
            // tbSenha
            // 
            this.tbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSenha.BackColor = System.Drawing.Color.White;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenha.Location = new System.Drawing.Point(249, 375);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSenha.MaxLength = 30;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(141, 29);
            this.tbSenha.TabIndex = 7;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSenha.UseSystemPasswordChar = true;
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
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsuario.BackColor = System.Drawing.Color.White;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.Location = new System.Drawing.Point(80, 375);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsuario.MaxLength = 20;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(141, 29);
            this.tbUsuario.TabIndex = 6;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenha.AutoSize = true;
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSenha.Location = new System.Drawing.Point(291, 350);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(53, 21);
            this.lbSenha.TabIndex = 70;
            this.lbSenha.Text = "Senha";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEndereco.BackColor = System.Drawing.Color.White;
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEndereco.Location = new System.Drawing.Point(162, 317);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEndereco.MaxLength = 100;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(228, 29);
            this.tbEndereco.TabIndex = 5;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUsuario.Location = new System.Drawing.Point(80, 350);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 21);
            this.lbUsuario.TabIndex = 69;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbemail.AutoSize = true;
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbemail.Location = new System.Drawing.Point(80, 234);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(54, 21);
            this.lbemail.TabIndex = 68;
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
            this.lbcelular.TabIndex = 67;
            this.lbcelular.Text = "Celular";
            // 
            // lbendereco
            // 
            this.lbendereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbendereco.AutoSize = true;
            this.lbendereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbendereco.Location = new System.Drawing.Point(162, 292);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(74, 21);
            this.lbendereco.TabIndex = 65;
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
            this.lbidade.TabIndex = 59;
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
            this.lbcpf.TabIndex = 58;
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
            this.lbnome.TabIndex = 55;
            this.lbnome.Text = "Nome";
            // 
            // lbProfessoresCadastrados
            // 
            this.lbProfessoresCadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProfessoresCadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProfessoresCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbProfessoresCadastrados.Location = new System.Drawing.Point(446, 95);
            this.lbProfessoresCadastrados.Name = "lbProfessoresCadastrados";
            this.lbProfessoresCadastrados.Size = new System.Drawing.Size(664, 45);
            this.lbProfessoresCadastrados.TabIndex = 54;
            this.lbProfessoresCadastrados.Text = "PROFESSORES CADASTRADOS";
            this.lbProfessoresCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btbuscar.TabIndex = 47;
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.tbBusca_TextChanged);
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
            this.lbbusca.TabIndex = 48;
            this.lbbusca.Text = "Busca";
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBusca.Location = new System.Drawing.Point(514, 59);
            this.tbBusca.MaxLength = 100;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(552, 29);
            this.tbBusca.TabIndex = 12;
            this.tbBusca.TextChanged += new System.EventHandler(this.tbBusca_TextChanged);
            // 
            // dgprofs
            // 
            this.dgprofs.AllowUserToAddRows = false;
            this.dgprofs.AllowUserToDeleteRows = false;
            this.dgprofs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgprofs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgprofs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprofs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgprofs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgprofs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgprofs.Location = new System.Drawing.Point(446, 143);
            this.dgprofs.MultiSelect = false;
            this.dgprofs.Name = "dgprofs";
            this.dgprofs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprofs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgprofs.RowHeadersVisible = false;
            this.dgprofs.RowHeadersWidth = 51;
            this.dgprofs.RowTemplate.Height = 29;
            this.dgprofs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgprofs.Size = new System.Drawing.Size(664, 363);
            this.dgprofs.TabIndex = 13;
            this.dgprofs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprofs_CellClick_1);
            // 
            // FormEditProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1183, 565);
            this.Controls.Add(this.tbCracha);
            this.Controls.Add(this.lbCracha);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbidade);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbProfessoresCadastrados);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.lbbusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.dgprofs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1201, 612);
            this.Name = "FormEditProf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditProf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEditProf_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgprofs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCracha;
        private System.Windows.Forms.Label lbCracha;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbProfessoresCadastrados;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label lbbusca;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.DataGridView dgprofs;
    }
}