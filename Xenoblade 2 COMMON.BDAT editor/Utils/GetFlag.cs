using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenoblade_2_COMMON.BDAT_editor.Utils
{
    internal class GetFlag
    {
        public bool GetFlagFromInt(int integer, int flagPosition)
        {
            BitArray flags = new BitArray(new int[] { integer });
            return flags.Get(flagPosition);
        }

        public int GetIntFromFlags(bool[] bFlags)
        {
            int totalFlagValue = 0;
            for (int i = 0; i < bFlags.Length; i++)
            {
                int increment = i == 0 ? i + 1 : i * 2;
                totalFlagValue = bFlags[i] == true ? totalFlagValue + increment : +0;
            }
            return totalFlagValue;
        }
    }
}
