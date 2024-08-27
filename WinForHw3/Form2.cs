using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinForHw3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                openFileDialog.Title = "Select a Text File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtDisplay.Text = File.ReadAllText(openFileDialog.FileName);
                        btnEdit.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form3 editForm = new Form3(txtDisplay.Text);
            editForm.Show();
        }
        public void UpdateText(string text)
        {
            txtDisplay.Text = text;
        }
    }
}
