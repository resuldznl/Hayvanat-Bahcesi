using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Location
    {
        public Location(int x,int y){
            X=x;
            Y=y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }

    }
}
