using System;
using System.Collections.Generic;
using System.Text;

namespace P128Sealed.Models
{
    class Student : Human
    {
        //Seale - Keywordune sahib Olan methodu override olunmur
        public sealed override void Info()
        {
            base.Info();
        }
    }
}
