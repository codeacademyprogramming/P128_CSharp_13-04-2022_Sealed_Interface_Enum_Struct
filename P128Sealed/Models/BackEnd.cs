using P128Sealed.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128Sealed.Models
{
    //Sealed - Keywordune Sahib Class Miras Oturmur
    //Sealed - Keywordune Sahib Olan class-da virtual method yaratmaq
    sealed class BackEnd :  Developer, IWalk, IRun
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Info(int a)
        {
            throw new NotImplementedException();
        }

        public override void Test()
        {
            base.Test();
        }

        int IRun.Test()
        {
            throw new NotImplementedException();
        }
    }
}
