using System;
using OOPS;

namespace OOPS_PROJECT
{
        internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.gets();
            S.prints();
            S = new Teacher();
            S.gets();
            S.prints();
            S = new Subject();
            S.gets();
            S.prints();
        }
    }
}


