using System;
using System.Collections;
using DevExpress.Xpo;

namespace BestellErfassung.Helpers
{
    class SystemSettingsHelper
    {
        /// <summary>
        /// ArrayListe für Stückliste Child
        /// </summary>
        private static ArrayList _list_stl_child;
        public static ArrayList list_stl_child
        {
            get { return _list_stl_child; }
            set { _list_stl_child = value; }
        }

        /// <summary>
        /// ArrayListe für Stückliste Child Auftrag
        /// </summary>
        private static ArrayList _list_stl_child_auftrag;
        public static ArrayList list_stl_child_auftrag
        {
            get { return _list_stl_child_auftrag; }
            set { _list_stl_child_auftrag = value; }
        }

        /// <summary>
        /// ArrayListe für PositionsNr Stückliste
        /// </summary>
        private static ArrayList _list_positions_nr;
        public static ArrayList list_positions_nr
        {
            get { return _list_positions_nr; }
            set { _list_positions_nr = value; }
        }

        /// <summary>
        /// Startdatum WJ
        /// </summary>
        private static DateTime _StartdatumWJ;
        public static DateTime StartdatumWJ
        {
            get { return _StartdatumWJ; }
            set { _StartdatumWJ = value; }
        }

        /// <summary>
        /// Enddatum WJ
        /// </summary>
        private static DateTime _EnddatumWJ;
        public static DateTime EnddatumWJ
        {
            get { return _EnddatumWJ; }
            set { _EnddatumWJ = value; }
        }

        /// <summary>
        /// Startdatum WJ
        /// </summary>
        private static DateTime _StartdatumSelectionWJ;
        public static DateTime StartdatumSelectionWJ
        {
            get { return _StartdatumSelectionWJ; }
            set { _StartdatumSelectionWJ = value; }
        }

        /// <summary>
        /// Enddatum WJ
        /// </summary>
        private static DateTime _EnddatumSelectionWJ;
        public static DateTime EnddatumSelectionWJ
        {
            get { return _EnddatumSelectionWJ; }
            set { _EnddatumSelectionWJ = value; }
        }

        /// <summary>
        /// Die Oid des eingelockten Users
        /// </summary>
        private static int _LoggedInUserOid; 
        public static int LoggedInUserOid
        {
            get { return _LoggedInUserOid; }
            set { _LoggedInUserOid = value; }
        }

        /// <summary>
        /// Das Kennzeichen des eingelockten Users
        /// </summary>
        private static string _LoggedInUserKz = string.Empty;
        public static string LoggedInUserKz
        {
            get { return _LoggedInUserKz; }
            set { _LoggedInUserKz = value; }
        }

        /// <summary>
        /// Das Durchwahlnummer des eingelockten Users
        /// </summary>
        private static string _LoggedInUserDirectDialing = string.Empty;
        public static string LoggedInUserDirectDialing
        {
            get { return _LoggedInUserDirectDialing; }
            set { _LoggedInUserDirectDialing = value; }
        }

        /// <summary>
        /// Ist Logged in User Administrator
        /// </summary>
        private static bool _LoggedInUserIsAdmin;
        public static bool LoggedInUserIsAdmin
        {
            get { return _LoggedInUserIsAdmin; }
            set { _LoggedInUserIsAdmin = value; }
        }

        /// <summary>
        /// Ob eingelogter User Tabs verwendet
        /// </summary>
        private static bool _LoggedInUserUseTabs;
        public static bool LoggedInUserUseTabs
        {
            get { return _LoggedInUserUseTabs; }
            set { _LoggedInUserUseTabs = value; }
        }


        /// <summary>
        /// Ist Logged in User Administrator
        /// </summary>
        private static bool _Bestellungartbuchungerstellen;
        public static bool Bestellungartbuchungerstellen
        {
            get { return _Bestellungartbuchungerstellen; }
            set { _Bestellungartbuchungerstellen = value; }
        }

        /// <summary>
        /// Ob BestellNr abgefragt werden soll
        /// </summary>
        private static bool _BestellNrAbfrage;
        public static bool BestellNrAbfrage
        {
            get { return _BestellNrAbfrage; }
            set { _BestellNrAbfrage = value; }
        }

