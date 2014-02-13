using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SNMP
{
    
    class snmp
    {
        const string CommunityString = "ntma_snmp";
        byte[] version = new byte[4];
        Socket s;

        public snmp(int versionNumber)
        {
            if (versionNumber <= 3)
            {
                version = BitConverter.GetBytes(versionNumber);
            }
        }


    }
}
