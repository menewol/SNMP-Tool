using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SNMP
{
    
    class Snmp
    {
        Socket s;
        byte[] Version = new byte[4];
        public string CommunityName;

        public Snmp(string communityName)
        {
            /* only version number 2 is supported */
            Version[3] = 0x02;
            CommunityName = communityName;
        }

        public void ListenForTraps()
        {
            
        }
    }
}
