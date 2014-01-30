using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    
    class snmp
    {
        const string CommunityString = "ntma_snmp";
        byte[] version = new byte[4];
        private snmp(int versionNumber)
        {
            version = Encoding.Default.GetBytes(versionNumber.ToString());
        }

    }

}
