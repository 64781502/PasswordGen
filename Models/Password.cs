namespace PasswordGen.Models
{
    public class Password
    {

        private ushort _length;
        private bool _include_numbers;
        private bool _include_lowercase;
        private bool _include_uppercase;
        private bool _begin_with_a_letter;
        private bool _include_special_characters;

        public string? Value { get; private set; }

        // const string ASCII = @"!#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]\^_`abcdefghijklmnopqrstuvwxyz{|}~";
        private const string ASCII_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string ASCII_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMS = "0123456789";
        private const string LETTERS_ONLY = ASCII_LOWERCASE + ASCII_UPPERCASE;

        private string _special_chars;


        public Password(ushort length, bool include_numbers, bool include_lowercase, bool include_uppercase, bool include_special_characters, bool begin_with_a_letter, TextBox sc_box)
        {
            _length = length;
            _include_numbers = include_numbers;
            _include_lowercase = include_lowercase;
            _include_uppercase = include_uppercase;
            _include_special_characters = include_special_characters;
            _begin_with_a_letter = begin_with_a_letter;
            _special_chars = sc_box.Text;

            GeneratePassword();
        }

        private void GeneratePassword()
        {
            string? password = string.Empty;

            Random random = new();

            string CHARSET = string.Empty;

            #region query generator

            if (_include_numbers) { CHARSET += NUMS; }
            if (_include_lowercase) { CHARSET += ASCII_LOWERCASE; }
            if (_include_uppercase) { CHARSET += ASCII_UPPERCASE; }
            if (_include_special_characters) { CHARSET += _special_chars; }

            #endregion

            if (!string.IsNullOrEmpty(CHARSET))
            {
                for (int i = 0; i < _length; i++)
                {
                    if (_begin_with_a_letter && i == 0)
                    {
                        password += LETTERS_ONLY[random.Next(LETTERS_ONLY.Length)];
                        continue;
                    }

                    password += CHARSET[random.Next(CHARSET.Length)];
                }

                Value = password;
            }
            else
            {
                Value = "(empty)";
            }
        }
    }
}
