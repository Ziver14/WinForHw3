using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForHw3
{
    public partial class Form3 : Form
    {
        public Form3(string text)
        {
            InitializeComponent();
            txtEdit.Text = text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2 parentForm = (Form2)Application.OpenForms["Form2"];
            if (parentForm != null)
            {
                parentForm.UpdateText(txtEdit.Text);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
