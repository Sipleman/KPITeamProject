﻿namespace EP
{
    partial class AuthorizationsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.nameCheckBox = new System.Windows.Forms.PictureBox();
            this.passwordCheckBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.97163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.02837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.namelabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.logoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.appNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.registrationButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.logInButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nameCheckBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordCheckBox, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.10526F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelabel.Location = new System.Drawing.Point(2, 49);
            this.namelabel.Margin = new System.Windows.Forms.Padding(2);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(110, 19);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name:";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlabel
            // 
            this.passwordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordlabel.Location = new System.Drawing.Point(2, 72);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(2);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(110, 24);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password: ";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(117, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(117, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // logoBox
            // 
            this.logoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoBox.Location = new System.Drawing.Point(3, 3);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(108, 41);
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameLabel.Location = new System.Drawing.Point(116, 2);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(141, 43);
            this.appNameLabel.TabIndex = 5;
            this.appNameLabel.Text = "KPITeamProject";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationButton.Location = new System.Drawing.Point(3, 258);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(108, 29);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.Location = new System.Drawing.Point(117, 258);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(139, 29);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCheckBox.Location = new System.Drawing.Point(262, 50);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(17, 17);
            this.nameCheckBox.TabIndex = 8;
            this.nameCheckBox.TabStop = false;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.Location = new System.Drawing.Point(262, 73);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(17, 22);
            this.passwordCheckBox.TabIndex = 9;
            this.passwordCheckBox.TabStop = false;
            // 
            // AuthorizationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AuthorizationsForm";
            this.Text = "Authorizate";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordCheckBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox nameCheckBox;
        private System.Windows.Forms.PictureBox passwordCheckBox;
    }
}

