using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using MicroInput = SharpLib.MicroInput;


namespace MicroInputDemo
{
    public partial class FormMain : Form
    {
        MicroInput.Client iClient;

        public FormMain()
        {
            InitializeComponent();
            iClient = new MicroInput.Client();
            
            // Populate keyboard keys and modifiers
            PopulateKeyboardKeys();
            PopulateKeyboardModifers();
            // Update our UI
            UpdateControls();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PopulateKeyboardKeys()
        {
            foreach (FieldInfo field in typeof(MicroInput.Keyboard.Key).GetFields())
            {
                if (field.IsPublic)
                {
                    iComboBoxKeyboardKeys.Items.Add(field.Name);
                }
            }

            // Set first item as current
            iComboBoxKeyboardKeys.Text = iComboBoxKeyboardKeys.Items[0].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PopulateKeyboardModifers()
        {
            foreach (FieldInfo field in typeof(MicroInput.Keyboard.Modifier).GetFields())
            {
                if (field.IsPublic)
                {
                    iCheckedListBoxModifiers.Items.Add(field.Name);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateControls()
        {
            if (iClient.IsOpen)
            {
                iButtonOpen.Enabled = false;
                //
                iButtonClose.Enabled = true;
                iButtonAction.Enabled = true;
                iButtonPrint.Enabled = true;
                iCheckedListBoxModifiers.Enabled = true;
                iComboBoxKeyboardKeys.Enabled = true;
                iTextBoxInput.Enabled = true;
                iTextBoxOutput.Enabled = true;
            }
            else
            {
                iButtonOpen.Enabled = true;
                //
                iButtonClose.Enabled = false;
                iButtonAction.Enabled = false;
                iButtonPrint.Enabled = false;
                iCheckedListBoxModifiers.Enabled = false;
                iComboBoxKeyboardKeys.Enabled = false;
                iTextBoxInput.Enabled = false;
                iTextBoxOutput.Enabled = false;
            }
        }

        private void iButtonPrint_Click(object sender, EventArgs e)
        {
            // Set focus to our input field
            iTextBoxInput.Focus();
            // Send output to our microcontroller
            iClient.Print(iTextBoxOutput.Text);
        }

        private void iButtonOpen_Click(object sender, EventArgs e)
        {
            iClient.Open();
            UpdateControls();
        }

        private void iButtonClose_Click(object sender, EventArgs e)
        {
            iClient.Close();
            UpdateControls();
        }

  


        private void iButtonAction_Click(object sender, EventArgs e)
        {
            // Set focus to our input field
            iTextBoxInput.Focus();
            iTextBoxInput.SelectAll();
            // Send output to our microcontroller

            // Pack selected modifiers
            ushort modifiers = 0;
            foreach (string item in iCheckedListBoxModifiers.CheckedItems)
            {
                modifiers |= (ushort)typeof(MicroInput.Keyboard.Modifier).GetField(item).GetValue(null);
            }

            // Execute our keyboard action
            iClient.KeyboardAction((ushort)typeof(MicroInput.Keyboard.Key).GetField(iComboBoxKeyboardKeys.Text).GetValue(null), modifiers);
        }

        private void iButtonRelease_Click(object sender, EventArgs e)
        {
            // Set focus to our input field
            iTextBoxInput.Focus();
            //iTextBoxInput.SelectAll();
            // Send output to our microcontroller

            // Pack selected modifiers
            ushort modifiers = 0;
            foreach (string item in iCheckedListBoxModifiers.CheckedItems)
            {
                modifiers |= (ushort)typeof(MicroInput.Keyboard.Modifier).GetField(item).GetValue(null);
            }

            // Execute our keyboard action
            iClient.KeyboardRelease((ushort)typeof(MicroInput.Keyboard.Key).GetField(iComboBoxKeyboardKeys.Text).GetValue(null), modifiers);
        }

        private void iButtonPress_Click(object sender, EventArgs e)
        {
            // Set focus to our input field
            iTextBoxInput.Focus();
            iTextBoxInput.SelectAll();
            // Send output to our microcontroller

            // Pack selected modifiers
            ushort modifiers = 0;
            foreach (string item in iCheckedListBoxModifiers.CheckedItems)
            {
                modifiers |= (ushort)typeof(MicroInput.Keyboard.Modifier).GetField(item).GetValue(null);
            }

            // Execute our keyboard action
            iClient.KeyboardPress((ushort)typeof(MicroInput.Keyboard.Key).GetField(iComboBoxKeyboardKeys.Text).GetValue(null), modifiers);

        }
    }
}
