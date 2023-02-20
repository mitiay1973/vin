using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   

    public class Class1
    {
        public char[] vinCode = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public Boolean CheckVIN(String vin)
        {
            int chetchik=0;
            if(vin.Length==17)
            {
                for (int i = 0; i <17; i++)
                {
                    for (int j = 0; j <vinCode.Length; j++)
                    {
                        if (vin[i] == vinCode[j])
                        {
                            chetchik++;
                        }
                    }
                }
                if(chetchik==17)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
