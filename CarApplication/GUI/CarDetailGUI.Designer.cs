namespace CarApplication.GUI
{
    partial class CarDetailGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textCarID = new TextBox();
            textColor = new TextBox();
            textMake = new TextBox();
            textPetname = new TextBox();
            carColor = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 85);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "CarID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 227);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 85);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 230);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Petname:";
            // 
            // textCarID
            // 
            textCarID.Location = new Point(190, 82);
            textCarID.Name = "textCarID";
            textCarID.ReadOnly = true;
            textCarID.Size = new Size(100, 23);
            textCarID.TabIndex = 2;
            // 
            // textColor
            // 
            textColor.Location = new Point(492, 82);
            textColor.Name = "textColor";
            textColor.ReadOnly = true;
            textColor.Size = new Size(100, 23);
            textColor.TabIndex = 4;
            // 
            // textMake
            // 
            textMake.Location = new Point(190, 224);
            textMake.Name = "textMake";
            textMake.ReadOnly = true;
            textMake.Size = new Size(100, 23);
            textMake.TabIndex = 3;
            // 
            // textPetname
            // 
            textPetname.Location = new Point(492, 224);
            textPetname.Name = "textPetname";
            textPetname.ReadOnly = true;
            textPetname.Size = new Size(100, 23);
            textPetname.TabIndex = 5;
            // 
            // carColor
            // 
            carColor.Location = new Point(626, 82);
            carColor.Name = "carColor";
            carColor.ReadOnly = true;
            carColor.Size = new Size(35, 23);
            carColor.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(327, 340);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button1_Click;
            // 
            // CarDetailGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(carColor);
            Controls.Add(textPetname);
            Controls.Add(textMake);
            Controls.Add(textColor);
            Controls.Add(textCarID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarDetailGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarDetailGUI";
            Load += CarDetailGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textCarID;
        private TextBox textColor;
        private TextBox textMake;
        private TextBox textPetname;
        private TextBox carColor;
        private Button btnBack;
    }
}