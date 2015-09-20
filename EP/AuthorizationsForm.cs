using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP
{
    public partial class AuthorizationsForm : Form
    {
        public AuthorizationsForm()
        {
            InitializeComponent();
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            ServerReference.Service1Client client = new ServerReference.Service1Client();
            string name = inputbox.Text;
            string result = client.Hello(name) + " ";
            result += client.GetData();
            label1.Text = result;
        }
    }
}
