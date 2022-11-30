using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Calc : System.Web.UI.Page
    {
        static int x;
        static char op;
        protected void Button1_Click(object sender, EventArgs e)
        {
            test.InnerText += 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            test.InnerText += 2;

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            test.InnerText += 3;

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            test.InnerText += 4;

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            test.InnerText += 5;

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            test.InnerText += 6;

        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            test.InnerText += 7;

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            test.InnerText += 8;

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            test.InnerText += 9;

        }
        protected void Button0_Click(object sender, EventArgs e)
        {
            test.InnerText += 0;

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(test.InnerHtml);
            op = '+';
            test.InnerText += "+";

        }
        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(test.InnerHtml);

            op = '-';
            test.InnerText += "-";
            
        }
        protected void ButtonMult_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(test.InnerHtml);

            op = '*';

            test.InnerText += "*";
        }
        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(test.InnerHtml);

            op = '/';

            test.InnerText += "/";
        }
        protected void ButtonClear_Click(object sender, EventArgs e) 
        {
            x = 0;
            test.InnerHtml = "";
        }
        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            string temp = test.InnerText;
            string[] rest=new string[] {"","" };
            int result;
            switch (op) 
            {
                case '+':
                    rest = temp.Split('+');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    final.InnerText =Convert.ToString( x + result);
                    break;
                case '-':
                    rest = temp.Split('-');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    final.InnerText = Convert.ToString( x- result);
                    break;
                case '/':
                    rest = temp.Split('/');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    final.InnerText = Convert.ToString(x/result); break;
                case '*':
                    rest = temp.Split('*');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    final.InnerText = Convert.ToString(x*result); break;
            }
           
            
        }

    }
}