using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Uppgift5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Customer> _customers = new List<Customer>();

        private void btnPut_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxKund.Text) || string.IsNullOrEmpty(tbxTid.Text)) return;
            
            var customer = new Customer(tbxKund.Text, int.Parse(tbxTid.Text));
            _customers.Add(customer);
            lstRes.Items.Add(customer);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstRes.SelectedItem is Customer customer) customer.CustomerName = tbxNewName.Text;
            lstRes.Items.Clear();
            foreach (var cust in _customers)
            {
                lstRes.Items.Add(cust);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(!(lstRes.SelectedItem is Customer customer)) return;
            
            if(string.IsNullOrEmpty(tbxWorth.Text)) return;
            
            var worth = int.Parse(tbxWorth.Text);
            var result = (worth / 2.0) * (customer.Time / 30);
            tbxPrice.Text = result.ToString();
        }

        private void lstRes_Click(object sender, EventArgs e)
        {
            if(!(lstRes.SelectedItem is Customer customer)) return;
            tbxOldName.Text = customer.CustomerName;
        }
    }

    internal class Customer
    {
        public string CustomerName { get; set; }

        public int Time { get; }

        public Customer(string customerName, int time)
        {
            CustomerName = customerName;
            check_time(ref time);
            Time = time;
        }

        private static void check_time(ref int time)
        {
            if (time % 30 == 0) return;
            while (time % 30 != 0)
            {
                time++;
            }
        }

        public override string ToString()
        {
            return CustomerName + ": " + Time + " min.";
        }
    }
}