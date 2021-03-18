using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GruppUppgift3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Distance => Convert.ToInt32(tbxDistance.Text);
        private int TimeSpent => Convert.ToInt32(tbxTime.Text);
        private int SearchedDistance => Convert.ToInt32(tbxSearch.Text);

        private Dictionary<int, List<int>> _results = new Dictionary<int, List<int>>();

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (!_results.ContainsKey(Distance))
                _results.Add(Distance, new List<int> {TimeSpent});
            else
            {
                var stored = _results.FirstOrDefault(k => k.Key.Equals(Distance));
                stored.Value.Add(TimeSpent);
            }

            MessageBox.Show("Passet registrerat", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTider_Click(object sender, EventArgs e)
        {
            lsbxResult.Items.Clear();
            if (!_results.ContainsKey(SearchedDistance)) return;
            var found = _results.FirstOrDefault(k => k.Key.Equals(SearchedDistance));
            foreach (var time in found.Value)
                lsbxResult.Items.Add(time);
        }

        private void btnHastigheter_Click(object sender, EventArgs e)
        {
            lsbxResult.Items.Clear();
            if (!_results.ContainsKey(SearchedDistance)) return;
            var found = _results.FirstOrDefault(k => k.Key.Equals(SearchedDistance));
            var len = found.Value.Count;
            for (var i = 0; i < len; i++)
                lsbxResult.Items.Add(SearchedDistance / Convert.ToDouble(found.Value[i]) + " km/t");
        }
    }
}