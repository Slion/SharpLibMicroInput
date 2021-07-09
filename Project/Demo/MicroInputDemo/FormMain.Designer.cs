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
            this.iButtonPress = new System.Windows.Forms.Button();
            this.iButtonRelease = new System.Windows.Forms.Button();
            this.numericVendorId = new System.Windows.Forms.NumericUpDown();
            this.numericProductId = new System.Windows.Forms.NumericUpDown();
            this.numericUsagePage = new System.Windows.Forms.NumericUpDown();
            this.labelVendorId = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelUsagePage = new System.Windows.Forms.Label();
            this.buttonUseTeensyDefaults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericVendorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsagePage)).BeginInit();
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
            // iButtonPress
            // 
            this.iButtonPress.Location = new System.Drawing.Point(224, 244);
            this.iButtonPress.Name = "iButtonPress";
            this.iButtonPress.Size = new System.Drawing.Size(75, 23);
            this.iButtonPress.TabIndex = 10;
            this.iButtonPress.Text = "Press";
            this.iButtonPress.UseVisualStyleBackColor = true;
            this.iButtonPress.Click += new System.EventHandler(this.iButtonPress_Click);
            // 
            // iButtonRelease
            // 
            this.iButtonRelease.Location = new System.Drawing.Point(305, 244);
            this.iButtonRelease.Name = "iButtonRelease";
            this.iButtonRelease.Size = new System.Drawing.Size(75, 23);
            this.iButtonRelease.TabIndex = 11;
            this.iButtonRelease.Text = "Release";
            this.iButtonRelease.UseVisualStyleBackColor = true;
            this.iButtonRelease.Click += new System.EventHandler(this.iButtonRelease_Click);
            // 
            // numericVendorId
            // 
            this.numericVendorId.Hexadecimal = true;
            this.numericVendorId.Location = new System.Drawing.Point(93, 89);
            this.numericVendorId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericVendorId.Name = "numericVendorId";
            this.numericVendorId.Size = new System.Drawing.Size(75, 20);
            this.numericVendorId.TabIndex = 12;
            this.numericVendorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericVendorId.Value = new decimal(new int[] {
            10248,
            0,
            0,
            0});
            // 
            // numericProductId
            // 
            this.numericProductId.Hexadecimal = true;
            this.numericProductId.Location = new System.Drawing.Point(93, 115);
            this.numericProductId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericProductId.Name = "numericProductId";
            this.numericProductId.Size = new System.Drawing.Size(75, 20);
            this.numericProductId.TabIndex = 13;
            this.numericProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUsagePage
            // 
            this.numericUsagePage.Hexadecimal = true;
            this.numericUsagePage.Location = new System.Drawing.Point(93, 141);
            this.numericUsagePage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUsagePage.Name = "numericUsagePage";
            this.numericUsagePage.Size = new System.Drawing.Size(75, 20);
            this.numericUsagePage.TabIndex = 14;
            this.numericUsagePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUsagePage.Value = new decimal(new int[] {
            65451,
            0,
            0,
            0});
            // 
            // labelVendorId
            // 
            this.labelVendorId.AutoSize = true;
            this.labelVendorId.Location = new System.Drawing.Point(21, 91);
            this.labelVendorId.Name = "labelVendorId";
            this.labelVendorId.Size = new System.Drawing.Size(55, 13);
            this.labelVendorId.TabIndex = 15;
            this.labelVendorId.Text = "Vendor ID";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(21, 117);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(58, 13);
            this.labelProductId.TabIndex = 16;
            this.labelProductId.Text = "Product ID";
            // 
            // labelUsagePage
            // 
            this.labelUsagePage.AutoSize = true;
            this.labelUsagePage.Location = new System.Drawing.Point(21, 143);
            this.labelUsagePage.Name = "labelUsagePage";
            this.labelUsagePage.Size = new System.Drawing.Size(66, 13);
            this.labelUsagePage.TabIndex = 17;
            this.labelUsagePage.Text = "Usage Page";
            // 
            // buttonUseTeensyDefaults
            // 
            this.buttonUseTeensyDefaults.Location = new System.Drawing.Point(24, 60);
            this.buttonUseTeensyDefaults.Name = "buttonUseTeensyDefaults";
            this.buttonUseTeensyDefaults.Size = new System.Drawing.Size(144, 23);
            this.buttonUseTeensyDefaults.TabIndex = 18;
            this.buttonUseTeensyDefaults.Text = "Teensy Defaults";
            this.buttonUseTeensyDefaults.UseVisualStyleBackColor = true;
            this.buttonUseTeensyDefaults.Click += new System.EventHandler(this.buttonUseTeensyDefaults_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 586);
            this.Controls.Add(this.buttonUseTeensyDefaults);
            this.Controls.Add(this.labelUsagePage);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.labelVendorId);
            this.Controls.Add(this.numericUsagePage);
            this.Controls.Add(this.numericProductId);
            this.Controls.Add(this.numericVendorId);
            this.Controls.Add(this.iButtonRelease);
            this.Controls.Add(this.iButtonPress);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericVendorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsagePage)).EndInit();
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
        private System.Windows.Forms.Button iButtonPress;
        private System.Windows.Forms.Button iButtonRelease;
        private System.Windows.Forms.NumericUpDown numericVendorId;
        private System.Windows.Forms.NumericUpDown numericProductId;
        private System.Windows.Forms.NumericUpDown numericUsagePage;
        private System.Windows.Forms.Label labelVendorId;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelUsagePage;
        private System.Windows.Forms.Button buttonUseTeensyDefaults;
    }
}

