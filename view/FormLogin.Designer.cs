
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
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.lbversao = new System.Windows.Forms.Label();
            this.btversenha = new System.Windows.Forms.Button();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.btreload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbusuario.Location = new System.Drawing.Point(304, 32);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(68, 23);
            this.lbusuario.TabIndex = 0;
            this.lbusuario.Text = "Usuário";
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbsenha.Location = new System.Drawing.Point(304, 98);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(57, 23);
            this.lbsenha.TabIndex = 1;
            this.lbsenha.Text = "Senha";
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(304, 124);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(232, 27);
            this.tbsenha.TabIndex = 2;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetofinal.Properties.Resources.logo_academia_t;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlogin.Location = new System.Drawing.Point(304, 183);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(219, 35);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.GhostWhite;
            this.btsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsair.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(529, 183);
            this.btsair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(41, 35);
            this.btsair.TabIndex = 6;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // lbversao
            // 
            this.lbversao.AutoSize = true;
            this.lbversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbversao.Location = new System.Drawing.Point(12, 233);
            this.lbversao.Name = "lbversao";
            this.lbversao.Size = new System.Drawing.Size(40, 13);
            this.lbversao.TabIndex = 17;
            this.lbversao.Text = "v.1.1.1";
            // 
            // btversenha
            // 
            this.btversenha.BackColor = System.Drawing.Color.Transparent;
            this.btversenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btversenha.FlatAppearance.BorderSize = 0;
            this.btversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btversenha.Image = ((System.Drawing.Image)(resources.GetObject("btversenha.Image")));
            this.btversenha.Location = new System.Drawing.Point(536, 122);
            this.btversenha.Name = "btversenha";
            this.btversenha.Size = new System.Drawing.Size(34, 29);
            this.btversenha.TabIndex = 3;
            this.btversenha.UseVisualStyleBackColor = false;
            this.btversenha.Click += new System.EventHandler(this.btversenha_Click);
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Items.AddRange(new object[] {
            "Selecione"});
            this.cbusuario.Location = new System.Drawing.Point(304, 58);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(232, 28);
            this.cbusuario.TabIndex = 0;
            // 
            // btreload
            // 
            this.btreload.BackColor = System.Drawing.Color.Transparent;
            this.btreload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreload.FlatAppearance.BorderSize = 0;
            this.btreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreload.ForeColor = System.Drawing.Color.Transparent;
            this.btreload.Image = ((System.Drawing.Image)(resources.GetObject("btreload.Image")));
            this.btreload.Location = new System.Drawing.Point(536, 57);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(34, 28);
            this.btreload.TabIndex = 1;
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(594, 255);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.btversenha);
            this.Controls.Add(this.lbversao);
            this.Controls.Add(this.btsair);
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
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label lbversao;
        private System.Windows.Forms.Button btversenha;
        private System.Windows.Forms.ComboBox cbusuario;
        private System.Windows.Forms.Button btreload;
    }
}