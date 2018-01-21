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

           PopulateKeyboardKeys();
           PopulateKeyboardModifers();
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
            iComboBoxKeyboardKeys.Text=iComboBoxKeyboardKeys.Items[0].ToString();
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
        }

        private void iButtonClose_Click(object sender, EventArgs e)
        {
            iClient.Close();
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

    }
}
