using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiers2
{
    /// <summary>
    /// Other Derived Class
    /// </summary>
    public class OtherDerivedClass : BaseClass
    {
        /// <summary>
        /// Other Derived Class Method
        /// </summary>
        public void OtherDerivedClassMethod()
        {
            a = 10;
            //b = 20; Private variable cannot accessble in other derived class
            c = 30;
            //d = 40; Internal variable cannot accessble in other derived class
            e = 50;
        }
    }
    /// <summary>
    /// Other Main Class
    /// </summary>
    public class OtherMainClass
    {
        BaseClass bc2 = new BaseClass();
        /// <summary>
        /// Other Main Class Method
        /// </summary>
        public void OtherMainClassMethod()
        {
            bc2.a = 10;
            //bc2.b = 20; Private variable cannot accessble in other main class
            //bc2.c = 30; Protected variable cannot accessble in other main class
            //bc2.d = 40; Internal variable cannot accessble in other main class
            //bc2.e = 50; Protected Internal variable cannot accessble in other main class
        }
    }
}
