namespace WinForHw3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSource = new ListBox();
            lstDest = new ListBox();
            btnAddDest = new Button();
            btnAddDestAll = new Button();
            btnAddSource = new Button();
            btnAddSourceAll = new Button();
            btnForm2 = new Button();
            pbSource = new ProgressBar();
            pbDest = new ProgressBar();
            btnClearDestAll = new Button();
            checkDell = new CheckBox();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.Items.AddRange(new object[] { "Физика", "Химия ", "Литература", "Математика", "Биология" });
            lstSource.Location = new Point(26, 12);
            lstSource.Name = "lstSource";
            lstSource.Size = new Size(183, 344);
            lstSource.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.Location = new Point(368, 12);
            lstDest.Name = "lstDest";
            lstDest.Size = new Size(170, 344);
            lstDest.TabIndex = 1;
            // 
            // btnAddDest
            // 
            btnAddDest.Location = new Point(245, 23);
            btnAddDest.Name = "btnAddDest";
            btnAddDest.Size = new Size(94, 29);
            btnAddDest.TabIndex = 2;
            btnAddDest.Text = "->";
            btnAddDest.UseVisualStyleBackColor = true;
            btnAddDest.Click += btnAddDest_Click;
            // 
            // btnAddDestAll
            // 
            btnAddDestAll.Location = new Point(245, 83);
            btnAddDestAll.Name = "btnAddDestAll";
            btnAddDestAll.Size = new Size(94, 29);
            btnAddDestAll.TabIndex = 3;
            btnAddDestAll.Text = "-->";
            btnAddDestAll.UseVisualStyleBackColor = true;
            btnAddDestAll.Click += btnAddDestAll_Click;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(245, 211);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(94, 29);
            btnAddSource.TabIndex = 4;
            btnAddSource.Text = "<-";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnAddSourceAll
            // 
            btnAddSourceAll.Location = new Point(245, 272);
            btnAddSourceAll.Name = "btnAddSourceAll";
            btnAddSourceAll.Size = new Size(94, 29);
            btnAddSourceAll.TabIndex = 5;
            btnAddSourceAll.Text = "<--";
            btnAddSourceAll.UseVisualStyleBackColor = true;
            btnAddSourceAll.Click += btnAddSourceAll_Click;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(590, 120);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(161, 45);
            btnForm2.TabIndex = 6;
            btnForm2.Text = "Загрузить";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // pbSource
            // 
            pbSource.Location = new Point(26, 374);
            pbSource.Name = "pbSource";
            pbSource.Size = new Size(183, 29);
            pbSource.TabIndex = 7;
            // 
            // pbDest
            // 
            pbDest.Location = new Point(368, 374);
            pbDest.Name = "pbDest";
            pbDest.Size = new Size(170, 29);
            pbDest.TabIndex = 8;
            // 
            // btnClearDestAll
            // 
            btnClearDestAll.Location = new Point(247, 336);
            btnClearDestAll.Name = "btnClearDestAll";
            btnClearDestAll.Size = new Size(94, 29);
            btnClearDestAll.TabIndex = 9;
            btnClearDestAll.Text = "Clear";
            btnClearDestAll.UseVisualStyleBackColor = true;
            btnClearDestAll.Click += btnClearDestAll_Click;
            // 
            // checkDell
            // 
            checkDell.AutoSize = true;
            checkDell.Location = new Point(588, 32);
            checkDell.Name = "checkDell";
            checkDell.Size = new Size(182, 24);
            checkDell.TabIndex = 10;
            checkDell.Text = "Удалять из источника";
            checkDell.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkDell);
            Controls.Add(btnClearDestAll);
            Controls.Add(pbDest);
            Controls.Add(pbSource);
            Controls.Add(btnForm2);
            Controls.Add(btnAddSourceAll);
            Controls.Add(btnAddSource);
            Controls.Add(btnAddDestAll);
            Controls.Add(btnAddDest);
            Controls.Add(lstDest);
            Controls.Add(lstSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private ListBox lstDest;
        private Button btnAddDest;
        private Button btnAddDestAll;
        private Button btnAddSource;
        private Button btnAddSourceAll;
        private Button btnForm2;
        private ProgressBar pbSource;
        private ProgressBar pbDest;
        private Button btnClearDestAll;
        private CheckBox checkDell;
    }
}
