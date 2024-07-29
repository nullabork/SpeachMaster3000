using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speechmaster
{
  public class SpeechmasterException : Exception
  {
    public SpeechmasterException(string message) : base(message)
    {
    }

    public SpeechmasterException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public SpeechmasterException()
    {
    }
  }
}
