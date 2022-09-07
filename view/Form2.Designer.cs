
namespace projetofinal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbalunoscadastrados = new System.Windows.Forms.Label();
            this.dgpessoas = new System.Windows.Forms.DataGridView();
            this.cracha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1335, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.sairToolStripMenuItem.Text = "Retornar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbalunoscadastrados
            // 
            this.lbalunoscadastrados.AutoSize = true;
            this.lbalunoscadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbalunoscadastrados.Location = new System.Drawing.Point(392, 51);
            this.lbalunoscadastrados.Name = "lbalunoscadastrados";
            this.lbalunoscadastrados.Size = new System.Drawing.Size(273, 31);
            this.lbalunoscadastrados.TabIndex = 16;
            this.lbalunoscadastrados.Text = "ALUNOS CADASTRADOS";
            // 
            // dgpessoas
            // 
            this.dgpessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cracha,
            this.nome,
            this.cpf,
            this.idade,
            this.endereco,
            this.celular,
            this.email,
            this.senha,
            this.peso,
            this.altura});
            this.dgpessoas.Location = new System.Drawing.Point(41, 115);
            this.dgpessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgpessoas.Name = "dgpessoas";
            this.dgpessoas.RowHeadersWidth = 45;
            this.dgpessoas.RowTemplate.Height = 25;
            this.dgpessoas.Size = new System.Drawing.Size(1259, 348);
            this.dgpessoas.TabIndex = 18;
            this.dgpessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpessoas_CellContentClick);
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
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.MinimumWidth = 6;
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Width = 125;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.MinimumWidth = 6;
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 125;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.MinimumWidth = 6;
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            this.altura.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1335, 488);
            this.Controls.Add(this.dgpessoas);
            this.Controls.Add(this.lbalunoscadastrados);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lbalunoscadastrados;
        public System.Windows.Forms.DataGridView dgpessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cracha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
    }
}