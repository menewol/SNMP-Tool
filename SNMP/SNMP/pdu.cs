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
        byte[] oid;
        byte[] value;
        int pduLength = 16;

        public Pdu(PduType messageType, string oid, string value)
        {
            Random rnd = new Random();
            rnd.NextBytes(requestID);
            this.oid = Encoding.Default.GetBytes(oid);

            switch (messageType)
            {
                case PduType.GetRequest:
                    pduType[3] = 0x00;
                    pduLength += oid.Length;
                    break;
                case PduType.GetNextRequest:
                    pduType[3] = 0x01;
                    break;
                case PduType.Response:
                    pduType[3] = 0x02;
                    break;
                case PduType.SetRequest:
                    pduType[3] = 0x03;
                    this.value = Encoding.ASCII.GetBytes(value);
                    pduLength += oid.Length + value.Length;
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
            byte[] returnArray = new byte[pduLength];

            Buffer.BlockCopy(pduType, 0, returnArray, 0, pduType.Length);
            Buffer.BlockCopy(requestID, 0, returnArray, 4, requestID.Length);
            Buffer.BlockCopy(errorStatus, 0, returnArray, 8, errorStatus.Length);
            Buffer.BlockCopy(errorIndex , 0, returnArray, 12, errorIndex.Length);
            Buffer.BlockCopy(oid, 0, returnArray, 16, oid.Length);
            Buffer.BlockCopy(value, 0, returnArray, 16 + oid.Length, value.Length);

            return returnArray;
        }
    }
}
