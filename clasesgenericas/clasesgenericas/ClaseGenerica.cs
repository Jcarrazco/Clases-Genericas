using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesgenericas
{
    public class printer <T> 
    {
        public string Print(T X)
        {
            string Nuevo = Convert.ToString(X);
            return Nuevo;
        }
    }

    public class swper<T> where T : struct
    {
        public void swap ( T X, T X2)
        {
            T temp;
            temp = X2;
            X2 = X;
            X = temp;
            Console.WriteLine(X + " " + X2);
        }
    }
}
