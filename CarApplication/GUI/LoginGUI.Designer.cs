namespace CarApplication
{
    partial class LoginGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnCanel = new Button();
            textUsername = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(326, 384);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 32);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(490, 384);
            btnCanel.Margin = new Padding(3, 4, 3, 4);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(89, 32);
            btnCanel.TabIndex = 4;
            btnCanel.Text = "Cancel";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(370, 163);
            textUsername.Margin = new Padding(3, 4, 3, 4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(209, 27);
            textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(370, 260);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(209, 27);
            textPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 167);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 264);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // LoginGUI
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCanel;
            ClientSize = new Size(897, 624);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(btnCanel);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            FormClosing += LoginGUI_FormClosing;
            Load += LoginGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCanel;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label label1;
        private Label label2;
    }
}