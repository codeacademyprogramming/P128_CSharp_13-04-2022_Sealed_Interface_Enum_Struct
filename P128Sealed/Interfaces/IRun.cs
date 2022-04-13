using System;
using System.Collections.Generic;
using System.Text;

namespace P128Sealed.Interfaces
{
    //Interface kod bloku daxilinde yalniz method ve property
    interface IRun
    {
        public string Name { get; set; }

        public void Info();
        public void Info(int a);
        public int Test();

    }
}
