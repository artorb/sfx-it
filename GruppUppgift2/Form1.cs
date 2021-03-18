using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GruppUppgift2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ShooterName => tbxName.Text;
        private string Points => tbxPoints.Text;
        private int SearchPoints => Convert.ToInt32(tbxSearch.Text);

        private readonly Dictionary<string, int> _shooters = new Dictionary<string, int>();

        private static bool ValidateData(string name, string points)
        {
            return name.All(char.IsLetter) && points.All(char.IsDigit) && Convert.ToInt32(points) <= 50 &&
                   Convert.ToInt32(points) > 0;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (ValidateData(ShooterName, Points))
            {
                _shooters.Add(ShooterName, Convert.ToInt32(Points));
                MessageBox.Show(@"Resultat registrerat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(@"Snälla, fyll i korrekt information", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lsbxresult.Items.Clear();
            if (_shooters.ContainsValue(SearchPoints))
            {
                var found = _shooters.Where(shooter => shooter.Value.Equals(SearchPoints)).Select(k => k.Key);
                foreach (var shooter in found)
                    lsbxresult.Items.Add(shooter);
            }
            else
                MessageBox.Show(@"Finns inte!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}