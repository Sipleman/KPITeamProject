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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        private AuthorizationsForm _f1;
        public RegForm(AuthorizationsForm f1)
        {
            InitializeComponent();
            _f1 = f1;
        }
        private void RegForm_Load(object sender, EventArgs e)
        {
            FstLabel.Font = new Font("Eras Bold ITC", FstLabel.Font.Size);
            SndLabel.Font = new Font("Eras Bold ITC", SndLabel.Font.Size);
            LoginLabel.Font = new Font("Eras Bold ITC", LoginLabel.Font.Size);
            PassLabel.Font = new Font("Eras Bold ITC", PassLabel.Font.Size);
            LangLabel.Font = new Font("Eras Bold ITC", LangLabel.Font.Size);
            ConfPassLabel.Font = new Font("Eras Bold ITC", ConfPassLabel.Font.Size);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _f1.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
