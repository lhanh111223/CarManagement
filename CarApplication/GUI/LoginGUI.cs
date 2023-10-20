using CarApplication.DAL;
using CarApplication.GUI;
using CarApplication.Model;


namespace CarApplication
{

    public partial class LoginGUI : Form
    {
        private AccountDAO accountDAO = new AccountDAO();
        Account account = new Account();
        CarGUI carGUI = new CarGUI();

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        // button Login Click in Login GUI
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (accountDAO.Login(username, password))
            {
                this.Hide();
                carGUI.role = "admin";
                carGUI.Show();

            }
            else
            {
                MessageBox.Show("Username or Password is not correct !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button Cancel in Login GUI
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
            carGUI.Show();
        }

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //CarGUI carGUI = new CarGUI();   
                if (carGUI != null && !carGUI.IsDisposed && carGUI.Visible)
                {
                    this.Close();
                }
                else
                {
                    carGUI.Show();
                }
            }
        }
    }
}