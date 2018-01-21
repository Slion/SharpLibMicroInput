using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            iClient.KeyboardAction(MicroInput.Keyboard.KEY_A);
        }
    }
}
