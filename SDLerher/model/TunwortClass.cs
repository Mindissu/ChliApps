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
        private List<string> zuekunft;
        private List<string> vergangeheit;
        private List<string> möglechkeitsform;

        public string Tunwort
        {
            get { return tunwort; }
            set { tunwort = value; }
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
        public List<string> Zuekunft
        {
            get { return zuekunft; }
            set { zuekunft = value; }
        }
        public List<string> Vergangeheit
        {
            get { return vergangeheit; }
            set { vergangeheit = value; }
        }
        public List<string> Möglechkeitsform
        {
            get { return möglechkeitsform; }
            set { möglechkeitsform = value; }
        }
    }
}
