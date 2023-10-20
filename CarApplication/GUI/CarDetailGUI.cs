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
    public partial class CarDetailGUI : Form
    {
        private Car car;
        public CarDetailGUI()
        {
            InitializeComponent();
        }
        public CarDetailGUI(Car car)
        {
            this.car = car;
            InitializeComponent();
        }

        private void LoadData(Car car)
        {
            textCarID.Text = car.Id.ToString();
            textColor.Text = car.Color.ToString();
            textMake.Text = car.Make.ToString();
            textPetname.Text = car.Petname.ToString();
            try
            {
                carColor.BackColor = Color.FromName(car.Color);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarDetailGUI_Load(object sender, EventArgs e)
        {
            LoadData(car);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}




