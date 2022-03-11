using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenoblade_2_COMMON.BDAT_editor
{
    public class FindResource
    {
        public string ExtractResource(Stream str, int initialOffset, int resourcePosition, int count)
        {
            try
            {
                byte[] resourceInformation = new byte[count];
                str.Seek(initialOffset + resourcePosition, SeekOrigin.Begin);
                str.Read(resourceInformation, 0, count);
                return Encoding.UTF8.GetString(resourceInformation);
            }
            catch
            {
                return "null";
            }
        }

        public MemoryStream InjectResource(MemoryStream str, string value, int initialOffset, int resourcePosition, int count)
        {
            try
            {
                byte[] resourceInformation = new byte[count];
                resourceInformation = Encoding.UTF8.GetBytes(value);
                //Array.Reverse(resourceInformation);
                str.Seek(initialOffset + resourcePosition, SeekOrigin.Begin);
                str.Write(resourceInformation, 0, count);
                return str;
            }
            catch
            {
                return str;
            }
        }

    }
}
