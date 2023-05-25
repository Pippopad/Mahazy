using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mahazy
{
    public static class Utils
    {
        public static string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mahazy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }

        public static bool IsStringValid(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }

        public static bool CheckStringMinLength(string s, int n)
        {
            return s.Length >= n;
        }

        public static bool CheckStringMaxLength(string s, int n)
        {
            return s.Length <= n;
        }

        public static bool CheckStringLength(string s, int mi, int ma)
        {
            return CheckStringMinLength(s, mi) && CheckStringMaxLength(s, ma);
        }

        public static void ShowInfo(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarn(string msg, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(msg, Application.ProductName, buttons, MessageBoxIcon.Warning);
        }

        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string CompressString(string s, int maxChars)
        {
            return s.Substring(0, maxChars - 3) + "...";
        }

        public static void CreateCredFile(string username, string password)
        {
            var credPath = Path.Combine(Application.ExecutablePath.Replace("Mahazy.exe", ""), "cred.dat");

            if (File.Exists(credPath)) File.Delete(credPath);

            using (var sw = new StreamWriter(credPath))
            {
                sw.Write($"{username}:{CreateMD5(password)}");
            }
        }

        public static void DeleteCredFile()
        {
            var credPath = Path.Combine(Application.ExecutablePath.Replace("Mahazy.exe", ""), "cred.dat");

            if (File.Exists(credPath)) File.Delete(credPath);
        }

        public static string ReadCredFile()
        {
            var credPath = Path.Combine(Application.ExecutablePath.Replace("Mahazy.exe", ""), "cred.dat");

            if (File.Exists(credPath))
            {
                string output;
                using (var sr = new StreamReader(credPath))
                {
                    output = sr.ReadToEnd();
                }
                return output;
            }

            return null;
        }
    }
}
