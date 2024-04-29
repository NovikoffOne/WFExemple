using MySql.Data.MySqlClient;

namespace WF
{
    public partial class RegisterForm : Form
    {
        private const string LOG_TEXT_BASE = "Log";
        private const string PASS_TEXT_BASE = "Password";
        private const string NAME_TEXT_BASE = "Name";
        private const string SURNAME_TEXT_BASE = "Last Name";

        private WindowInteractUtils _interactService;

        public RegisterForm()
        {
            InitializeComponent();
            _interactService = new WindowInteractUtils(this);
        }

        private void Background_Paint(object sender, PaintEventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
            => Application.Exit();

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }



        private void Pass_Enter(object sender, EventArgs e)
        {
            var textValue = PASS_TEXT_BASE;

            if (Pass.Text == textValue)
                _interactService.ResetText(Pass, textValue);
        }

        private void UserLastNameInput_Enter(object sender, EventArgs e)
        {
            var textValue = SURNAME_TEXT_BASE;

            if (UserLastNameInput.Text.Equals(textValue))
                _interactService.ResetText(UserLastNameInput, textValue);
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            var textValue = LOG_TEXT_BASE;

            if (UserName.Text.Equals(textValue))
                _interactService.ResetText(UserName, textValue);
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text.Equals(string.Empty))
                _interactService.SetBaseText(UserName);
        }

        private void UserNameInput_Leave(object sender, EventArgs e)
        {
            if (UserNameInput.Text.Equals(string.Empty))
                _interactService.SetBaseText(UserNameInput);
        }

        private void UserNameInput_Enter(object sender, EventArgs e)
        {
            var textValue = NAME_TEXT_BASE;

            if (UserNameInput.Text.Equals(textValue))
                _interactService.ResetText(UserNameInput, textValue);
        }

        private void UserLastNameInput_Leave(object sender, EventArgs e)
        {
            if (UserLastNameInput.Text.Equals(string.Empty))
                _interactService.SetBaseText(UserLastNameInput);
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text.Equals(string.Empty))
                _interactService.SetBaseText(Pass);
        }

        private void EnterRegister_Click(object sender, EventArgs e)
        {
            var isInputNotEmpty = TryInputNotEmpty(UserName.Text)
                && TryInputNotEmpty(Pass.Text)
                && TryInputNotEmpty(UserNameInput.Text)
                && TryInputNotEmpty(UserLastNameInput.Text);

            if (!isInputNotEmpty)
            {
                MessageBox.Show("заполните поля");
                return;
            }

            if (_interactService.TryUserExist(UserName.Text))
            {
                MessageBox.Show("Логин занят!");
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`) VALUES (NULL, @Login, @Pass, @Name, @Surname)", db.GetConnecton());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = Pass.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = UserNameInput.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = UserLastNameInput.Text;

            db.OpenConnection();
            
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не создан");

            db.CloseConnection();
        }

        private bool TryInputNotEmpty(String text)
        {
            switch (text)
            {
                case LOG_TEXT_BASE:
                case NAME_TEXT_BASE:
                case PASS_TEXT_BASE:
                case SURNAME_TEXT_BASE:
                case "":
                    return false;
            }

            return true;
        }
    }
}
