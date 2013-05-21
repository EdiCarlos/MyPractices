using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public interface IBridgeA
    {
        void Implementation();
    }
    public class Abstract
    {
        IBridgeA ibridge;
        public Abstract(IBridgeA bridge)
        {
            ibridge = bridge;
        }
        public void OtherImplementation()
        {
            ibridge.Implementation();
        }
    }
    public class ImplementationAA : IBridgeA
    {

        public void Implementation()
        {
            Console.WriteLine("Implementation AA Called ...");
        }
    }
    public class ImplementationAB : IBridgeA
    {
        public void Implementation()
        {
            Console.WriteLine("Implementation AB called...");
        }
    }
}
