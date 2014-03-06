using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;

namespace SNMP
{
    
    class Snmp
    {
        Socket s;
        Pdu pdu;
        byte[] version = new byte[4];
        string communityName;

        public Snmp(string communityName, Pdu.PduType type, string oid, string octetString)
        {
            /* only version number 2 is supported */
            version[3] = 0x02;
            this.communityName = communityName;
            pdu = new Pdu(type, oid);
        }

        public byte[] ToArray(Snmp obj)
        {
            /* converts an SNMP object into a byte[] */


            return null;
        }
    }
}
