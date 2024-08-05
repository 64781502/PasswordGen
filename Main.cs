using PasswordGen.Enums;
using System;
using System.Net;

namespace PasswordGen
{
    public partial class Main : Form
    {
        private PasswordManager _manager;

        public Main()
        {
            InitializeComponent();
            _manager = new();
        }

        private void _length_slider_Scroll(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLabelText();
            _output_box.Text = string.Empty; // smazat
            _password_strength.Text = $"Password strength: {PasswordStrength.Blank}";
        }

        private void ChangeLabelText()
        {
            _length_slider_label.Text = $"Password length: {_length_slider.Value}";
        }

        private void _generate_button_Click(object sender, EventArgs e)
        {
            GenerateAPassword();
        }

        private void GenerateAPassword()
        {
            Password password = new(
                Convert.ToUInt16(_length_slider.Value),
                _include_numbers_checkbox.Checked,
                _include_lowercase_checkbox.Checked,
                _include_uppercase_checkbox.Checked,
                _include_sc_checkbox.Checked,
                _start_with_letter_checkbox.Checked,
                _include_sc_textbox);

            _output_box.Text = password.Value;
            _output_box.SelectAll();
            _output_box.SelectionAlignment = HorizontalAlignment.Center;
            _manager.passwords.Add(password);
            _password_strength.Text = $"Password strength: {_manager.CalculatePasswordStrength(_include_numbers_checkbox.Checked, _include_sc_checkbox.Checked)}";
        }

        private void _include_sc_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_include_sc_checkbox.Checked)
            {
                _include_sc_textbox.Visible = true;
            }
            else
            {
                _include_sc_textbox.Visible = false;
            }
        }
    }
}
