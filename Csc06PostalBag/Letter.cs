using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc06PostalBag
{
    internal class Letter
    {
        private bool _registered;
        public Letter(string sender, string receiver, bool registered = false)
        {
            Sender = sender;
            Receiver = receiver;
            Registered = registered;
            // Price = Registered ? 20 : 10;
        }

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public bool Registered {
            get { return _registered; }
            set { _registered = value; /* Price = Registered ? 20 : 10; */ }
        }
        public float Price { get { return Registered ? 20 : 10; } }
    }
}
