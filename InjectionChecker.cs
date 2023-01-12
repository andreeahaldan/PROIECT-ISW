using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStore
{
    public class InjectionChecker
    {


        public InjectionChecker()
        {

        }
        public bool WordCheck(String text)
        {

            String[] SQLCommands = { "DROP", "INSERT", "DELETE", "ALTER", "TABLE" };
            text = text.ToUpper();
            bool risk = false;
            foreach (String SQLCommand in SQLCommands)
            {
                if (text.Contains(SQLCommand))
                {
                    risk = true;
                }


            }
            return risk;
        }
    }
}
