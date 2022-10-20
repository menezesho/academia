
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
            this.lbeditarcadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEditarProf = new System.Windows.Forms.Button();
            this.btInserirProf = new System.Windows.Forms.Button();
            this.lbSair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.Lavender;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(77, 60);
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
            this.btInserirAluno.Location = new System.Drawing.Point(511, 179);
            this.btInserirAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInserirAluno.Name = "btInserirAluno";
            this.btInserirAluno.Size = new System.Drawing.Size(134, 55);
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
            this.btEditarAluno.Location = new System.Drawing.Point(511, 248);
            this.btEditarAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarAluno.Name = "btEditarAluno";
            this.btEditarAluno.Size = new System.Drawing.Size(134, 55);
            this.btEditarAluno.TabIndex = 16;
            this.btEditarAluno.Text = "EDITAR ";
            this.btEditarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditarAluno.UseVisualStyleBackColor = false;
            this.btEditarAluno.Click += new System.EventHandler(this.btEditarAluno_Click);
            // 
            // lbeditarcadastro
            // 
            this.lbeditarcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbeditarcadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbeditarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbeditarcadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbeditarcadastro.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbeditarcadastro.Location = new System.Drawing.Point(498, 130);
            this.lbeditarcadastro.Name = "lbeditarcadastro";
            this.lbeditarcadastro.Size = new System.Drawing.Size(160, 200);
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
            this.label2.Location = new System.Drawing.Point(664, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 200);
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
            this.btEditarProf.Location = new System.Drawing.Point(676, 248);
            this.btEditarProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarProf.Name = "btEditarProf";
            this.btEditarProf.Size = new System.Drawing.Size(134, 55);
            this.btEditarProf.TabIndex = 36;
            this.btEditarProf.Text = "EDITAR ";
            this.btEditarProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btInserirProf.Location = new System.Drawing.Point(676, 179);
            this.btInserirProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInserirProf.Name = "btInserirProf";
            this.btInserirProf.Size = new System.Drawing.Size(134, 55);
            this.btInserirProf.TabIndex = 35;
            this.btInserirProf.Text = "INSERIR";
            this.btInserirProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInserirProf.UseVisualStyleBackColor = false;
            this.btInserirProf.Click += new System.EventHandler(this.btInserirProf_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(279, 327);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(40, 37);
            this.lbSair.TabIndex = 37;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(970, 489);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.btEditarProf);
            this.Controls.Add(this.btInserirProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEditarAluno);
            this.Controls.Add(this.btInserirAluno);
            this.Controls.Add(this.lbeditarcadastro);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(988, 536);
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
        private System.Windows.Forms.Label lbeditarcadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEditarProf;
        private System.Windows.Forms.Button btInserirProf;
        private System.Windows.Forms.Label lbSair;
    }
}