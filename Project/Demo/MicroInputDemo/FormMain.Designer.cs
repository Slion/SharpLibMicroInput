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
            this.iButtonPrint = new System.Windows.Forms.Button();
            this.iTextBoxInput = new System.Windows.Forms.TextBox();
            this.iButtonOpen = new System.Windows.Forms.Button();
            this.iButtonClose = new System.Windows.Forms.Button();
            this.iTextBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iButtonAction = new System.Windows.Forms.Button();
            this.iComboBoxKeyboardKeys = new System.Windows.Forms.ComboBox();
            this.iCheckedListBoxModifiers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // iButtonPrint
            // 
            this.iButtonPrint.Location = new System.Drawing.Point(12, 422);
            this.iButtonPrint.Name = "iButtonPrint";
            this.iButtonPrint.Size = new System.Drawing.Size(75, 23);
            this.iButtonPrint.TabIndex = 0;
            this.iButtonPrint.Text = "Print";
            this.iButtonPrint.UseVisualStyleBackColor = true;
            this.iButtonPrint.Click += new System.EventHandler(this.iButtonPrint_Click);
            // 
            // iTextBoxInput
            // 
            this.iTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iTextBoxInput.Location = new System.Drawing.Point(12, 471);
            this.iTextBoxInput.Multiline = true;
            this.iTextBoxInput.Name = "iTextBoxInput";
            this.iTextBoxInput.Size = new System.Drawing.Size(449, 103);
            this.iTextBoxInput.TabIndex = 1;
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
            this.iButtonClose.Enabled = false;
            this.iButtonClose.Location = new System.Drawing.Point(93, 12);
            this.iButtonClose.Name = "iButtonClose";
            this.iButtonClose.Size = new System.Drawing.Size(75, 23);
            this.iButtonClose.TabIndex = 3;
            this.iButtonClose.Text = "Close";
            this.iButtonClose.UseVisualStyleBackColor = true;
            this.iButtonClose.Click += new System.EventHandler(this.iButtonClose_Click);
            // 
            // iTextBoxOutput
            // 
            this.iTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iTextBoxOutput.Location = new System.Drawing.Point(12, 327);
            this.iTextBoxOutput.Multiline = true;
            this.iTextBoxOutput.Name = "iTextBoxOutput";
            this.iTextBoxOutput.Size = new System.Drawing.Size(449, 89);
            this.iTextBoxOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input:";
            // 
            // iButtonAction
            // 
            this.iButtonAction.Location = new System.Drawing.Point(386, 244);
            this.iButtonAction.Name = "iButtonAction";
            this.iButtonAction.Size = new System.Drawing.Size(75, 23);
            this.iButtonAction.TabIndex = 7;
            this.iButtonAction.Text = "Action";
            this.iButtonAction.UseVisualStyleBackColor = true;
            this.iButtonAction.Click += new System.EventHandler(this.iButtonAction_Click);
            // 
            // iComboBoxKeyboardKeys
            // 
            this.iComboBoxKeyboardKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iComboBoxKeyboardKeys.FormattingEnabled = true;
            this.iComboBoxKeyboardKeys.Location = new System.Drawing.Point(265, 217);
            this.iComboBoxKeyboardKeys.Name = "iComboBoxKeyboardKeys";
            this.iComboBoxKeyboardKeys.Size = new System.Drawing.Size(196, 21);
            this.iComboBoxKeyboardKeys.TabIndex = 8;
            // 
            // iCheckedListBoxModifiers
            // 
            this.iCheckedListBoxModifiers.FormattingEnabled = true;
            this.iCheckedListBoxModifiers.Location = new System.Drawing.Point(266, 12);
            this.iCheckedListBoxModifiers.Name = "iCheckedListBoxModifiers";
            this.iCheckedListBoxModifiers.Size = new System.Drawing.Size(195, 199);
            this.iCheckedListBoxModifiers.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 586);
            this.Controls.Add(this.iCheckedListBoxModifiers);
            this.Controls.Add(this.iComboBoxKeyboardKeys);
            this.Controls.Add(this.iButtonAction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iTextBoxOutput);
            this.Controls.Add(this.iButtonClose);
            this.Controls.Add(this.iButtonOpen);
            this.Controls.Add(this.iTextBoxInput);
            this.Controls.Add(this.iButtonPrint);
            this.Name = "FormMain";
            this.Text = "Micro Input Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iButtonPrint;
        private System.Windows.Forms.TextBox iTextBoxInput;
        private System.Windows.Forms.Button iButtonOpen;
        private System.Windows.Forms.Button iButtonClose;
        private System.Windows.Forms.TextBox iTextBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button iButtonAction;
        private System.Windows.Forms.ComboBox iComboBoxKeyboardKeys;
        private System.Windows.Forms.CheckedListBox iCheckedListBoxModifiers;
    }
}

