namespace ClosedXML.WindowsFormsApp
{
    partial class Form
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
            this.label = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnWriteToExcel = new System.Windows.Forms.Button();
            this.btnDiffWriteToExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(227, 29);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label.Size = new System.Drawing.Size(181, 40);
            this.label.TabIndex = 0;
            this.label.Text = "Excelə content yazmaq: ";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(231, 105);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(177, 111);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // btnWriteToExcel
            // 
            this.btnWriteToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnWriteToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteToExcel.Location = new System.Drawing.Point(231, 245);
            this.btnWriteToExcel.Name = "btnWriteToExcel";
            this.btnWriteToExcel.Size = new System.Drawing.Size(177, 54);
            this.btnWriteToExcel.TabIndex = 2;
            this.btnWriteToExcel.Text = "Excel\'ə yaz";
            this.btnWriteToExcel.UseVisualStyleBackColor = false;
            this.btnWriteToExcel.Click += new System.EventHandler(this.btnWriteToExcel_Click);
            // 
            // btnDiffWriteToExcel
            // 
            this.btnDiffWriteToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDiffWriteToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiffWriteToExcel.Location = new System.Drawing.Point(231, 328);
            this.btnDiffWriteToExcel.Name = "btnDiffWriteToExcel";
            this.btnDiffWriteToExcel.Size = new System.Drawing.Size(177, 56);
            this.btnDiffWriteToExcel.TabIndex = 3;
            this.btnDiffWriteToExcel.Text = "Excel\'ə fərqli yaz";
            this.btnDiffWriteToExcel.UseVisualStyleBackColor = false;
            this.btnDiffWriteToExcel.Click += new System.EventHandler(this.btnDiffWriteToExcel_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClosedXML.WindowsFormsApp.Properties.Resources.excel_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnDiffWriteToExcel);
            this.Controls.Add(this.btnWriteToExcel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnWriteToExcel;
        private System.Windows.Forms.Button btnDiffWriteToExcel;
    }
}

