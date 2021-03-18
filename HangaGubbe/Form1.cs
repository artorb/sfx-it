using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HangaGubbeUppg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _visaWord = "??????";
        private int _koef = 10;
        private string _gissaWord = "";
        private readonly Point _initPos = new Point(75, 41);

        private void tbxSvar_TextChanged(object sender, EventArgs e)
        {
            if (tbxSvar.Text.Length != tbxSvar.MaxLength) return;
            _gissaWord = tbxSvar.Text;
            tbxSvar.Clear();
            checkHardM.Enabled = false;
            tbxSvar.Enabled = false;
            tbxGissa.Enabled = true;
            tbxGissa.Focus();
        }

        private void tbxGissa_TextChanged(object sender, EventArgs e)
        {
            tbxVisa.Text = _visaWord;
            if (string.IsNullOrEmpty(tbxGissa.Text)) return;

            if (_gissaWord.Contains(tbxGissa.Text))
            {
                if (tbxVisa.Text.Contains("?"))
                {
                    var indices = IndicesOf(_gissaWord, tbxGissa.Text);
                    foreach (var index in indices)
                    {
                        var temp = _visaWord.Remove(index, 1);
                        _visaWord = temp.Insert(index, tbxGissa.Text);
                    }

                    tbxVisa.Text = _visaWord;
                    tbxGissa.Clear();
                    if (!tbxVisa.Text.Contains("?"))
                    {
                        MessageBox.Show("Du vann", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxGissa.Enabled = false;
                    }
                }
            }
            else
            {
                pbxGubbe.Location = new Point(pbxGubbe.Location.X, pbxGubbe.Location.Y + _koef);
                if (pbxGubbe.Bottom < pbxMark.Top) return;
                MessageBox.Show("Du förlorade", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnBörjaOm_Click(new object(), new EventArgs());
            }
        }

        private void tbnBörjaOm_Click(object sender, EventArgs e)
        {
            tbxSvar.Visible = true;
            tbxSvar.Enabled = true;
            tbxGissa.Enabled = false;
            tbxGissa.Clear();
            tbxSvar.Clear();
            _gissaWord = "";
            _visaWord = "??????";
            pbxGubbe.Location = _initPos;
            checkHardM.Enabled = true;
            tbxVisa.Text = "";
            tbxSvar.Focus();
        }

        private static IEnumerable<int> IndicesOf(string str, string searchstring)
        {
            var minIndex = str.IndexOf(searchstring, StringComparison.InvariantCultureIgnoreCase);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length,
                    StringComparison.InvariantCultureIgnoreCase);
            }
        }

        private void checkHardM_CheckedChanged(object sender, EventArgs e)
        {
            _koef = _koef == 10 ? 20 : 10;
        }

        private void ValidateLowerCase(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLower(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }
    }
}