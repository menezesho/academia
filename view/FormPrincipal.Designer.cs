
namespace projetofinal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btInserirAluno = new System.Windows.Forms.Button();
            this.btEditarAluno = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbeditarcadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEditarProf = new System.Windows.Forms.Button();
            this.btInserirProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.Lavender;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(-28, -40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(442, 338);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btInserirAluno
            // 
            this.btInserirAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInserirAluno.BackColor = System.Drawing.Color.GhostWhite;
            this.btInserirAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserirAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btInserirAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btInserirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btInserirAluno.Image")));
            this.btInserirAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInserirAluno.Location = new System.Drawing.Point(406, 115);
            this.btInserirAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInserirAluno.Name = "btInserirAluno";
            this.btInserirAluno.Size = new System.Drawing.Size(134, 40);
            this.btInserirAluno.TabIndex = 15;
            this.btInserirAluno.Text = "INSERIR";
            this.btInserirAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInserirAluno.UseVisualStyleBackColor = false;
            this.btInserirAluno.Click += new System.EventHandler(this.btInserirAluno_Click);
            // 
            // btEditarAluno
            // 
            this.btEditarAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditarAluno.BackColor = System.Drawing.Color.GhostWhite;
            this.btEditarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditarAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btEditarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btEditarAluno.Image")));
            this.btEditarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditarAluno.Location = new System.Drawing.Point(406, 163);
            this.btEditarAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarAluno.Name = "btEditarAluno";
            this.btEditarAluno.Size = new System.Drawing.Size(134, 40);
            this.btEditarAluno.TabIndex = 16;
            this.btEditarAluno.Text = "EDITAR ";
            this.btEditarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditarAluno.UseVisualStyleBackColor = false;
            this.btEditarAluno.Click += new System.EventHandler(this.btEditarAluno_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSair.BackColor = System.Drawing.Color.GhostWhite;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btSair.Location = new System.Drawing.Point(156, 227);
            this.btSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(79, 35);
            this.btSair.TabIndex = 20;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbeditarcadastro
            // 
            this.lbeditarcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbeditarcadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbeditarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbeditarcadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbeditarcadastro.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbeditarcadastro.Location = new System.Drawing.Point(393, 73);
            this.lbeditarcadastro.Name = "lbeditarcadastro";
            this.lbeditarcadastro.Size = new System.Drawing.Size(160, 147);
            this.lbeditarcadastro.TabIndex = 32;
            this.lbeditarcadastro.Text = "ALUNO";
            this.lbeditarcadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(559, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 147);
            this.label2.TabIndex = 34;
            this.label2.Text = "PROFESSOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btEditarProf
            // 
            this.btEditarProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditarProf.BackColor = System.Drawing.Color.GhostWhite;
            this.btEditarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditarProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btEditarProf.Image = ((System.Drawing.Image)(resources.GetObject("btEditarProf.Image")));
            this.btEditarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditarProf.Location = new System.Drawing.Point(571, 163);
            this.btEditarProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarProf.Name = "btEditarProf";
            this.btEditarProf.Size = new System.Drawing.Size(134, 40);
            this.btEditarProf.TabIndex = 36;
            this.btEditarProf.Text = "EDITAR ";
            this.btEditarProf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btEditarProf.UseVisualStyleBackColor = false;
            this.btEditarProf.Click += new System.EventHandler(this.btEditarProf_Click);
            // 
            // btInserirProf
            // 
            this.btInserirProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInserirProf.BackColor = System.Drawing.Color.GhostWhite;
            this.btInserirProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserirProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserirProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btInserirProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btInserirProf.Image = ((System.Drawing.Image)(resources.GetObject("btInserirProf.Image")));
            this.btInserirProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInserirProf.Location = new System.Drawing.Point(571, 115);
            this.btInserirProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInserirProf.Name = "btInserirProf";
            this.btInserirProf.Size = new System.Drawing.Size(134, 40);
            this.btInserirProf.TabIndex = 35;
            this.btInserirProf.Text = "INSERIR";
            this.btInserirProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInserirProf.UseVisualStyleBackColor = false;
            this.btInserirProf.Click += new System.EventHandler(this.btInserirProf_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(760, 289);
            this.Controls.Add(this.btEditarProf);
            this.Controls.Add(this.btInserirProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEditarAluno);
            this.Controls.Add(this.btInserirAluno);
            this.Controls.Add(this.lbeditarcadastro);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(778, 336);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btInserirAluno;
        private System.Windows.Forms.Button btEditarAluno;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbeditarcadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEditarProf;
        private System.Windows.Forms.Button btInserirProf;
    }
}