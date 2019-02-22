using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
//using DevExpress.ExpressApp;
using System.ComponentModel;
//using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
//using DevExpress.Persistent.Base;
//using System.Collections.Generic;
//ing DevExpress.ExpressApp.Model;
//ing DevExpress.Persistent.BaseImpl;
//using DevExpress.Persistent.Validation;

namespace BestellErfassung.DomainObjects.Tools
{
    //[DefaultClassOptions]
    [NonPersistent]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public class Dateiimport_NP : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
        public Dateiimport_NP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
        }

        private string _Timestamp;
        [Size(20)]
        public string Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<string>("Timestamp", ref _Timestamp, value); }
        }

        private string _Dateinamekopf;
        [Size(200)]
        public string Dateinamekopf
        {
            get { return _Dateinamekopf; }
            set { SetPropertyValue<string>("Dateinamekopf", ref _Dateinamekopf, value); }
        }

        private string _DateinamePos;
        [Size(200)]
        public string DateinamePos
        {
            get { return _DateinamePos; }
            set { SetPropertyValue<string>("DateinamePos", ref _DateinamePos, value); }
        }

    }
}
