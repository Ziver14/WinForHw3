namespace WinForHw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void pgValue()
        {
            int p = lstDest.Items.Count * 20;
            if (p > 100)
                p = 100;
            pbDest.Value = p;

            p = lstSource.Items.Count * 20;
            if (p > 100) p = 100;
            pbSource.Value = p;
        }

        private void MoveItems(ListBox Source, ListBox Dest)
        {
            for (int i = 0; i < Source.SelectedItems.Count;)
            {
                Dest.Items.Add(Source.SelectedItems[i]);
                Source.Items.Remove(Source.SelectedItems[i]);
            }
        }

        private void btnAddDest_Click(object sender, EventArgs e)
        {
            if (lstSource.Items.Count == 0) { btnAddDest.Enabled = false; }
            for (int i = 0; i < lstSource.SelectedItems.Count; i++)
            {
                if (checkDell.Checked)
                {
                    MoveItems(lstSource, lstDest);
                }
                else
                {
                    lstDest.Items.Add(lstSource.SelectedItems[i]);
                }
            }
            if (lstDest.Items.Count != 0)
            {
                btnClearDestAll.Enabled = true;
                btnAddSource.Enabled = true;
                btnAddSourceAll.Enabled = true;
            }
            if (lstSource.Items.Count == 0)
            {
                btnAddDest.Enabled = false;
                btnAddDestAll.Enabled = false;
            }
            pgValue();
        }

        private void btnAddDestAll_Click(object sender, EventArgs e)
        {
            if (lstSource.Items.Count == 0)
            {
                btnAddDestAll.Enabled = false;
            }
            lstDest.Items.AddRange(lstSource.Items);
            if (checkDell.Checked)
            {
                lstSource.Items.Clear();
                btnAddDest.Enabled = false;
                btnAddDestAll.Enabled = false;
            }
            if (lstDest.Items.Count != 0)
            {
                btnClearDestAll.Enabled = true;
                btnAddSourceAll.Enabled = true;
                btnAddSource.Enabled = true;
            }
            pgValue();
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDest.SelectedItems.Count; i++)
            {
                lstSource.Items.Add(lstDest.SelectedItems[i]);
            }
            if (lstDest.Items.Count == 0)
            {
                btnClearDestAll.Enabled = false;
                btnAddSourceAll.Enabled = false;
                btnAddSource.Enabled = false;
            }
            if (lstSource.Items.Count != 0)
            {
                btnAddDest.Enabled = true;
                btnAddDestAll.Enabled = true;
            }
            pgValue();
        }

        private void btnAddSourceAll_Click(object sender, EventArgs e)
        {
            lstSource.Items.AddRange(lstDest.Items);
            if (checkDell.Checked)
            {
                lstDest.Items.Clear();
            }
            if (lstDest.Items.Count == 0)
            {
                btnClearDestAll.Enabled = false;
                btnAddSourceAll.Enabled = false;
                btnAddSource.Enabled = false;
                btnAddDest.Enabled = true;
                btnAddDestAll.Enabled = true;
            }

            pgValue();

        }

        private void btnClearDestAll_Click(object sender, EventArgs e)
        {
            lstDest.Items.Clear();
            btnAddSource.Enabled = false;
            btnAddSourceAll.Enabled = false;
            pbDest.Value = 0;
            pgValue();
        }

        Form form;

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if ((form is null) || (!form.Created))
            {
                form = new Form2();
                form.Show();
            }
        }
    }
}
