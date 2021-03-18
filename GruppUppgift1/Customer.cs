using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public class Customer
    {
        /* can also store CustomerName in case of extension */
        public List<string> Destinations { get; private set; }
        public List<int> AmountDays { get; private set; }

        public Customer(List<string> destinations, List<int> amountDays)
        {
            Destinations = destinations;
            AmountDays = amountDays;
        }
    }
}