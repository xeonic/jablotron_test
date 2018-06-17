using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JablotronTest
{

    class GenericProtocol : IGenericProtocol
    {
        #region Fields
        #endregion Fields

        #region Properties
        public byte Sop { get; private set; }
        public byte Eop { get; private set; }
        #endregion Properties


        public GenericProtocol()
        {

        }

        public void SendMessage(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public byte[] ReciveMessage()
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateMessage(OutCmd cmd, object data)
        {
            throw new NotImplementedException();
        }

        public object ParseMessage(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public byte[] ComputeCrc(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public bool CheckCrc(byte[] bytes, byte[] crc)
        {
            throw new NotImplementedException();
        }
    }
}
