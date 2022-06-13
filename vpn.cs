using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace vpn {
    public class VPN {
        private const string EntryName = "VPN Connection";

        private RasHandle handle = null;
        private RasPhoneBook AllUsersPhoneBook;
        public RasDialer Dialer;

        public enum status { Default, Connection, Error, TimeOut }
        public int VPN_Status { get; set; }

        public void VPN_Connection(string VPN_Name, string VPN_ID, string VPN_PW) {
            AllUsersPhoneBook = new RasPhoneBook();
            AllUsersPhoneBook.Open();
        }
    }
}