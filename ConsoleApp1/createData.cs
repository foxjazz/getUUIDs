using System;

namespace ConsoleApp1
{
    
    public class createData
    {
        public string span;
        public void create()
        {
            string data = "";
            var a = uuid();
            var b = uuid();
            var c = uuid();
            data = $"ab stuff _{a}_";
            data += "\r\n";
            data +=  $"ab stuff _{a}_";
            data += "\r\n";
            data +=  $"ab stuff _{b}_";
            data += "\r\n";
            data +=  $"ab stuff _{b}_";
            data += "\r\n";
            data +=  $"ab stuff _{b}_";
            data += "\r\n";
            span = data;

        }

        string uuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}