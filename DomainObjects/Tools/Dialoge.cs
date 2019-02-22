using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;


namespace BestellErfassung.DomainObjects.Tools
{
    //[DefaultClassOptions]
    public class Dialoge : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
        public Dialoge(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
        }

        private string _Dialog;
        [Size(80)]
        public string Dialog
        {
            get { return _Dialog; }
            set { SetPropertyValue<string>("Dialog", ref _Dialog, value); }
        }

        private string _Sachbearbeiter;
        [Size(6)]
        public string Sachbearbeiter
        {
            get { return _Sachbearbeiter; }
            set { SetPropertyValue<string>("Sachbearbeiter", ref _Sachbearbeiter, value); }
        }

        private bool _Abschalten;
        public bool Abschalten
        {
            get { return _Abschalten; }
            set { SetPropertyValue<bool>("Abschalten", ref _Abschalten, value); }
        }

    }
}
