using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SNMP
{
    class SnmpServices
    {
        Socket s;
        Snmp snmp;

        public string Get(string communityName, string oid)
        {
            snmp = new Snmp(communityName, Pdu.PduType.GetRequest, oid, null);
            byte[] data = snmp.ToArray();
            
            /* send request on port 161 */

            /* returns the value for the requested oid */
            return null;
        }

        public string GetNext(string communityName, string oid)
        {
            /* send request on port 161 */

            /* returns the value for the requested oid */
            return null;
        }

        public byte[] Set(string communityName, string oid, string value, IPAddress address)
        { 
            /* sets the entry with the given oid */
            snmp = new Snmp(communityName, Pdu.PduType.SetRequest, oid, value);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint endp = new IPEndPoint(address, 161);
            /* send the snmp set request */
            s.SendTo(snmp.ToArray(), endp);

            Console.WriteLine("Bin da");

            byte[] buffer = new byte[1024];
            /* receive the answer */
            s.ReceiveFrom(buffer, ref endp);

            return buffer;
        }

        public void ListenForTraps()
        {
            /* listen on port 162 */

            /* while(listening)
             *     return all informations to the console */
        }
    }
}