        /// <summary>
        /// Ob die Stücklisten unterdrückung durchgeführt werden soll
        /// </summary>
        private static bool _STLAufloesungUnterdruecken;
        public static bool STLAufloesungUnterdruecken
        {
            get { return _STLAufloesungUnterdruecken; }
            set { _STLAufloesungUnterdruecken = value; }
        }

        /// <summary>
        /// Wirtschaftsjahr wird eingegrenzt
        /// </summary>
        private static bool _Wirtschaftsjahreingrenzung;
        public static bool Wirtschaftsjahreingrenzung
        {
            get { return _Wirtschaftsjahreingrenzung; }
            set { _Wirtschaftsjahreingrenzung = value; }
        }

        /// <summary>
        /// Wirtschaftsjahr ausgewählt
        /// </summary>
        private static int _Wirtschaftsgewaehlt;
        public static int Wirtschaftsgewaehlt
        {
            get { return _Wirtschaftsgewaehlt; }
            set { _Wirtschaftsgewaehlt = value; }
        }

        /// <summary>
        /// Mandanten Rechnungs Check
        /// </summary>
        private static bool _MandantRechCheck;
        public static bool MandantRechCheck
        {
            get { return _MandantRechCheck; }
            set { _MandantRechCheck = value; }
        }

        /// <summary>
        /// Preiseinheitenberechnung
        /// </summary>
        private static bool _Preiseinheitenberechnung;
        public static bool Preiseinheitenberechnung
        {
            get { return _Preiseinheitenberechnung; }
            set { _Preiseinheitenberechnung = value; }
        }
        
        /// <summary>
        /// Den Namen der Hauptdatenbank von WaWi
        /// </summary>
        private static string _MasterDBName = string.Empty;
        public static string MasterDBName
        {
            get { return _MasterDBName; }
            set { _MasterDBName = value; }
        }

        /// <summary>
        /// Der Connection String der Hauptdatenbank
        /// </summary>
        private static string _MasterConnectionString = string.Empty;
        public static string MasterConnectionString
        {
            get { return _MasterConnectionString; }
            set { _MasterConnectionString = value; }
        }

        /// <summary>
        /// Der Export Pfad für die Reports
        /// </summary>
        private static string _ExportPfad = string.Empty;
        public static string ExportPfad
        {
            get { return _ExportPfad; }
            set { _ExportPfad = value; }
        }

        /// <summary>
        /// Der Self Pfad für die Datevausgabe
        /// </summary>
        private static string _SelfExportPfad = string.Empty;
        public static string SelfExportPfad
        {
            get { return _SelfExportPfad; }
            set { _SelfExportPfad = value; }
        }

        /// <summary>
        /// Der Scann Pfad
        /// </summary>
        private static string _ScannPfad = string.Empty;
        public static string ScannPfad
        {
            get { return _ScannPfad; }
            set { _ScannPfad = value; }
        }

        /// <summary>
        /// Der David Pfad
        /// </summary>
        private static string _DavidPfad = string.Empty;
        public static string DavidPfad
        {
            get { return _DavidPfad; }
            set { _DavidPfad = value; }
        }

        /// <summary>
        /// Angabe ob Belege als PDF gespeichert werden sollen
        /// </summary>
        private static string _BelegPDFspeicherung = string.Empty;
        public static string BelegPDFspeicherung
        {
            get { return _BelegPDFspeicherung; }
            set { _BelegPDFspeicherung = value; }
        }

        /// <summary>
        /// Der neue Connection String der Ausgewählt wurde
        /// </summary>
        private static string _NewConnectionString = string.Empty;
        public static string NewConnectionString
        {
            get { return _NewConnectionString; }
            set { _NewConnectionString = value; }
        }

        /// <summary>
        /// Der neue aktuelle Connection String 
        /// </summary>
        private static string _CurrentConnectionString = string.Empty;
        public static string CurrentConnectionString
        {
            get { return _CurrentConnectionString; }
            set { _CurrentConnectionString = value; }
        }

        /// <summary>
        /// Serverpfad für Reports, etc.
        /// </summary>
        private static string _BestellErfassungSERVERPFAD;
        public static string BestellErfassungSERVERPFAD
        {
            get { return _BestellErfassungSERVERPFAD; }
            set { _BestellErfassungSERVERPFAD = value; }
        }

