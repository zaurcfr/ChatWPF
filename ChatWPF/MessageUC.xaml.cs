using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatWPF
{
    /// <summary>
    /// Interaction logic for MessageUC.xaml
    /// </summary>
    public partial class MessageUC : UserControl
    {
        public MessageUC()
        {
            InitializeComponent();
        }
        public string MessageTextblock
        {
            get { return MessageLbl.Content.ToString(); }
            set { MessageLbl.Content = value;}
        }
        public string MessageTimeTextblock
        {
            get { return TimeLbl.Content.ToString(); }
            set { TimeLbl.Content = value; }
        }
    }
}
