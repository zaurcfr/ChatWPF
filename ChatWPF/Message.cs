using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF
{
    class Message
    {
        public string message { get; set; }
        public DateTime messageTime { get; set; }

        public override string ToString()
        {
            return $"{message}\t{messageTime}";
        }
    }
}
