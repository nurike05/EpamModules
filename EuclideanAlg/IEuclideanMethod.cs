using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public interface IEuclideanMethod
    {
        int EuclideanMethod(out double time, params int[] numbers);
        int EuclideanMethod(params int[] numbers);
    }
}
