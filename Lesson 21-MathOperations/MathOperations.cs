using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b)
        {
          return a + b; 
        }

        public T Subtract(T a, T b)
        {
            return a - b;
        }

        public T Multiply(T a, T b)
        {
            return a * b;
        }

        public T Divide(T a, T b)
        {
            if (b == T.Zero)
            {
                throw new ArgumentException("Divider cannot be zero!");
            }
            return a / b;
        }


    }
}
