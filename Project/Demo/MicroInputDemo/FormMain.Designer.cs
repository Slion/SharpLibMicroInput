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
            this.SuspendLayout();
            // 
            // iButtonTest
            // 
            this.iButtonTest.Location = new System.Drawing.Point(85, 112);
            this.iButtonTest.Name = "iButtonTest";
            this.iButtonTest.Size = new System.Drawing.Size(75, 23);
            this.iButtonTest.TabIndex = 0;
            this.iButtonTest.Text = "Test";
            this.iButtonTest.UseVisualStyleBackColor = true;
            this.iButtonTest.Click += new System.EventHandler(this.iButtonTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.iButtonTest);
            this.Name = "FormMain";
            this.Text = "Micro Input Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iButtonTest;
    }
}

