namespace academia
{
    partial class FormInserirNaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirNaAula));
            this.cbNomeAluno = new System.Windows.Forms.ComboBox();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.lbAulaAluno = new System.Windows.Forms.Label();
            this.tbAulaAluno = new System.Windows.Forms.ComboBox();
            this.lbAulaProf = new System.Windows.Forms.Label();
            this.cbAulaProf = new System.Windows.Forms.ComboBox();
            this.lbNomeProf = new System.Windows.Forms.Label();
            this.cbNomeProf = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomeAluno
            // 
            this.cbNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbNomeAluno.BackColor = System.Drawing.Color.White;
            this.cbNomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNomeAluno.FormattingEnabled = true;
            this.cbNomeAluno.Items.AddRange(new object[] {
            "Selecione",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.cbNomeAluno.Location = new System.Drawing.Point(138, 179);
            this.cbNomeAluno.Name = "cbNomeAluno";
            this.cbNomeAluno.Size = new System.Drawing.Size(221, 36);
            this.cbNomeAluno.TabIndex = 4;
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNomeAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbNomeAluno.Location = new System.Drawing.Point(138, 145);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(77, 31);
            this.lbNomeAluno.TabIndex = 79;
            this.lbNomeAluno.Text = "Nome";
            // 
            // rbAluno
            // 
            this.rbAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAluno.AutoSize = true;
            this.rbAluno.BackColor = System.Drawing.Color.Lavender;
            this.rbAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.rbAluno.Location = new System.Drawing.Point(138, 52);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(133, 50);
            this.rbAluno.TabIndex = 80;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = false;
            // 
            // rbProfessor
            // 
            this.rbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.BackColor = System.Drawing.Color.Lavender;
            this.rbProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProfessor.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.rbProfessor.Location = new System.Drawing.Point(444, 52);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(186, 50);
            this.rbProfessor.TabIndex = 81;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = false;
            // 
            // lbAulaAluno
            // 
            this.lbAulaAluno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAulaAluno.AutoSize = true;
            this.lbAulaAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAulaAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbAulaAluno.Location = new System.Drawing.Point(138, 238);
            this.lbAulaAluno.Name = "lbAulaAluno";
            this.lbAulaAluno.Size = new System.Drawing.Size(62, 31);
            this.lbAulaAluno.TabIndex = 83;
            this.lbAulaAluno.Text = "Aula";
            // 
            // tbAulaAluno
            // 
            this.tbAulaAluno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAulaAluno.BackColor = System.Drawing.Color.White;
            this.tbAulaAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAulaAluno.FormattingEnabled = true;
            this.tbAulaAluno.Items.AddRange(new object[] {
            "Selecione",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.tbAulaAluno.Location = new System.Drawing.Point(138, 272);
            this.tbAulaAluno.Name = "tbAulaAluno";
            this.tbAulaAluno.Size = new System.Drawing.Size(221, 36);
            this.tbAulaAluno.TabIndex = 82;
            // 
            // lbAulaProf
            // 
            this.lbAulaProf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAulaProf.AutoSize = true;
            this.lbAulaProf.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAulaProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbAulaProf.Location = new System.Drawing.Point(475, 238);
            this.lbAulaProf.Name = "lbAulaProf";
            this.lbAulaProf.Size = new System.Drawing.Size(62, 31);
            this.lbAulaProf.TabIndex = 87;
            this.lbAulaProf.Text = "Aula";
            // 
            // cbAulaProf
            // 
            this.cbAulaProf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAulaProf.BackColor = System.Drawing.Color.White;
            this.cbAulaProf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAulaProf.FormattingEnabled = true;
            this.cbAulaProf.Items.AddRange(new object[] {
            "Selecione",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.cbAulaProf.Location = new System.Drawing.Point(409, 272);
            this.cbAulaProf.Name = "cbAulaProf";
            this.cbAulaProf.Size = new System.Drawing.Size(221, 36);
            this.cbAulaProf.TabIndex = 86;
            // 
            // lbNomeProf
            // 
            this.lbNomeProf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNomeProf.AutoSize = true;
            this.lbNomeProf.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNomeProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbNomeProf.Location = new System.Drawing.Point(475, 145);
            this.lbNomeProf.Name = "lbNomeProf";
            this.lbNomeProf.Size = new System.Drawing.Size(77, 31);
            this.lbNomeProf.TabIndex = 85;
            this.lbNomeProf.Text = "Nome";
            // 
            // cbNomeProf
            // 
            this.cbNomeProf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbNomeProf.BackColor = System.Drawing.Color.White;
            this.cbNomeProf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNomeProf.FormattingEnabled = true;
            this.cbNomeProf.Items.AddRange(new object[] {
            "Selecione",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.cbNomeProf.Location = new System.Drawing.Point(409, 179);
            this.cbNomeProf.Name = "cbNomeProf";
            this.cbNomeProf.Size = new System.Drawing.Size(221, 36);
            this.cbNomeProf.TabIndex = 84;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCancelar.Location = new System.Drawing.Point(138, 343);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(160, 45);
            this.btCancelar.TabIndex = 88;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btLimpar.Location = new System.Drawing.Point(304, 343);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(160, 45);
            this.btLimpar.TabIndex = 89;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btCadastrar.Location = new System.Drawing.Point(470, 343);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(160, 45);
            this.btCadastrar.TabIndex = 90;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCadastrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.pictureBox1.Location = new System.Drawing.Point(382, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // FormInserirNaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbAulaProf);
            this.Controls.Add(this.cbAulaProf);
            this.Controls.Add(this.lbNomeProf);
            this.Controls.Add(this.cbNomeProf);
            this.Controls.Add(this.lbAulaAluno);
            this.Controls.Add(this.tbAulaAluno);
            this.Controls.Add(this.rbProfessor);
            this.Controls.Add(this.rbAluno);
            this.Controls.Add(this.lbNomeAluno);
            this.Controls.Add(this.cbNomeAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInserirNaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.FormInserirNaAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomeAluno;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.RadioButton rbProfessor;
        private System.Windows.Forms.Label lbAulaAluno;
        private System.Windows.Forms.ComboBox tbAulaAluno;
        private System.Windows.Forms.Label lbAulaProf;
        private System.Windows.Forms.ComboBox cbAulaProf;
        private System.Windows.Forms.Label lbNomeProf;
        private System.Windows.Forms.ComboBox cbNomeProf;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}