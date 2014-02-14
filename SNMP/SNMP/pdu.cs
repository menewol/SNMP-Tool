using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    class Pdu
    {
        public enum PduType
        {
            GetRequest, GetNextRequest, Response, SetRequest, GetBulkRequest, InformRequest,Trapv2,Report
        }

        byte[] requestID = new byte[4];
        byte[] errorStatus = new byte[4];
        byte[] errorIndex = new byte[4];
        byte[] pduType = new byte[4];
        byte[] pdu;


        public Pdu(PduType MessageType)
        {
            Random rnd = new Random();
            rnd.NextBytes(requestID);
            errorStatus = null;
            errorIndex = null;

            switch (MessageType)
            {
                case PduType.GetRequest:
                    pduType[3] = 0;
                    break;
                case PduType.GetNextRequest:
                    pduType[3] = 1;
                    break;
                case PduType.Response:
                    pduType[3] = 2;
                    break;
                case PduType.SetRequest:
                    pduType[3] = 3;
                    break;
                case PduType.GetBulkRequest:
                    pduType[3] = 5;
                    break;
                case PduType.InformRequest:
                    pduType[3] = 6;
                    break;
                case PduType.Trapv2:
                    pduType[3] = 7;
                    break;
                case PduType.Report:
                    pduType[3] = 8;
                    break;
            }
        }
    }
}
