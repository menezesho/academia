﻿
namespace projetofinal
{
    partial class FormCadAluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAluno));
            this.lbNovoCadastro = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbidade = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.lbaltura = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbkg = new System.Windows.Forms.Label();
            this.lbcm = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNovoCadastro
            // 
            this.lbNovoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNovoCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbNovoCadastro.Location = new System.Drawing.Point(134, 83);
            this.lbNovoCadastro.Name = "lbNovoCadastro";
            this.lbNovoCadastro.Size = new System.Drawing.Size(897, 45);
            this.lbNovoCadastro.TabIndex = 15;
            this.lbNovoCadastro.Text = "NOVO CADASTRO";
            this.lbNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCpf.BackColor = System.Drawing.Color.White;
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbCpf.Location = new System.Drawing.Point(134, 296);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(179, 34);
            this.mtbCpf.TabIndex = 2;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbIdade
            // 
            this.tbIdade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdade.BackColor = System.Drawing.Color.White;
            this.tbIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIdade.Location = new System.Drawing.Point(605, 296);
            this.tbIdade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIdade.MaxLength = 3;
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(72, 34);
            this.tbIdade.TabIndex = 4;
            this.tbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.Location = new System.Drawing.Point(134, 203);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(426, 34);
            this.tbNome.TabIndex = 0;
            // 
            // lbidade
            // 
            this.lbidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbidade.AutoSize = true;
            this.lbidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbidade.Location = new System.Drawing.Point(605, 261);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(72, 31);
            this.lbidade.TabIndex = 2;
            this.lbidade.Text = "Idade";
            // 
            // lbcpf
            // 
            this.lbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbcpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbcpf.Location = new System.Drawing.Point(134, 261);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(55, 31);
            this.lbcpf.TabIndex = 1;
            this.lbcpf.Text = "CPF";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbnome.Location = new System.Drawing.Point(134, 168);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(77, 31);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCelular.BackColor = System.Drawing.Color.White;
            this.mtbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCelular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbCelular.Location = new System.Drawing.Point(381, 296);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(179, 34);
            this.mtbCelular.TabIndex = 3;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(605, 203);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(426, 34);
            this.tbEmail.TabIndex = 1;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEndereco.BackColor = System.Drawing.Color.White;
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEndereco.Location = new System.Drawing.Point(134, 389);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEndereco.MaxLength = 100;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(897, 34);
            this.tbEndereco.TabIndex = 7;
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbemail.Location = new System.Drawing.Point(605, 168);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(82, 31);
            this.lbemail.TabIndex = 9;
            this.lbemail.Text = "E-mail";
            // 
            // lbcelular
            // 
            this.lbcelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcelular.AutoSize = true;
            this.lbcelular.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbcelular.Location = new System.Drawing.Point(381, 261);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(90, 31);
            this.lbcelular.TabIndex = 8;
            this.lbcelular.Text = "Celular";
            // 
            // lbendereco
            // 
            this.lbendereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbendereco.AutoSize = true;
            this.lbendereco.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbendereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbendereco.Location = new System.Drawing.Point(134, 354);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(108, 31);
            this.lbendereco.TabIndex = 7;
            this.lbendereco.Text = "Endereço";
            // 
            // tbAltura
            // 
            this.tbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAltura.BackColor = System.Drawing.Color.White;
            this.tbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAltura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAltura.Location = new System.Drawing.Point(905, 296);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAltura.MaxLength = 3;
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(79, 34);
            this.tbAltura.TabIndex = 6;
            this.tbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPeso.BackColor = System.Drawing.Color.White;
            this.tbPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPeso.Location = new System.Drawing.Point(750, 296);
            this.tbPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPeso.MaxLength = 3;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(79, 34);
            this.tbPeso.TabIndex = 5;
            this.tbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbaltura
            // 
            this.lbaltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbaltura.AutoSize = true;
            this.lbaltura.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbaltura.Location = new System.Drawing.Point(905, 261);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(79, 31);
            this.lbaltura.TabIndex = 13;
            this.lbaltura.Text = "Altura";
            // 
            // lbpeso
            // 
            this.lbpeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbpeso.AutoSize = true;
            this.lbpeso.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbpeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbpeso.Location = new System.Drawing.Point(750, 261);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(63, 31);
            this.lbpeso.TabIndex = 12;
            this.lbpeso.Text = "Peso";
            // 
            // lbkg
            // 
            this.lbkg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbkg.AutoSize = true;
            this.lbkg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbkg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbkg.Location = new System.Drawing.Point(832, 296);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(39, 31);
            this.lbkg.TabIndex = 18;
            this.lbkg.Text = "kg";
            // 
            // lbcm
            // 
            this.lbcm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcm.AutoSize = true;
            this.lbcm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbcm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbcm.Location = new System.Drawing.Point(987, 296);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(44, 31);
            this.lbcm.TabIndex = 19;
            this.lbcm.Text = "cm";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCancelar.Location = new System.Drawing.Point(134, 471);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(295, 45);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.button2.Location = new System.Drawing.Point(435, 471);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btCadastrar.Location = new System.Drawing.Point(736, 471);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(295, 45);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // FormCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1164, 599);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbcm);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lbaltura);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.lbNovoCadastro);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbidade);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.tbAltura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1182, 646);
            this.Name = "FormCadAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FormCadAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadAluno_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNovoCadastro;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lbaltura;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.Label lbcm;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btCadastrar;
    }
}

