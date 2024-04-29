using MySql.Data.MySqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WF
{
    public class WindowInteractUtils
    {
        private Color _exitButtonBackgroundColorBase;
        private Point _lastPoint;
        private Form _form;
        private string _textValue;

        public WindowInteractUtils(Form form)
        {
            _form = form;
        }

        public void ChangeExitButtonBackground(Label label)
        {
            _exitButtonBackgroundColorBase = label.BackColor;
            label.BackColor = Color.Red;
        }
        
        public void SetBaseColorExitButtonBackground(Label label)
        {
            label.BackColor = _exitButtonBackgroundColorBase;
        }

        public void SavePosition(MouseEventArgs e)
        {
            _lastPoint = e.Location;
        }

        public void MouseMove(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _form.Left += e.X - _lastPoint.X;
            _form.Top += e.Y - _lastPoint.Y;
        }

        public void ResetText(TextBox textBox, string text)
        {
            _textValue = text;
            textBox.ResetText();
        }

        public void SetBaseText(TextBox textBox)
        {
            textBox.Text = _textValue;
        }

        public bool TryUserExist(string loginUser)
        {
            DB db = new();
            DataTable table = new();
            MySqlDataAdapter adapter = new();

            MySqlCommand command = new($"SELECT * FROM `users` WHERE `login` = @uL", db.GetConnecton());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
