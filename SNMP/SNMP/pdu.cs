using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    class pdu
    {
        public enum PDUType
        {
            GetRequest, GetNextRequest,Response,SetRequest,GetBulkRequest
        }
        public pdu()
        { 
            
        }
    }
}
