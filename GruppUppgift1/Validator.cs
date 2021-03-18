using System.Windows.Forms;

namespace WindowsFormsApp3
{
    partial class Form1 : Form
    {
        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void ValidateAlphabetic(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }
    }
}