using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChatWPF
{
    class User
    {
        public string Name { get; set; }
        public Image profilePhoto { get; set; }
        public Message MessageFromUser { get; set; }

    }
}
