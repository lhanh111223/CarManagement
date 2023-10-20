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
    public partial class CarAddEditGUI : Form
    {
        private CarDAO carDAO = new CarDAO();
        CarGUI carGUI = new CarGUI();
        private Car car;
        public CarAddEditGUI()
        {
            InitializeComponent();
        }

        public CarAddEditGUI(Car carClicked)
        {
            InitializeComponent();
            Car car = carDAO.GetCarById(carClicked.Id);
            textCarID.Text = car.Id.ToString();
            textMake.Text = car.Make;
            textPetName.Text = car.Petname;
            textColor.Text = car.Color;
            carColor.BackColor = Color.FromName(textColor.Text);
            UnableInputCardID();
        }

        // unable textbox CarId and Background Color
        public void UnableInputCardID()
        {
            // unable to input to Textbox carId
            textCarID.Enabled = false;
            // unable to input into textbox to represent color
            carColor.ReadOnly = true;
        }
        // set id = -1 when 'Add new...'
        public void SetIdToAdd()
        {
            //set id = -1 to add
            textCarID.Text = "-1";
        }
        private void TextColor_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (textColor.Text != null && textColor.Text.Trim() != "")
                    carColor.BackColor = Color.FromName(textColor.Text);
            }
            catch
            {
                MessageBox.Show("Invalid color name, try again");
            }
        }
        private void CarAddEditGUI_Load(object sender, EventArgs e)
        {
            //if(car != null)
            //{
            //    textCarID.Text = car.Id.ToString();
            //    textMake.Text = car.Make;
            //    textPetName.Text = car.Petname;
            //    textColor.Text = car.Color;
            //    carColor.BackColor = Color.FromName(textColor.Text);
            //    UnableInputCardID();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textCarID.Text);
            string make = textMake.Text;
            string color = textColor.Text;
            string petname = textPetName.Text;
            if (id == -1)
            {
                if (make.Length < 1 || petname.Length < 1 || color.Length < 1)
                {
                    MessageBox.Show("Please fill all blank");
                }
                else
                {
                    carDAO.AddCar(new Car { Make = make, Color = color, Petname = petname });
                    MessageBox.Show("A new Car is added");
                    this.Close();
                }
            }
            else
            {
                if (make.Length < 1 || petname.Length < 1 || color.Length < 1)
                {
                    MessageBox.Show("Please fill all blank");
                }
                else
                {
                    carDAO.UpdateCar(new Car { Id = id, Make = make, Color = color, Petname = petname });
                    MessageBox.Show("This Car is updated!");
                    this.Close();
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
