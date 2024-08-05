using PasswordGen.Enums;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Text.RegularExpressions;

namespace PasswordGen
{
    public class PasswordManager
    {
        public List<Password> passwords { get; set; }

        public PasswordManager()
        {
            passwords = new();
        }

        public PasswordStrength CalculatePasswordStrength(bool include_numbers, bool include_sc) // 0 - 100
        {
            Password latest_password = passwords.Last();
            int score = 0;

            if (include_numbers && include_sc)
            {
                score += 2;
            }
            else if (!include_numbers && include_sc)
            {
                score++;
            }
            else if (include_numbers && !include_sc)
            {
                score++;
            }            


            if (latest_password.Value! == "(empty)")
            {
                return PasswordStrength.Blank;
            }

            if (latest_password.Value!.Length > 4)
            {
                score++;
            }

            if (latest_password.Value!.Length > 8)
            {
                score++;
            }

            if (latest_password.Value!.Length >= 16)
            {
                score++;
            }

            return (PasswordStrength)score;
        }
    }
}
