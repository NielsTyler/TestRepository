using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCode
{
    public class YieldTestClass
    {
        private int[] pureNumbers = new int[5] {2, 3, 5, 6, 7};

        public IEnumerable<int> SquareNumbers
        {
            get {
                foreach (int i in pureNumbers)
                    yield return (int)Math.Pow(i, 2);
            }
        }
    }
}
