using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Languages
{
    public partial class Service
    {
        public SolidColorBrush typeDic
        {
            get
            {
                if(Discount==0)
                {
                   return Brushes.White;
                }
                
               return Brushes.White;
            }
        }
    }
}
