using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class MotorbootException : Exception
    {
        public MotorbootException(string message) : base(message)
        {
            
        }
    }
}
