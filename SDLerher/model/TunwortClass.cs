using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class TunwortClass
    {
        private string tunwort;
        private string übersetzung;
        private string partizipPerfekt;
        private bool hilfsverb;

        private List<string> gägewart;
        private List<string> möglechkeitsform;

        public TunwortClass(
            string tunwort, 
            string übersetzung, 
            string partizipPerfekt, 
            bool hilfsverb, 
            List<string> gägewart, 
            List<string> möglechkeitsform
            )
        {
            this.tunwort = tunwort;
            this.übersetzung = übersetzung;
            this.partizipPerfekt = partizipPerfekt;
            this.hilfsverb = hilfsverb;

            this.gägewart = gägewart;
            this.möglechkeitsform = möglechkeitsform;
        }

        public string Tunwort
        {
            get { return tunwort; }
            set { tunwort = value; }
        }
        public string Übersetzung
        {
            get { return übersetzung; }
            set { übersetzung = value; }
        }
        public string PartizipPerfekt
        {
            get { return partizipPerfekt; }
            set { partizipPerfekt = value; }
        }
        public bool Hilfsverb
        {
            get { return hilfsverb; }
            set { hilfsverb = value; }
        }

        public List<string> Gägewart
        {
            get { return gägewart; }
            set { gägewart = value; }
        }
        public List<string> Möglechkeitsform
        {
            get { return möglechkeitsform; }
            set { möglechkeitsform = value; }
        }
    }
}
