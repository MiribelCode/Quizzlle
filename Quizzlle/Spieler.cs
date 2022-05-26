using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzlle
{
    class Spieler
    {

        private int SpielerID;

        private string name;

        private int siege;

        private int PunkteProSpiel;



        //------------------------------
        public int getSpielerID()
        {
            return this.SpielerID;
        }

        public void setSpielerID(int SpielerID)
        {
            this.SpielerID = SpielerID;
        }



        //------------------------------
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }



        //------------------------------
        public int getSiege()
        {
            return this.siege;
        }

        public void setSiege(int siege)
        {
            this.siege = siege;
        }


    }
}
