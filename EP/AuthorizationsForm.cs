﻿using System;
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

        private void logInButton_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseClient client = new DataBase.DataBaseClient();
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            int tmpUserId = client.Authorizate(username, password);
            switch (tmpUserId)
            {
                case -1:
                    {
                        usernameBox.Text = "";
                        passwordBox.Text = "";
                        Bitmap fail = new Bitmap(@"..\..\images\fail.jpg");
                        nameCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        passwordCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        nameCheckBox.Image = fail;
                        passwordCheckBox.Image = fail;
                        break;
                    }
                case -2:
                    {
                        passwordBox.Text = "";
                        Bitmap suceed = new Bitmap(@"..\..\images\suceed.jpg");
                        Bitmap fail = new Bitmap(@"..\..\images\fail.jpg");
                        nameCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        passwordCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        nameCheckBox.Image = suceed;
                        passwordCheckBox.Image = fail;
                        break;
                    }
                default:
                    MessageBox.Show("Suceed!");
                    this.Close();
                    break;
            }
        }
    }
}
