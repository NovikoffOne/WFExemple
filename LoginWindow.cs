using MySql.Data.MySqlClient;
using System.Data;

namespace WF
{
    public partial class LoginWindow : Form
    {
        private RegisterForm _registerForm;
        private WindowInteractUtils _interactService;

        public LoginWindow(RegisterForm registerForm)
        {
            InitializeComponent();
            _registerForm = registerForm;

            _interactService = new WindowInteractUtils(this);

            Pass.Height = UserName.Height;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Header_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            _interactService.ChangeExitButtonBackground(Exit);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            _interactService.SetBaseColorExitButtonBackground(Exit);
        }

        private void Background_MouseMove(object sender, MouseEventArgs e)
            => _interactService.MouseMove(e);

        private void Background_MouseDown(object sender, MouseEventArgs e)
            => _interactService.SavePosition(e);

        private void EnterButton_Click(object sender, EventArgs e)
        {
            String loginUser = UserName.Text;
            String passUser = Pass.Text;

            DB db = new();
            DataTable table = new();
            MySqlDataAdapter adapter = new();

            MySqlCommand command = new($"SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnecton());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }

        private void RegistryButton_Click(object sender, EventArgs e)
        {
            _registerForm.Show();
            Hide();
        }
    }
}
