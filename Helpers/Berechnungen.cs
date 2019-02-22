using System;
using System.Collections.Generic;

namespace BestellErfassung.FileHelpers
{
    class Berechnungen
    {

        public static decimal MwSt_Betrag(decimal Nettobetrag, decimal MwSt_Prozent)
        {
            decimal mwst_betrag = Nettobetrag * (MwSt_Prozent / 100);
            return mwst_betrag;
        }

        public static decimal MwSt_Inkasso_Betrag(decimal Bruttobetrag, decimal MwSt_Prozent)
        {
            decimal mwst_betrag = ((Bruttobetrag * (100 - ((100 / (100 + MwSt_Prozent)) * 100))) / 100);
            return mwst_betrag;
        }

        /// <summary>
        /// Prüft ob value zwischen den übergebenen Grenzen liegt oder einer dieser entspricht
        /// </summary>
        /// <typeparam name="T">Typ der Prüfung muss IComparable implementieren</typeparam>
        /// <param name="value">Wert der geprüft werden soll</param>
        /// <param name="lowest">Mindestwert der eine positive Prüfung ergibt</param>
        /// <param name="highest">Maximalwert der eine positive Prüfung ergibt</param>
        /// <returns></returns>
        public static bool IsBetween<T>(T value, T lowest, T highest) where T : IComparable
        {
            return (Comparer<T>.Default.Compare(lowest, value) <= 0 && Comparer<T>.Default.Compare(highest, value) >= 0);
        }

    }
}
