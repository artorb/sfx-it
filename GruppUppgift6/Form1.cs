using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using GruppUppgift6.Properties;

namespace GruppUppgift6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IList<string> crimes = new ReadOnlyCollection<string>(
                new List<string>
                {
                    "Våldtäkt", "Mord", "Stöld", "Rån"
                });

            _reports = new List<Report>();
            lsbxCrimes.DataSource = crimes;
        }

        private readonly List<Report> _reports;
        private static Report _curReport;

        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            _reports.Add(new Report(
                new Perpetrator(tbxName.Text, tbxSex.Text, tbxAge.Text, tbxHeight.Text, tbxHair.Text),
                lsbxCrimes.SelectedItem.ToString()));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsbxSearchRes.Items.Clear();
            foreach (var report in _reports.FindAll(rep => rep.Perpetrator.Equals(tbxSearch.Text)))
                lsbxSearchRes.Items.Add(report);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_curReport == null) return;
            var rep = _curReport;
            rep.Crime = lsbxCrimes.SelectedItem.ToString();
            rep.Perpetrator.Age = tbxAge.Text;
            rep.Perpetrator.Height = tbxHeight.Text;
            rep.Perpetrator.Name = tbxName.Text;
            rep.Perpetrator.Sex = tbxSex.Text;
            rep.Perpetrator.HairColor = tbxHair.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbxSearchRes.Items.Clear();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (!(lsbxSearchRes.SelectedItem is Report rep)) return;
            _curReport = null;
            _curReport = rep;
            tbxAge.Text = rep.Perpetrator.Age;
            tbxHair.Text = rep.Perpetrator.HairColor;
            tbxHeight.Text = rep.Perpetrator.Height;
            tbxName.Text = rep.Perpetrator.Name;
            tbxSex.Text = rep.Perpetrator.Sex;
        }
    }
}