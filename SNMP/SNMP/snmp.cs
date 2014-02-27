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
        Pdu pdu;
        byte[] version = new byte[4];
        public string communityName;

        public Snmp(string communityName, Pdu.PduType type, string Oid)
        {
            /* only version number 2 is supported */
            version[3] = 0x02;
            this.communityName = communityName;
            pdu = new Pdu(type, Oid);
        }

        public byte[] ToArray()
        {
            /* convert to object into a byte[] */
            return null;
        }
    }
}
