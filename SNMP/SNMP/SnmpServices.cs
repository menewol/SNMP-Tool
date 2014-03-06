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
            byte[] data = snmp.ToArray(snmp);
            
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

        public void Set(string communityName, string oid, string value)
        { 
            /* sets the entry with the given oid */
            snmp = new Snmp(communityName, Pdu.PduType.SetRequest, oid, value);
            
        }

        public void ListenForTraps()
        {
            /* listen on port 162 */

            /* while(listening)
             *     return all informations to the console */
        }
    }
}
