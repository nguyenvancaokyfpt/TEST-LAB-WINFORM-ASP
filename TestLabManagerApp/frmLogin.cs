using System.Runtime.InteropServices;
using TestLabLibrary.Repository;
using TestLabEntity.AutoDB;

namespace TestLabManagerApp
{
    public partial class frmLogin : Form
    {
        private IAdminRepository _adminRepository;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmLogin()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _adminRepository = new AdminRepository();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Login code here
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            TlAdmin admin = _adminRepository.Login(username, password);
            if (admin != null)
            {
                frmMain frmMain = new frmMain(admin);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void inputUsername_Enter(object sender, EventArgs e)
        {
            if (inputUsername.Text != "" && inputPassword.Text != "")
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            if (inputUsername.Text != "" && inputPassword.Text != "")
            {
                btnSignIn_Click(sender, e);
            }
        }
    }
}