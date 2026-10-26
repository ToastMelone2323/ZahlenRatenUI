using System;
using System.Collections.Generic;
using System.Text;

namespace ZahlenRatenUI
{
    internal class Ergebnis
    {
        public static Ergebnis Add { get; internal set; }
        public int Versuche {  get; set; }
        public string Schwiereigkeit { get; set; }
        public DateTime Datum { get; set; }

        public override string ToString()
        {
            return $"Versuche: {Versuche}, {Schwiereigkeit}, {Datum}";
        }
    }
}
