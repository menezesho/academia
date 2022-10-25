
namespace projetofinal
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbsenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lbSair = new System.Windows.Forms.Label();
            this.lbVerSenha = new System.Windows.Forms.Label();
            this.lbReload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbusuario
            // 
            this.lbusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbusuario.Location = new System.Drawing.Point(86, 249);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(68, 23);
            this.lbusuario.TabIndex = 0;
            this.lbusuario.Text = "Usuário";
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbsenha.Location = new System.Drawing.Point(86, 318);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(57, 23);
            this.lbsenha.TabIndex = 1;
            this.lbsenha.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenha.Location = new System.Drawing.Point(86, 345);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(260, 29);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Location = new System.Drawing.Point(86, 407);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(260, 37);
            this.btlogin.TabIndex = 2;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "Selecione"});
            this.cbUsuario.Location = new System.Drawing.Point(86, 276);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(260, 29);
            this.cbUsuario.TabIndex = 0;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(347, 407);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(40, 37);
            this.lbSair.TabIndex = 3;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // lbVerSenha
            // 
            this.lbVerSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVerSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerSenha.Image = ((System.Drawing.Image)(resources.GetObject("lbVerSenha.Image")));
            this.lbVerSenha.Location = new System.Drawing.Point(48, 345);
            this.lbVerSenha.Name = "lbVerSenha";
            this.lbVerSenha.Size = new System.Drawing.Size(33, 29);
            this.lbVerSenha.TabIndex = 8;
            this.lbVerSenha.MouseCaptureChanged += new System.EventHandler(this.lbVerSenha_Click);
            // 
            // lbReload
            // 
            this.lbReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReload.Image = ((System.Drawing.Image)(resources.GetObject("lbReload.Image")));
            this.lbReload.Location = new System.Drawing.Point(48, 276);
            this.lbReload.Name = "lbReload";
            this.lbReload.Size = new System.Drawing.Size(33, 29);
            this.lbReload.TabIndex = 9;
            this.lbReload.MouseCaptureChanged += new System.EventHandler(this.lbReload_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(434, 542);
            this.Controls.Add(this.lbReload);
            this.Controls.Add(this.lbVerSenha);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Label lbVerSenha;
        private System.Windows.Forms.Label lbReload;
    }
}