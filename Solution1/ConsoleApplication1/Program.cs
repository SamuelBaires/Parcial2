using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            switch(op)
            {
                case 1:
                    Class1 Obj = new Class1();
                     Obj.MultiValores();
                    break;
                case 2:
                    Class1 Obj2 = new Class1();
                    Obj2.DiviValore();
                    break;
                case 3:
                    Class1 Obj3 = new Class1();
                    Obj3.Nombre();
                    break;
                case 4:
                    Class1 Obj4 = new Class1();
                    Obj4.Edad();
                    break;


            }
                
               

        }
    }
}
