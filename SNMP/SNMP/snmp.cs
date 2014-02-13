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
        byte[] version = new byte[4];        

        public Snmp()
        {
            version[3] = 2;
        }

        public void ListenForTraps(IPAddress address)
        { 
            
        }
    }
}
