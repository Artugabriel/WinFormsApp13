using WinFormsApp13.Usercontrol;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            UserControl1 uc = new UserControl1();
            AddUserControl(uc);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            AddUserControl(uc);
        }

        private void btnSaude_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new UserControl2();
            AddUserControl(uc);
        }

        private void btnSintomas_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            AddUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DateTime timer;
        private void timerHora_Tick(object sender, EventArgs e)
        {
            timer = DateTime.Now;
            label1.Text = timer.ToLocalTime().ToString();
        }
    }
}
