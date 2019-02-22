using System;
using DevExpress.Xpo;


namespace BestellErfassung.DomainObjects.Tools
{
    //[DefaultClassOptions]
    public class Usereinstellungen : XPObject
    {
        public Usereinstellungen(Session session) : base(session) { }

        private string _SystemeinstArt;
        [Size(80)]
        public string SystemeinstArt
        {
            get { return _SystemeinstArt; }
            set { SetPropertyValue<string>("SystemeinstArt", ref _SystemeinstArt, value); }
        }

        private string _Systemeinst;
        [Size(120)]
        public string Systemeinst
        {
            get { return _Systemeinst; }
            set { SetPropertyValue<string>("Systemeinst", ref _Systemeinst, value); }
        }

        private int _UserOid;
        public int UserOid
        {
            get { return _UserOid; }
            set { SetPropertyValue<int>("UserOid", ref _UserOid, value); }
        }

    }

}
