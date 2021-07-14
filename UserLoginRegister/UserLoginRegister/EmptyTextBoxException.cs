using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginRegister
{
    public class EmptyTextBoxException:Exception
    {
        public EmptyTextBoxException(string message) : base(message)
        {
           
        }
    }
}
