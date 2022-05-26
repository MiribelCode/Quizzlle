using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzlle
{
    class Thema
    {
        private int themaID;

        private string bezeichnung;

        //------------------------------
        public int getThemaID()
        {
            return this.themaID;
        }

        public void setThemaID(int ThemaID)
        {
            this.themaID = ThemaID;
        }


        //------------------------------
        public string getbezeichnung()
        {
            return this.bezeichnung;
        }

        public void setbezeichnung(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;
        }

    }
}
