using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public abstract class GCDCalculate
    {
        protected abstract int SteinGcd(int firstNumber, int secondNumber);
        protected abstract int EuclideanGcd(int firstNumber, int secondNumber);
    }
}
