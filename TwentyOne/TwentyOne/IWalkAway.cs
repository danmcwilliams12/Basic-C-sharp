using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway
    {
        //everything is public in an interface
        //similar to an abstract, all methods must be implimented in inheriting class
        void WalkAway(Player player);       
    }
}
