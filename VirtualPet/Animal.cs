using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    class PetAction
    {
        //fields
        public int feedDog;
        public int waterDog;
        public int toyDog;

        //properties
        public int FeedDog
        {
            get { return this.feedDog; }
            set { this.feedDog = value; }
        }

        public int WaterDog
        {
            get { return this.waterDog; }
            set { this.waterDog = value; }
        }

        public int ToyDog
        {
            get { return this.toyDog; }
            set { this.toyDog = value; }
        }

        //method

        public int GiveFood()
        {
            return (this.feedDog + 5);
        }

        public int GiveWater()
        {
            return (this.waterDog - 4);
        }

        public int GiveGift()
        {
            return (this.toyDog + 10);
        }
    }
}