        /// <summary>
        /// Ausgewählter Mandant
        /// </summary>
        private static int _Selected_Mandant;
        public static int Selected_Mandant
        {
            get { return _Selected_Mandant; }
            set { _Selected_Mandant = value; }
        }

        /// <summary>
        /// Oid des ausgewählten Wirtschaftsjahr
        /// </summary>
        private static int _Selected_WJahr;
        public static int Selected_WJahr
        {
            get { return _Selected_WJahr; }
            set { _Selected_WJahr = value; }
        }

        /// <summary>
        /// EigeneKundenNr
        /// </summary>
        private static int _EigeneKundenNr;
        public static int EigeneKundenNr
        {
            get { return _EigeneKundenNr; }
            set { _EigeneKundenNr = value; }
        }

        /// <summary>
        /// ComputerID
        /// </summary>
        private static int _ComputerID;
        public static int ComputerID
        {
            get { return _ComputerID; }
            set { _ComputerID = value; }
        }
        
        /// <summary>
        /// ERFibu Buchungen.
        /// </summary>
        private static bool _ERFibuBuchung;
        public static bool ERFibuBuchung
        {
            get { return _ERFibuBuchung; }
            set { _ERFibuBuchung = value; }
        }

        /// <summary>
        /// WHM aktiv
        /// </summary>
        private static bool _WHMaktiv;
        public static bool WHMaktiv
        {
            get { return _WHMaktiv; }
            set { _WHMaktiv = value; }
        }

        /// <summary>
        /// Fibuvorschaus für Debitor und Kreditor verwenden
        /// </summary>
        private static bool _FibuvorschauDebundKred;
        public static bool FibuvorschauDebundKred
        {
            get { return _FibuvorschauDebundKred; }
            set { _FibuvorschauDebundKred = value; }
        }

        /// <summary>
        /// Storno nur am selben Tag.
        /// </summary>
        private static bool _StornoamselbenTag;
        public static bool StornoamselbenTag
        {
            get { return _StornoamselbenTag; }
            set { _StornoamselbenTag = value; }
        }

        /// <summary>
        /// LieferantenTermine sollen angezeigt werden.
        /// </summary>
        private static bool _LieferantenTermineanzeigen;
        public static bool LieferantenTermineanzeigen
        {
            get { return _LieferantenTermineanzeigen; }
            set { _LieferantenTermineanzeigen = value; }
        }

        /// <summary>
        /// Aufträge verschieben.
        /// </summary>
        private static bool _Auftraegeverschieben;
        public static bool Auftraegeverschieben
        {
            get { return _Auftraegeverschieben; }
            set { _Auftraegeverschieben = value; }
        }

        /// <summary>
        /// Fibu loeschen.
        /// </summary>
        private static bool _Fibuloeschen;
        public static bool Fibuloeschen
        {
            get { return _Fibuloeschen; }
            set { _Fibuloeschen = value; }
        }

        /// <summary>
        /// Lagerortbuchungen.
        /// </summary>
        private static bool _Lagerortbuchungen;
        public static bool Lagerortbuchungen
        {
            get { return _Lagerortbuchungen; }
            set { _Lagerortbuchungen = value; }
        }

        /// <summary>
        /// KreditorOP freigeben.
        /// </summary>
        private static bool _KreditorOPfreigeben;
        public static bool KreditorOPfreigeben
        {
            get { return _KreditorOPfreigeben; }
            set { _KreditorOPfreigeben = value; }
        }

        /// <summary>
        /// Lieferantenabfrage bei Auftrag.
        /// </summary>
        private static bool _Lieferantenabfrage;
        public static bool Lieferantenabfrage
        {
            get { return _Lieferantenabfrage; }
            set { _Lieferantenabfrage = value; }
        }

        /// <summary>
        /// Belegzuweisung für Ausdruck überprüfen.
        /// </summary>
        private static bool _BelegzuweisungvorAusdruck;
        public static bool BelegzuweisungvorAusdruck
        {
            get { return _BelegzuweisungvorAusdruck; }
            set { _BelegzuweisungvorAusdruck = value; }
        }

