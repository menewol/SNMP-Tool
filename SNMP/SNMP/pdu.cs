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
            GetRequest, GetNextRequest, Response, SetRequest, GetBulkRequest, InformRequest, Trapv2, Report
        }

        byte[] requestID = new byte[4];
        byte[] errorStatus = new byte[4];
        byte[] errorIndex = new byte[4];
        byte[] pduType = new byte[4];
        byte[] Oid;
        byte[] Oid_value;


        public Pdu(PduType MessageType, string Oid, string value)
        {
            Random rnd = new Random();
            rnd.NextBytes(requestID);
            errorStatus = null;
            errorIndex = null;

            switch (MessageType)
            {
                case PduType.GetRequest:
                    pduType[3] = 0x00;
                    break;
                case PduType.GetNextRequest:
                    pduType[3] = 0x01;
                    break;
                case PduType.Response:
                    pduType[3] = 0x02;
                    break;
                case PduType.SetRequest:
                    pduType[3] = 0x03;
                    Oid_value = Encoding.ASCII.GetBytes(value);

                    break;
                case PduType.GetBulkRequest:
                    pduType[3] = 0x05;
                    break;
                case PduType.InformRequest:
                    pduType[3] = 0x06;
                    break;
                case PduType.Trapv2:
                    pduType[3] = 0x07;
                    break;
                case PduType.Report:
                    pduType[3] = 0x08;
                    break;
            }
        }
        public byte[] ToArray()
        {
            return null;
        }
    }
}
