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
        byte[] communityName;

        public Snmp(string communityName, Pdu.PduType type, string oid, string value)
        {
            /* only version number 2 is supported */
            version[3] = 0x02;
            this.communityName = Encoding.Default.GetBytes(communityName);
            pdu = new Pdu(type, oid, value);
        }

        public byte[] ToArray()
        {
            /* converts an SNMP object into a byte[] */

            byte[] pdu = this.pdu.ToArray();
            byte[] returnArray = new byte[version.Length + communityName.Length + pdu.Length];
            /* insert version code (is always 2) */
            Buffer.BlockCopy(version, 0, returnArray, 0, 4);
            /* insert the community name */
            Buffer.BlockCopy(communityName, 0, returnArray, 4, communityName.Length);
            /* insert pdu fields */
            Buffer.BlockCopy(pdu, 0, returnArray, 0, pdu.Length);

            return returnArray;
        }
    }
}
