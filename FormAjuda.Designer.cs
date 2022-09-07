
namespace projetofinal
{
    partial class FormAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            this.lbtexto = new System.Windows.Forms.Label();
            this.lbajuda = new System.Windows.Forms.Label();
            this.lblink = new System.Windows.Forms.LinkLabel();
            this.btok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtexto
            // 
            this.lbtexto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtexto.AutoSize = true;
            this.lbtexto.Location = new System.Drawing.Point(61, 72);
            this.lbtexto.Name = "lbtexto";
            this.lbtexto.Size = new System.Drawing.Size(305, 40);
            this.lbtexto.TabIndex = 0;
            this.lbtexto.Text = "Para obter mais informações sobre o manual\r\ndo usuário, acesse o link a seguir!";
            this.lbtexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbajuda
            // 
            this.lbajuda.AutoSize = true;
            this.lbajuda.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbajuda.Location = new System.Drawing.Point(168, 34);
            this.lbajuda.Name = "lbajuda";
            this.lbajuda.Size = new System.Drawing.Size(92, 26);
            this.lbajuda.TabIndex = 1;
            this.lbajuda.Text = "AJUDA";
            // 
            // lblink
            // 
            this.lblink.AutoSize = true;
            this.lblink.Location = new System.Drawing.Point(138, 125);
            this.lblink.Name = "lblink";
            this.lblink.Size = new System.Drawing.Size(149, 20);
            this.lblink.TabIndex = 2;
            this.lblink.TabStop = true;
            this.lblink.Text = "Manual de Instruções";
            this.lblink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblink_LinkClicked);
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(168, 173);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(94, 29);
            this.btok.TabIndex = 3;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 235);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.lblink);
            this.Controls.Add(this.lbajuda);
            this.Controls.Add(this.lbtexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtexto;
        private System.Windows.Forms.Label lbajuda;
        private System.Windows.Forms.LinkLabel lblink;
        private System.Windows.Forms.Button btok;
    }
}