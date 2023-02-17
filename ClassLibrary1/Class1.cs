using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(float width, float length, int count, int productType, int materialType)
        {
            double calcul=-1;
            if(width!=0 && length!=0 && count != 0)
            {
                if (productType == 1)
                {
                    if (materialType == 1)
                    {
                        calcul = count * width * length * 1.1 + count * width * length * 1.1 * 0.003;
                    }
                    else if (materialType == 2)
                    {
                        calcul = count * width * length * 1.1 + count * width * length * 1.1 * 0.0012;
                    }
                }
                else if (productType == 2)
                {
                    if (materialType == 1)
                    {
                        calcul = count * width * length * 2.5 + count * width * length * 2.5 * 0.003;
                    }
                    else if (materialType == 2)
                    {
                        calcul = count * width * length * 2.5 + count * width * length * 2.5 * 0.0012;
                    }
                }
                else if (productType == 3)
                {
                    if (materialType == 1)
                    {
                        calcul = count * width * length * 8.43 + count * width * length * 8.43 * 0.003;
                    }
                    else if (materialType == 2)
                    {
                        calcul = count * width * length * 8.43 + count * width * length * 8.43 * 0.0012;
                    }
                }
            }
            int rezult;
            Regex r1 = new Regex("^[0-9]*$");
            if(r1.IsMatch(calcul.ToString()))
            {
                rezult = (int)calcul;
            }
            else if(calcul<0)
            {
                rezult = (int)calcul;
            }
            else
            {
                rezult = (int)calcul + 1;
            }
            return rezult;
        }
    }
}
