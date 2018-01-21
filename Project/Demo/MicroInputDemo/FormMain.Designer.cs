namespace MicroInputDemo
{
    partial class FormMain
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
            this.iButtonTest = new System.Windows.Forms.Button();
            this.iTextBoxTest = new System.Windows.Forms.TextBox();
            this.iButtonOpen = new System.Windows.Forms.Button();
            this.iButtonClose = new System.Windows.Forms.Button();
            this.iTextBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iButtonTest
            // 
            this.iButtonTest.Location = new System.Drawing.Point(12, 68);
            this.iButtonTest.Name = "iButtonTest";
            this.iButtonTest.Size = new System.Drawing.Size(75, 23);
            this.iButtonTest.TabIndex = 0;
            this.iButtonTest.Text = "Test";
            this.iButtonTest.UseVisualStyleBackColor = true;
            this.iButtonTest.Click += new System.EventHandler(this.iButtonTest_Click);
            // 
            // iTextBoxTest
            // 
            this.iTextBoxTest.Location = new System.Drawing.Point(12, 260);
            this.iTextBoxTest.Multiline = true;
            this.iTextBoxTest.Name = "iTextBoxTest";
            this.iTextBoxTest.Size = new System.Drawing.Size(376, 89);
            this.iTextBoxTest.TabIndex = 1;
            // 
            // iButtonOpen
            // 
            this.iButtonOpen.Location = new System.Drawing.Point(12, 12);
            this.iButtonOpen.Name = "iButtonOpen";
            this.iButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.iButtonOpen.TabIndex = 2;
            this.iButtonOpen.Text = "Open";
            this.iButtonOpen.UseVisualStyleBackColor = true;
            this.iButtonOpen.Click += new System.EventHandler(this.iButtonOpen_Click);
            // 
            // iButtonClose
            // 
            this.iButtonClose.Location = new System.Drawing.Point(93, 12);
            this.iButtonClose.Name = "iButtonClose";
            this.iButtonClose.Size = new System.Drawing.Size(75, 23);
            this.iButtonClose.TabIndex = 3;
            this.iButtonClose.Text = "Close";
            this.iButtonClose.UseVisualStyleBackColor = true;
            this.iButtonClose.Click += new System.EventHandler(this.iButtonClose_Click);
            // 
            // iTextBoxInput
            // 
            this.iTextBoxInput.Location = new System.Drawing.Point(12, 134);
            this.iTextBoxInput.Multiline = true;
            this.iTextBoxInput.Name = "iTextBoxInput";
            this.iTextBoxInput.Size = new System.Drawing.Size(376, 89);
            this.iTextBoxInput.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 361);
            this.Controls.Add(this.iTextBoxInput);
            this.Controls.Add(this.iButtonClose);
            this.Controls.Add(this.iButtonOpen);
            this.Controls.Add(this.iTextBoxTest);
            this.Controls.Add(this.iButtonTest);
            this.Name = "FormMain";
            this.Text = "Micro Input Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iButtonTest;
        private System.Windows.Forms.TextBox iTextBoxTest;
        private System.Windows.Forms.Button iButtonOpen;
        private System.Windows.Forms.Button iButtonClose;
        private System.Windows.Forms.TextBox iTextBoxInput;
    }
}

