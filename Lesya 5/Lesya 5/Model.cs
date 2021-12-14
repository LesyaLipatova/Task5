using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_5
{
    class Model: Siemens_Mobile
    {
        string name;

        int screen_size;

        public Model(string name, int screen_size, int battery) : base(battery)
        {
            this.name = name;
            this.screen_size = screen_size;
        }


        public int get_screen_size()
        {
            return screen_size;
        }

        public void set_screen_size(int screen_size)
        {
            this.screen_size = screen_size;
        }

        public string get_name()
        {
            return name;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

    }
}
