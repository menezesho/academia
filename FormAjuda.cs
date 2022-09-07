using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace projetofinal
{
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://drive.google.com/file/d/1N7vRpj32LfYL6NzDiFpazZEP1dCrigXg/view");
        }

        private void FormAjuda_Load(object sender, EventArgs e)
        {

        }
    }
}
