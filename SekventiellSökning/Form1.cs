using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Windows.Forms;

namespace SekventielUppgift2
{
    public partial class Form1 : Form
    {
        public static readonly Font ValFont = new Font("Times New Roman", 15);
        private static readonly Kortlek Lek = new Kortlek();

        private void Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pbx1_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[0].Rita(e.Graphics);
        }

        private void pbx2_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[1].Rita(e.Graphics);
        }

        private void pbx3_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[2].Rita(e.Graphics);
        }

        private void pbx4_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[3].Rita(e.Graphics);
        }

        private void pbx5_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[4].Rita(e.Graphics);
        }

        private void pbx6_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[5].Rita(e.Graphics);
        }

        private void pbx7_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[6].Rita(e.Graphics);
        }

        private void pbx8_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[7].Rita(e.Graphics);
        }

        private void pbx9_Paint(object sender, PaintEventArgs e)
        {
            Lek.Korten[8].Rita(e.Graphics);
        }

        private void btnBlanda_Click(object sender, EventArgs e)
        {
            Lek.Blanda();
            tbxSökVal.Enabled = true;
            btnSeqSök.Enabled = true;
            tbxIndex.Clear();
            RefreshAllPbx();
        }

        private void btnSeqSök_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSökVal.Text)) return;
            tbxSökVal.Enabled = false;
            var sök = tbxSökVal.Text;
            if (Lek.SekventiellSökSteg(int.Parse(sök)))
            {
                tbxIndex.Text = Lek.Index.ToString();
                btnSeqSök.Enabled = false;
            }

            RefreshAllPbx();
        }

        private void RefreshAllPbx()
        {
            pbx1.Refresh();
            pbx2.Refresh();
            pbx3.Refresh();
            pbx4.Refresh();
            pbx5.Refresh();
            pbx6.Refresh();
            pbx7.Refresh();
            pbx8.Refresh();
            pbx9.Refresh();
        }
    }

    public class Kort
    {
        private const int Bredd = 75;
        private const int Höjd = 102;

        private const int Margin = 15;
        public int Valör { get; set; }
        public bool VisaFramsida { get; set; }

        public Kort(int valör)
        {
            Valör = valör;
        }

        public void Rita(Graphics graphics)
        {
            var points = new[]
            {
                new Point(Margin, Höjd / 2), new Point(Bredd / 2, Margin), new Point(Bredd - Margin, Höjd / 2),
                new Point(Bredd / 2, Höjd - Margin)
            };
            var rödBörst = new SolidBrush(Color.DarkRed);
            var svartBörst = new SolidBrush(Color.Black);
            if (VisaFramsida)
            {
                graphics.Clear(Color.Azure);
                graphics.FillPolygon(rödBörst, points, FillMode.Winding);
                graphics.DrawString(Valör.ToString(), Form1.ValFont, svartBörst, 3, 3);
                graphics.DrawString(Valör.ToString(), Form1.ValFont, svartBörst, Bredd / 2 + 15, Höjd - 25);
            }
            else
            {
                graphics.Clear(Color.DarkRed);
            }
        }
    }

    public class Kortlek
    {
        private readonly Random _slump = new Random();

        private const int AntalKort = 9;
        public Kort[] Korten { get; } = new Kort[AntalKort];

        private static int _counter;
        public int Index { get; private set; }

        private bool _avbryt;


        public Kortlek()
        {
            for (var i = 0; i < AntalKort; i++)
            {
                Korten[i] = new Kort(i + 2);
            }

            _counter = 0;
            _avbryt = false;
            Index = -1;
        }

        public void Blanda()
        {
            for (var i = 0; i < AntalKort; i++)
            {
                var x = _slump.Next() % AntalKort;
                var y = Korten[x];
                Korten[x] = Korten[i];
                Korten[i] = y;
            }

            foreach (var kort in Korten)
            {
                kort.VisaFramsida = false;
            }

            _counter = 0;
            _avbryt = false;
            Index = -1;
        }


        public bool SekventiellSökSteg(int sökrValor)
        {
            while (_counter < AntalKort && !_avbryt)
            {
                Korten[_counter].VisaFramsida = true;
                if (Korten[_counter].Valör.Equals(sökrValor))
                {
                    _avbryt = true;
                    Index = _counter;
                    return true;
                }

                _counter++;
                break;
            }

            return false;
        }
    }
}