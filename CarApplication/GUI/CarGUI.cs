using CarApplication.DAL;
using CarApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApplication.GUI
{
    public partial class CarGUI : Form
    {
        private static CarDAO carDAO = new CarDAO();
        private static AccountDAO accountDAO = new AccountDAO();

        public string role { get; set; }

        public CarGUI()
        {
            InitializeComponent();
        }

        public CarGUI(string role)
        {
            this.role = role;
            InitializeComponent();

        }
        // event click button 'detail' - 'edit' - 'delete'
        private void dataCarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // click into column is button
                if (dataCarView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // click into 'detail'
                    if (dataCarView.Columns[e.ColumnIndex].HeaderText == "Detail")
                    {
                        // get car detail where user click 'detail'
                        Car CarClicked = carDAO.GetAllCars()[e.RowIndex];
                        CarDetailGUI carDetailGUI = new CarDetailGUI(CarClicked);
                        carDetailGUI.ShowDialog();
                    }
                    // click into 'update'
                    else if (dataCarView.Columns[e.ColumnIndex].HeaderText == "Edit")
                    {
                        Car CarClicked = carDAO.GetAllCars()[e.RowIndex];
                        CarAddEditGUI carAddEditGUI = new CarAddEditGUI(CarClicked);
                        carAddEditGUI.ShowDialog();
                        RefreshDataCarView();

                    }
                    // click into 'delete'
                    else if (dataCarView.Columns[e.ColumnIndex].HeaderText == "Delete")
                    {
                        Car CarClicked = carDAO.GetAllCars()[e.RowIndex];
                        if(MessageBox.Show("Do you want to delete this Car", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            carDAO.DeleteCar(CarClicked);
                            RefreshDataCarView();
                        }
                    }
                }
            }
            
        }

        // main view for both customer and admin
        public void CreateMainView()
        {
            DataGridViewTextBoxColumn colMake = new DataGridViewTextBoxColumn();
            colMake.HeaderText = "Make";
            dataCarView.Columns.Add(colMake);
            DataGridViewTextBoxColumn colColor = new DataGridViewTextBoxColumn();
            colColor.HeaderText = "Color";
            dataCarView.Columns.Add(colColor);
            DataGridViewTextBoxColumn colPetname = new DataGridViewTextBoxColumn();
            colPetname.HeaderText = "Pet Name";
            dataCarView.Columns.Add(colPetname);
            DataGridViewButtonColumn colDetail = new DataGridViewButtonColumn();
            colDetail.HeaderText = "Detail";
            dataCarView.Columns.Add(colDetail);
        }

        // Load data for CarGUI for Customer
        private void LoadCustomerView()
        {
            btnAddNew.Visible = false;
            CreateMainView();
            foreach (Car c in carDAO.GetAllCars())
            {
                dataCarView.Rows.Add(c.Make, c.Color, c.Petname, "Detail");
            }
            labelNumberOfCars.Text = $"The number of cars: {carDAO.GetAllCars().Count}";
        }
        //Load data for CarGUI for Admin
        private void LoadAdminView()
        {
            CreateMainView();
            // add admin button
            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.HeaderText = "Edit";
            dataCarView.Columns.Add(colEdit);
            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.HeaderText = "Delete";
            dataCarView.Columns.Add(colDelete);
            foreach (Car c in carDAO.GetAllCars())
            {
                dataCarView.Rows.Add(c.Make, c.Color, c.Petname, "Detail", "Edit", "Delete");
            }
            labelNumberOfCars.Text = $"The number of cars: {carDAO.GetAllCars().Count}";
            loginToolStripMenuItem.Text = $"logout ({role})";
        }

        // Refresh Car data grid view
        private void RefreshDataCarView()
        {
            dataCarView.Rows.Clear();
            dataCarView.Columns.Clear();
            LoadAdminView();
            
        }
        
        // Load CarGUI
        private void CarGUI_Load(object sender, EventArgs e)
        {
            if (accountDAO.GetRole() == "admin")
            {
                LoadAdminView();
            }
            else
            {
                LoadCustomerView();
            }

        }

        // button add new...
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CarAddEditGUI carAddEditGUI = new CarAddEditGUI();
            carAddEditGUI.UnableInputCardID();
            carAddEditGUI.SetIdToAdd();
            carAddEditGUI.ShowDialog();
            RefreshDataCarView();
        }

        // click login - logout
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountDAO.GetRole() == "admin")
            {
                this.Hide();
                accountDAO.Logout();
                CarGUI carGUI = new CarGUI(accountDAO.GetRole());
                carGUI.Show();
                //LoginGUI loginGUI = new LoginGUI();
                //loginGUI.Close();
            }
            else
            {
                this.Hide();
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.ShowDialog();
                loginGUI.FormClosed += (s, args) => this.Show();
            }
        }

        private void CarGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng ứng dụng khi người dùng bấm X
                Application.Exit();
            }
        }
    }
}
