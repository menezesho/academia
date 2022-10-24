namespace academia
{
    partial class FormCadAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAula));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbNovoCadastro = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCancelar.Location = new System.Drawing.Point(87, 254);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 30);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btLimpar.Location = new System.Drawing.Point(193, 254);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(99, 30);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btCadastrar.Location = new System.Drawing.Point(298, 254);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(99, 30);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // mtbData
            // 
            this.mtbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbData.BackColor = System.Drawing.Color.White;
            this.mtbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbData.Location = new System.Drawing.Point(87, 192);
            this.mtbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbData.Mask = "00-00-0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(135, 29);
            this.mtbData.TabIndex = 1;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHorario.AutoSize = true;
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHorario.Location = new System.Drawing.Point(260, 167);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(63, 21);
            this.lbHorario.TabIndex = 54;
            this.lbHorario.Text = "Horário";
            // 
            // lbNovoCadastro
            // 
            this.lbNovoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNovoCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.lbNovoCadastro.Location = new System.Drawing.Point(87, 48);
            this.lbNovoCadastro.Name = "lbNovoCadastro";
            this.lbNovoCadastro.Size = new System.Drawing.Size(310, 45);
            this.lbNovoCadastro.TabIndex = 58;
            this.lbNovoCadastro.Text = "NOVO CADASTRO";
            this.lbNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.Location = new System.Drawing.Point(87, 134);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(310, 29);
            this.tbNome.TabIndex = 0;
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbData.AutoSize = true;
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbData.Location = new System.Drawing.Point(87, 167);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(42, 21);
            this.lbData.TabIndex = 51;
            this.lbData.Text = "Data";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbnome.Location = new System.Drawing.Point(87, 109);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 50;
            this.lbnome.Text = "Nome";
            // 
            // cbHora
            // 
            this.cbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
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
            this.cbHora.Location = new System.Drawing.Point(260, 191);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(137, 29);
            this.cbHora.TabIndex = 2;
            // 
            // FormCadAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(483, 350);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbNovoCadastro);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(501, 397);
            this.Name = "FormCadAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.FormCadAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadAula_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbNovoCadastro;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.ComboBox cbHora;
    }
}