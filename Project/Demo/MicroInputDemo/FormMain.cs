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

        private void iButtonTest_Click(object sender, EventArgs e)
        {
            iTextBoxTest.Focus();

            //iClient.Test();
            iClient.Print(iTextBoxInput.Text);
        }

        private void iButtonOpen_Click(object sender, EventArgs e)
        {
            iClient.Open();
        }

        private void iButtonClose_Click(object sender, EventArgs e)
        {
            iClient.Close();
        }
    }
}
