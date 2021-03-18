using System.Windows.Forms;

namespace GruppUppgift3
{
    public partial class Form1 : Form
    {
        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }
    }
}