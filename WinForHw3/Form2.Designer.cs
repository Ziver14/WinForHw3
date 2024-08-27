namespace WinForHw3
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
            btnLoad = new Button();
            btnEdit = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(621, 39);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(124, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(621, 111);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(40, 24);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(555, 414);
            txtDisplay.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDisplay);
            Controls.Add(btnEdit);
            Controls.Add(btnLoad);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnEdit;
        private TextBox txtDisplay;
    }
}