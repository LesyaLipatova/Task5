using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_5
{
    interface IMobile
    {
        bool Power
        {
            get;
            set;
        }

        void Power_on();

        void Power_off();
    }
}
