using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample1
{
    public partial class IOcheck : Form
    {
        public IOcheck()
        {
            InitializeComponent();
        }

        private void IOcheckBack_button_Click(object sender, EventArgs e)
        {
            IOchecklist Back = new IOchecklist();
            Back.Show();
            this.Close();
        }

        private void IOcheckCI_button_Click(object sender, EventArgs e)
        {
            Accounts CI = new Accounts();
            CI.Show();
            this.Close();
        }


        
    }
}