        /// <summary>
        /// Lieferantenabfrage bei Auftrag.
        /// </summary>
        private static bool _LiefNrbeiRechnungsdruck;
        public static bool LiefNrbeiRechnungsdruck
        {
            get { return _LiefNrbeiRechnungsdruck; }
            set { _LiefNrbeiRechnungsdruck = value; }
        }

        /// <summary>
        /// Debitor und Kreditor OP nur für ein User.
        /// </summary>
        private static bool _DebundKredOPeinUser;
        public static bool DebundKredOPeinUser
        {
            get { return _DebundKredOPeinUser; }
            set { _DebundKredOPeinUser = value; }
        }

        /// <summary>
        /// AuftragsalsProjekte
        /// </summary>
        private static bool _AuftragalsProjekte;
        public static bool AuftragalsProjekte
        {
            get { return _AuftragalsProjekte; }
            set { _AuftragalsProjekte = value; }
        }


        /// <summary>
        /// Dispoplangrund verwenden.
        /// </summary>
        private static bool _Dispoplangrund;
        public static bool Dispoplangrund
        {
            get { return _Dispoplangrund; }
            set { _Dispoplangrund = value; }
        }

        /// <summary>
        /// AuftragsPositionen Schnellerfassung verwenden.
        /// </summary>
        private static bool _AuftrPosschnellerf;
        public static bool AuftrPosschnellerf
        {
            get { return _AuftrPosschnellerf; }
            set { _AuftrPosschnellerf = value; }
        }

        /// <summary>
        /// Mandatenverknuepfung für die Auftrags, Bestellungs übertragung.
        /// </summary>
        private static bool _Mandatenverknuepfung;
        public static bool Mandatenverknuepfung
        {
            get { return _Mandatenverknuepfung; }
            set { _Mandatenverknuepfung = value; }
        }

        /// <summary>
        /// Rabatt wird vom Gesamtbetrag gezogen.
        /// </summary>
        private static bool _RabattvomGesamtbetrag;
        public static bool RabattvomGesamtbetrag
        {
            get { return _RabattvomGesamtbetrag; }
            set { _RabattvomGesamtbetrag = value; }
        }

        /// <summary>
        /// Lagerbuchung über Warenbestandsbuch.
        /// </summary>
        private static bool _LagerbuchungueberWABuch;
        public static bool LagerbuchungueberWABuch
        {
            get { return _LagerbuchungueberWABuch; }
            set { _LagerbuchungueberWABuch = value; }
        }

        /// <summary>
        /// Lagerbuchung über Warenbestandsbuch.
        /// </summary>
        private static bool _ArtikelZugangueberWABUCH;
        public static bool ArtikelZugangueberWABUCH
        {
            get { return _ArtikelZugangueberWABUCH; }
            set { _ArtikelZugangueberWABUCH = value; }
        }

        /// <summary>
        /// Transportauftrags Informationen werden nicht gedruckt.
        /// </summary>
        private static bool _TransportauftragInfosnichtdrucken;
        public static bool TransportauftragInfosnichtdrucken
        {
            get { return _TransportauftragInfosnichtdrucken; }
            set { _TransportauftragInfosnichtdrucken = value; }
        }

        /// <summary>
        /// Auftrag trotz erfolgter Zahlung stornieren.
        /// </summary>
        private static bool _AuftragsStornobeierfolgterZahlung;
        public static bool AuftragsStornobeierfolgterZahlung
        {
            get { return _AuftragsStornobeierfolgterZahlung; }
            set { _AuftragsStornobeierfolgterZahlung = value; }
        }

        /// <summary>
        /// Staffelpreise verwenden.
        /// </summary>
        private static bool _Staffelpreiseverw;
        public static bool Staffelpreiseverw
        {
            get { return _Staffelpreiseverw; }
            set { _Staffelpreiseverw = value; }
        }

        /// <summary>
        /// Charge aus Datum und Zeit wird vorgeschlagen.
        /// </summary>
        private static bool _ChargeausDatumZeit;
        public static bool ChargeausDatumZeit
        {
            get { return _ChargeausDatumZeit; }
            set { _ChargeausDatumZeit = value; }
        }

