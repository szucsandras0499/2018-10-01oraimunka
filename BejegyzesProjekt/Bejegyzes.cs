using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkeztve;

        public Bejegyzes(string szerzo, string tartalom) {
            this.szerzo = szerzo;
            this.tartalom = tartalom;

            this.letrejott = DateTime.Now;
        }
        public string getSzerzo() {
            return this.szerzo;
        }
        public string getTartalom()
        {
            return this.tartalom;
        }
        public int getLikeok()
        {
            return this.likeok;
        }
        public void setLikeok(int value)
        {
            this.likeok = value;
        }
        public DateTime getLetrejott()
        {
            return this.letrejott;
        }
        public DateTime getSzerkeztve()
        {
            if(this.tartalom != "")
            {
                return DateTime.Now;
            }
            else
            {
                return this.szerkeztve;
            }

        }
        public void Like()
        {
            this.likeok++;
        }
        public string kiir()
{
           string valasz = this.szerzo + " - " + this.likeok + " - " + this.letrejott + "\n" + getSzerkeztve() + "\n" + this.tartalom;
            return valasz;
            
        }
        public void setTartalom(string tartalom)
        {
            this.tartalom = tartalom;
        }  
    }
}
