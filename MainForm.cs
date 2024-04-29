using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class MainForm : Form
    {
        private RegisterForm _registerForm;
        private LoginWindow _loginForm;
        private bool _isSign = false;

        public MainForm()
        {
            InitializeComponent();

            _registerForm = new RegisterForm();
            _loginForm = new LoginWindow(_registerForm);

            _loginForm.Show();

            _registerForm.Hide();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (_isSign)
                MessageBox.Show("Вы уже вошли");
            else
            {
                _loginForm.Show();
                Hide();
            }
        }

        private void Registry_Click(object sender, EventArgs e)
        {
            if (_isSign)
                MessageBox.Show("Вы уже вошли");
            else
            {
                _registerForm.Show();
                Hide();
            }
        }
    }
}
