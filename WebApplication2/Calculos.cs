using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Calculos
    {



        public string esImpar(string valor)
        {
            if (Int32.Parse(valor) % 2 == 0)
            {

                return "even";

            }
            else
            {
                return "odd";

            }
        }
    }
}

