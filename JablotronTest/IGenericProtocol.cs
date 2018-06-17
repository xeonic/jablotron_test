using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JablotronTest
{
    public enum OutCmd : byte { Read = 0x10, Write = 0x21 }
    public enum InCmd : byte { State = 0x01, ReadOk = 0x11, ReadErr = 0x12, WriteOk = 0x21 }
    public enum State : byte { Ok = 0x01, Err = 0x02, Unk = 0xFF }
    public enum Type : byte { Bool = 0x01, Int8 = 0x10, Int16 = 0x11, Str = 0x20 }
    public enum Err : byte { Ok = 0x00, IdNok = 0x10, TypeErr = 0x20, DataCntErr = 0x80, Unk = 0xFF }

    public interface IGenericProtocol
    {
        //start of packet
        byte Sop { get; }
        //end of packet
        byte Eop { get; }

        //need to be implemented with selected communication interface
        void SendMessage(byte[] bytes); 
        byte[] ReciveMessage();

        //generates an array of bytes to be sended to communication port
        byte[] GenerateMessage(OutCmd cmd, object data);

        //parses an array of byted recieved to communication port 
        object ParseMessage(byte[] bytes);

        //computing of CRC16 CCITT
        byte[] ComputeCrc(byte[] bytes);

        //check of correct crc
        bool CheckCrc(byte[] bytes, byte[] crc);
    }
}
