using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenoblade_2_COMMON.BDAT_editor
{
    public class CheckFile
    {
        public bool ValidateFile(Stream str)
        {
            try
            {
                byte[] chrblTable = new byte[6];
                str.Seek(819968, SeekOrigin.Begin);
                str.Read(chrblTable, 0, 6);
                string sourceFirstBytes = BitConverter.ToString(chrblTable);
                string CHR_BL = "43-48-52-5F-42-6C";
                Console.WriteLine(sourceFirstBytes == CHR_BL ? "true" : "false");
                return sourceFirstBytes == CHR_BL ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
