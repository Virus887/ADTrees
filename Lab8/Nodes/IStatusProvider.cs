using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8.Nodes
{
    interface IStatusProvider
    {
        bool GetStatus(bool b1, bool b2);
    }

    class ORStatus : IStatusProvider
    {
        public bool GetStatus(bool b1, bool b2)
        {
            return b1 || b2;
        }
    }

    class ANDStatus : IStatusProvider
    {
        public bool GetStatus(bool b1, bool b2)
        {
            return b1 && b2;
        }
    }


    class XORStatus : IStatusProvider
    {
        public bool GetStatus(bool b1, bool b2)
        {
            if ((b1 == true && b2 == false) || (b1 == false && b2 == true)) return true;
            return false;
        }
    }
}
//  Potwierdzam samodzielność powyższej pracy oraz niekorzystanie przeze mnie z niedozwolonych źródeł
//  Damian Bis
