using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;



namespace BestellErfassung.DomainObjects.Tools
{
    //[DefaultClassOptions]
    public class Sequence : XPBaseObject
    {
        public Sequence(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        // Fields...
        private string _TypeName;
        [Key]
        public string TypeName
        {
            get { return _TypeName; }
            set { SetPropertyValue<string>("TypeName", ref _TypeName, value); }
        }

        private long _NextId;
        public long NextId
        {
            get { return _NextId; }
            set { SetPropertyValue<long>("NextId", ref _NextId, value); }
        }
    }

}
