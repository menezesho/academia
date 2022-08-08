namespace projetofinal
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lbprofessorescadastrados = new System.Windows.Forms.Label();
            this.dgprofessores = new System.Windows.Forms.DataGridView();
            this.cracha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofessores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbprofessorescadastrados
            // 
            this.lbprofessorescadastrados.AutoSize = true;
            this.lbprofessorescadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbprofessorescadastrados.Location = new System.Drawing.Point(331, 51);
            this.lbprofessorescadastrados.Name = "lbprofessorescadastrados";
            this.lbprofessorescadastrados.Size = new System.Drawing.Size(333, 31);
            this.lbprofessorescadastrados.TabIndex = 18;
            this.lbprofessorescadastrados.Text = "PROFESSORES CADASTRADOS";
            // 
            // dgprofessores
            // 
            this.dgprofessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprofessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cracha,
            this.nome,
            this.cpf,
            this.idade,
            this.endereco,
            this.celular,
            this.email,
            this.aula});
            this.dgprofessores.Location = new System.Drawing.Point(30, 107);
            this.dgprofessores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgprofessores.Name = "dgprofessores";
            this.dgprofessores.RowHeadersWidth = 45;
            this.dgprofessores.RowTemplate.Height = 25;
            this.dgprofessores.Size = new System.Drawing.Size(1002, 348);
            this.dgprofessores.TabIndex = 17;
            this.dgprofessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprofessores_CellContentClick);
            // 
            // cracha
            // 
            this.cracha.HeaderText = "Crachá";
            this.cracha.MinimumWidth = 6;
            this.cracha.Name = "cracha";
            this.cracha.ReadOnly = true;
            this.cracha.Width = 80;
            // 
            // nome
            // 
            this.nome.FillWeight = 200F;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 6;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 125;
            // 
            // idade
            // 
            this.idade.FillWeight = 50F;
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 6;
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            this.idade.Width = 60;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 150;
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 170;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.MinimumWidth = 6;
            this.aula.Name = "aula";
            this.aula.ReadOnly = true;
            this.aula.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1062, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.sairToolStripMenuItem.Text = "Retornar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbprofessorescadastrados);
            this.Controls.Add(this.dgprofessores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros de Professores";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgprofessores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbprofessorescadastrados;
        private System.Windows.Forms.DataGridView dgprofessores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cracha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
    }
}