using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15
{
    class Complexnumb
    {
        int numb1;
        string numb2;
        int numb3;
        string numb4;
        public Complexnumb(int numb1, string numb2, int numb3, string numb4)
        {
            this.numb1 = numb1;
            this.numb2 = numb2;
            this.numb3 = numb3;
            this.numb4 = numb4;
        }

        public bool sing(string text)
        {
            if (text[0] == '+') return true;
            else if (text[0] == '-') return false;
            else return true;
        }
        public int receiptInt(string user)
        {
            string number = "";
            for (int i = 0; i < user.Length; i++)
            {
                if (Char.IsDigit(user[i]) == true) number += user[i];
            }
            if (number.Length > 0) return Convert.ToInt32(number);
            else return 1;
        }

        public int returnNum(string complex)
        {
            int number = receiptInt(complex);
            if (sing(complex) == false) number = number * -1;
            return number;
        }
        public string addition() 
        {
            int firstSum = numb1 + numb3;
            int secondsum = returnNum(numb2) + returnNum(numb4);
            if (sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " + " + secondsum + "i";
            }
            else return firstSum + " " + secondsum + "i";
        }

        public string subtraction() //вычитание
        {
            int firstSum = numb1 - numb3;
            int secondsum = returnNum(numb2) - returnNum(numb4);
            if (sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " - " + secondsum + "i";
            }
            else return firstSum + " " + secondsum + "i";
        }

        public string multiplication() //умножение
        {
            int firstSum = (numb1 * numb3) - (returnNum(numb2) * returnNum(numb4));
            int secondsum = (numb1 * returnNum(numb4)) + (numb3 * returnNum(numb2));
            if (sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " + " + secondsum + "i";
            }
            else return firstSum + " " + secondsum + "i";
        }
    }
}
