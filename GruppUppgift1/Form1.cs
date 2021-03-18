using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string CustomerName => tbxCustomerName.Text;
        private string Destination => tbxDestination.Text;
        private string AmountDays => tbxDays.Text;
        private string SearchName => tbxSearchName.Text;

        private readonly Dictionary<string, Customer>
            _customers = new Dictionary<string, Customer>();

        private static bool ValidateData(params string[] text)
        {
            return text.All(t => !string.IsNullOrWhiteSpace(t));
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (ValidateData(CustomerName, Destination, AmountDays))
            {
                if (!_customers.ContainsKey(CustomerName))
                {
                    var destinationsList = new List<string> {Destination};
                    var daysList = new List<int> {Convert.ToInt32(AmountDays)};
                    _customers.Add(CustomerName, new Customer(destinationsList, daysList));
                    /*  _customers.Add(CustomerName, new Customer(new List<string> {Destination}, new List<int>{AmountDays}));
                     less readability */
                }
                else
                {
                    var existingCustomer = _customers.FirstOrDefault(t => t.Key.Equals(CustomerName));
                    existingCustomer.Value.Destinations.Add(Destination);
                    existingCustomer.Value.AmountDays.Add(Convert.ToInt32(AmountDays));
                }

                MessageBox.Show(@"Klart!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(@"Snälla, fyll i fälten.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            lsbxResult.Items.Clear();
            // check that a customer can be found!
            if (_customers.ContainsKey(SearchName))
            {
                var foundCustomer = _customers.FirstOrDefault(k => k.Key.Equals(SearchName));
                var length = foundCustomer.Value.Destinations.Count;

                for (var i = 0; i < length; i++)
                {
                    lsbxResult.Items.Add(foundCustomer.Value.Destinations[i] + ": " +
                                         foundCustomer.Value.AmountDays[i] + " dagar");
                }
            }
            else
                MessageBox.Show(@"Finns inte!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}