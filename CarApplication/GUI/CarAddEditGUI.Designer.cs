namespace CarApplication.GUI
{
    partial class CarAddEditGUI
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
            textMake = new TextBox();
            textColor = new TextBox();
            textPetName = new TextBox();
            carColor = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 144);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Car ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 247);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 144);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Color: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 253);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "PetName:";
            // 
            // textCarID
            // 
            textCarID.Location = new Point(210, 140);
            textCarID.Margin = new Padding(3, 4, 3, 4);
            textCarID.Name = "textCarID";
            textCarID.Size = new Size(114, 27);
            textCarID.TabIndex = 4;
            // 
            // textMake
            // 
            textMake.Location = new Point(210, 243);
            textMake.Margin = new Padding(3, 4, 3, 4);
            textMake.Name = "textMake";
            textMake.Size = new Size(114, 27);
            textMake.TabIndex = 5;
            // 
            // textColor
            // 
            textColor.Location = new Point(611, 140);
            textColor.Margin = new Padding(3, 4, 3, 4);
            textColor.Name = "textColor";
            textColor.Size = new Size(114, 27);
            textColor.TabIndex = 6;
            textColor.LostFocus += TextColor_LostFocus;
            // 
            // textPetName
            // 
            textPetName.Location = new Point(611, 243);
            textPetName.Margin = new Padding(3, 4, 3, 4);
            textPetName.Name = "textPetName";
            textPetName.Size = new Size(114, 27);
            textPetName.TabIndex = 7;
            // 
            // carColor
            // 
            carColor.Location = new Point(743, 140);
            carColor.Margin = new Padding(3, 4, 3, 4);
            carColor.Name = "carColor";
            carColor.Size = new Size(36, 27);
            carColor.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 393);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(509, 393);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CarAddEditGUI
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(carColor);
            Controls.Add(textPetName);
            Controls.Add(textColor);
            Controls.Add(textMake);
            Controls.Add(textCarID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarAddEditGUI";
            Text = "CarAddEditGUI";
            Load += CarAddEditGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textCarID;
        private TextBox textMake;
        private TextBox textColor;
        private TextBox textPetName;
        private TextBox carColor;
        private Button btnSave;
        private Button btnCancel;
    }
}