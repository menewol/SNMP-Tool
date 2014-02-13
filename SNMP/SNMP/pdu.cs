using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    class Pdu

    {
        public enum PDUType
        {
            GetRequest, GetNextRequest, Response, SetRequest, GetBulkRequest, InformRequest,Trapv2,Report
        }
        byte[] requestID = new byte[4];
        byte[] errorStatus = new byte[4];
        byte[] errorIndex = new byte[4];
        byte[] pduType = new byte[4];
        byte[] pdu;


        public Pdu(PDUType MessageType)

        {
            Random rnd = new Random();
            rnd.NextBytes(requestID);
            errorStatus = null;
            errorIndex = null;
            switch (MessageType)
            {
                case PDUType.GetRequest:
                    pduType[3] = 0;
                    break;
                case PDUType.GetNextRequest:
                    pduType[3] = 1;
                    break;
                case PDUType.Response:
                    pduType[3] = 2;
                    break;
                case PDUType.SetRequest:
                    pduType[3] = 3;
                    break;
                case PDUType.GetBulkRequest:
                    pduType[3] = 5;
                    break;
                case PDUType.InformRequest:
                    pduType[3] = 6;
                    break;
                case PDUType.Trapv2:
                    pduType[3] = 7;
                    break;
                case PDUType.Report:
                    pduType[3] = 8;
                    break;
            }
        }
    }
}
