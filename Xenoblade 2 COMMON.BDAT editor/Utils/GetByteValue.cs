using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenoblade_2_COMMON.BDAT_editor
{
    internal class GetByteValue
    {
        byte[] byte1 = new byte[1];
        byte[] byte2 = new byte[2];
        byte[] byte4 = new byte[4];
        public int ExtractByteToInt(Stream str, int initialOffset, int count) 
        {
            switch (count)
            {
                case 1:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte1, 0, 1);
                    return Convert.ToInt32(BitConverter.ToString(byte1, 0),16);
                case 2:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte2, 0, 2);
                    return BitConverter.ToUInt16(byte2, 0);
                case 4:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte4, 0, 4);
                    return BitConverter.ToInt32(byte4, 0);
                default:
                    return 00;
            }
        }

        public string ExtractByteToString(Stream str, int initialOffset, int count)
        {
            switch (count)
            {
                case 1:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte1, 0, 1);
                    return BitConverter.ToString(byte1, 0);
                case 2:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte2, 0, 2);
                    return BitConverter.ToString(byte2, 0); ;
                case 4:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte4, 0, 4);
                    return BitConverter.ToString(byte4, 0);
                default:
                    return "00";
            }
        }

        public byte[] ExtractByteArray(Stream str, int initialOffset, int count)
        {
            switch (count)
            {
                case 1:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte1, 0, 1);
                    return byte1;
                case 2:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte2, 0, 2);
                    return byte2;
                case 4:
                    str.Seek(initialOffset, SeekOrigin.Begin);
                    str.Read(byte4, 0, 4);
                    return byte4;
                default:
                    return new byte[0x00];
            }
        }

        public string ExtractResource(Stream str, int initialOffset, int initialBdatOffset, int count, int resourceCount)
        {
            if (resourceCount == 0)
                return "";
            str.Seek(initialOffset, SeekOrigin.Begin);
            str.Read(byte4, 0, 4);
            byte4.Reverse();
            return new FindResource().ExtractResource(str, initialBdatOffset, BitConverter.ToInt32(byte4,0), resourceCount);
        }
    }
}
