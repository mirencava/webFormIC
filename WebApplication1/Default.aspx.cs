using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTituloApp.Text = "EvenOrOdd Application";
            
        }

        /*
          Fuction : isEven
          -----------------
          compute if a number is even or odd
          input params: checkNumber: it is the number to check in about
          returns: if the number is even return true 
                   if the number is odd return false
                   */
  
        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = esImpar(checkNumberEven.Value);
          

        }
        public string esImpar(string valor)
        {
            if (Int32.Parse(valor) % 2 == 0)
            {

               return "Even";

            }
            else
            {
                return "Odd";

            }
        }
    }
   

}