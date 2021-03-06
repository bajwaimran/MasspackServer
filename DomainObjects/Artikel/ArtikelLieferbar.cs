using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
//using DevExpress.ExpressApp;
using System.ComponentModel;
//using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
//using DevExpress.Persistent.Base;
using System.Collections.Generic;
//using DevExpress.ExpressApp.Model;
//using DevExpress.Persistent.BaseImpl;
//using DevExpress.Persistent.Validation;


namespace BestellErfassung.DomainObjects.Artikel
{
    //[DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public class ArtikelLieferbar : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
        public ArtikelLieferbar(Session session)
            : base(session)
        {
        }


        private DomainObjects.Artikel.Artikelstamm _Artikel;
        [Size(60)]
        public DomainObjects.Artikel.Artikelstamm Artikel
        {
            get { return _Artikel; }
            set { SetPropertyValue<DomainObjects.Artikel.Artikelstamm>("Artikel", ref _Artikel, value); }
        }

        private decimal _StueckzahlLieferbar;

        public decimal StueckzahlLieferbar
        {
            get
            {
                return _StueckzahlLieferbar;
            }
            set
            {
                SetPropertyValue("StueckzahlLieferbar", ref _StueckzahlLieferbar, value);
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
        //    this.PersistentProperty = "Paid";
        //}
    }
}
