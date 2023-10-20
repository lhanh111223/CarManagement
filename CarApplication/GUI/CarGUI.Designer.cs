namespace CarApplication.GUI
{
    partial class CarGUI
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
            dataCarView = new DataGridView();
            labelNumberOfCars = new Label();
            btnAddNew = new Button();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataCarView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataCarView
            // 
            dataCarView.AllowUserToAddRows = false;
            dataCarView.AllowUserToDeleteRows = false;
            dataCarView.AllowUserToResizeColumns = false;
            dataCarView.AllowUserToResizeRows = false;
            dataCarView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCarView.Location = new Point(12, 108);
            dataCarView.Name = "dataCarView";
            dataCarView.RowTemplate.Height = 25;
            dataCarView.Size = new Size(761, 348);
            dataCarView.TabIndex = 0;
            dataCarView.CellContentClick += dataCarView_CellContentClick;
            // 
            // labelNumberOfCars
            // 
            labelNumberOfCars.AutoSize = true;
            labelNumberOfCars.Location = new Point(21, 77);
            labelNumberOfCars.Name = "labelNumberOfCars";
            labelNumberOfCars.Size = new Size(109, 15);
            labelNumberOfCars.TabIndex = 2;
            labelNumberOfCars.Text = "The number of cars";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(21, 40);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(109, 23);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add new...";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // CarGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 468);
            Controls.Add(btnAddNew);
            Controls.Add(labelNumberOfCars);
            Controls.Add(dataCarView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CarGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarGUI";
            FormClosed += CarGUI_FormClosed;
            Load += CarGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataCarView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataCarView;
        private Label labelNumberOfCars;
        private Button btnAddNew;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}