        /// <summary>
        /// Ausgewähltes eMailProgramm
        /// </summary>
        private static string _Selected_eMailProgramm;
        public static string Selected_eMailProgramm
        {
            get { return _Selected_eMailProgramm; }
            set { _Selected_eMailProgramm = value; }
        }

        /// <summary>
        /// Standard LookandFeel
        /// </summary>
        private static string _STDLookandFeel;
        public static string STDLookandFeel
        {
            get { return _STDLookandFeel; }
            set { _STDLookandFeel = value; }
        }

        /// <summary>
        /// SoftwareModulCRM
        /// </summary>
        private static string _SoftwareModulCRM;
        public static string SoftwareModulCRM
        {
            get { return _SoftwareModulCRM; }
            set { _SoftwareModulCRM = value; }
        }

        /// <summary>
        /// Bankencheck
        /// </summary>
        private static string _SoftwareModulBankencheck;
        public static string SoftwareModulBankencheck
        {
            get { return _SoftwareModulBankencheck; }
            set { _SoftwareModulBankencheck = value; }
        }

        /// <summary>
        /// SEPAMandat
        /// </summary>
        private static string _SoftwareModulSEPAMandat;
        public static string SoftwareModulSEPAMandat
        {
            get { return _SoftwareModulSEPAMandat; }
            set { _SoftwareModulSEPAMandat = value; }
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        private static string _SoftwareModulDashboard;
        public static string SoftwareModulDashboard
        {
            get { return _SoftwareModulDashboard; }
            set { _SoftwareModulDashboard = value; }
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        private static string _SoftwareModulERKontenvorlagen;
        public static string SoftwareModulERKontenvorlagen
        {
            get { return _SoftwareModulERKontenvorlagen; }
            set { _SoftwareModulERKontenvorlagen = value; }
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        private static bool _STLHinweisobPreisausdruck;
        public static bool STLHinweisobPreisausdruck
        {
            get { return _STLHinweisobPreisausdruck; }
            set { _STLHinweisobPreisausdruck = value; }
        }


        private static bool _InventurEingeleitet;
        public static bool InventurEingeleitet
        {
            get { return _InventurEingeleitet; }
            set { _InventurEingeleitet = value; }
        }

        private static bool _UpdateDatenbank;
        public static bool UpdateDatenbank
        {
            get { return _UpdateDatenbank; }
            set { _UpdateDatenbank = value; }
        }

        /// <summary>
        /// ArrayListe aller angelegten Mandanten
        /// </summary>
        private static ArrayList _list_mandaten;
        public static ArrayList list_madanten
        {
            get { return _list_mandaten; }
            set { _list_mandaten = value; }
        }

        /// <summary>
        /// ArrayListe für UstID Prüfung
        /// </summary>
        private static ArrayList _list_UstID;
        public static ArrayList list_UstID
        {
            get { return _list_UstID; }
            set { _list_UstID = value; }
        }

        /// <summary>
        /// ArrayListe aller Ausdruckdokumente
        /// </summary>
        private static ArrayList _list_WDokumente;
        public static ArrayList list_WDokumente
        {
            get { return _list_WDokumente; }
            set { _list_WDokumente = value; }
        }

        /// <summary>
        /// Weitere Dokumente, Name übergeben werden
        /// </summary>
        public class m_WDokumente
        {
            string m_auftrnr, m_pfad;

            public m_WDokumente(string m_pfad, string m_auftrnr)
            {
                this.m_auftrnr = m_auftrnr;
                this.m_pfad = m_pfad;
            }

            public string M_auftrnr
            {
                get { return m_auftrnr; }
                set { m_auftrnr = value; }
            }
            public string M_pfad
            {
                get { return m_pfad; }
                set { m_pfad = value; }
            }
        }

        /// <summary>
        /// Die Mandanten Klasse an welche ID, Name und Connectionstring übergeben werden
        /// </summary>
        public class m_mandanten
        {
            int id;
            string m_name, m_connectionstring;

            public m_mandanten(int id, string m_name, string m_connectionstring)
            {
                this.id = id;
                this.m_name = m_name;
                this.m_connectionstring = m_connectionstring;
            }

            public int ID
            {
                get { return id; }
            }

            public string M_name
            {
                get { return m_name; }
                set { m_name = value; }
            }
            public string M_connectionstring
            {
                get { return m_connectionstring; }
                set { m_connectionstring = value; }
            }
        }
        
        /// <summary>
        /// ArrayListe aller angelegten Wirtschaftsjahre
        /// </summary>
        private static ArrayList _list_wirtschaftsjahre;
        public static ArrayList list_wirtschaftsjahre
        {
            get { return _list_wirtschaftsjahre; }
            set { _list_wirtschaftsjahre = value; }
        }

        /// <summary>
        /// Die Wirtschafts Klasse an welche ID, Wirtschaftsjahr übergeben werden
        /// </summary>
        public class m_wirtschaftsjahr
        {
            int id;
            int m_wjahr;
            bool m_abgeschlossen;

            public m_wirtschaftsjahr(int id, int m_wjahr, bool m_abgeschlossen)
            {
                this.id = id;
                this.m_wjahr = m_wjahr;
                this.m_abgeschlossen = m_abgeschlossen;
            }

            public int ID
            {
                get { return id; }
            }

            public int M_wjahr
            {
                get { return m_wjahr; }
                set { m_wjahr = value; }
            }
            public bool M_abgeschlossen
            {
                get { return m_abgeschlossen; }
                set { m_abgeschlossen = value; }
            }
        }

        /// <summary>
        /// Die Klasse an welche TreelistStufe, PosNr übergeben werden
        /// </summary>
        public class m_stlposnr
        {
            int treelist_stufe;
            int m_posnr;
            int m_childnr;

            public m_stlposnr(int treelist_stufe, int m_posnr, int m_childnr)
            {
                this.treelist_stufe = treelist_stufe;
                this.m_posnr = m_posnr;
                this.m_childnr = m_childnr;
            }

            public int Treelist_stufe
            {
                get { return treelist_stufe; }
                set { treelist_stufe = value; }
            }

            public int M_posnr
            {
                get { return m_posnr; }
                set { m_posnr = value; }
            }

            public int M_childnr
            {
                get { return m_childnr; }
                set { m_childnr = value; }
            }
        }


        /// <summary>
        /// Die UstIDNr Prüfungs Klasse an welche Ergebniss der USTIDPrüfung übergeben wird
        /// </summary>
        public class m_ustidnr
        {
            string m_name, m_ergebniss;

            public m_ustidnr(string m_name, string m_ergebniss)
            {
                this.m_name = m_name;
                this.m_ergebniss = m_ergebniss;
            }

            public string M_name
            {
                get { return m_name; }
                set { m_name = value; }
            }
            public string M_ergebniss
            {
                get { return m_ergebniss; }
                set { m_ergebniss = value; }
            }
        }

        /// <summary>
        /// ArrayListe für Analysesummen
        /// </summary>
        private static ArrayList _list_Analysesummen;
        public static ArrayList list_Analysesummen
        {
            get { return _list_Analysesummen; }
            set { _list_Analysesummen = value; }
        }

        /// <summary>
        /// Die Analysesummen werden zwischengespeichert
        /// </summary>
        public class m_analysesummen
        {
            decimal m_summe, m_anz, m_zaehler, m_summe_mk, m_summe_ok;
            object m_analyseart;
            public m_analysesummen(decimal m_summe, decimal m_anz, decimal m_zaehler, object m_analyseart, decimal m_summe_mk, decimal m_summe_ok)
            {
                this.m_summe = m_summe;
                this.m_anz = m_anz;
                this.m_zaehler = m_zaehler;
                this.m_analyseart = m_analyseart;
                this.m_summe_mk = m_summe_mk;
                this.m_summe_ok = m_summe_ok;
            }

            public decimal M_summe
            {
                get { return m_summe; }
                set { m_summe = value; }
            }
            public decimal M_anz
            {
                get { return m_anz; }
                set { m_anz = value; }
            }
            public decimal M_zaehler
            {
                get { return m_zaehler; }
                set { m_zaehler = value; }
            }
            public object M_analyseart
            {
                get { return m_analyseart; }
                set { m_analyseart = value; }
            }
            public decimal M_summe_mk
            {
                get { return m_summe_mk; }
                set { m_summe_mk = value; }
            }
            public decimal M_summe_ok
            {
                get { return m_summe_ok; }
                set { m_summe_ok = value; }
            }


        }

    }
}
