using System;
using DevExpress.Xpo;

namespace BestellErfassung.Helpers
{
    public class Parent : XPObject
    {
        public Parent(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetPropertyValue("Name", ref _Name, value);
            }
        }
        [Association("ParentChildren"), Aggregated]
        public XPCollection<BestellErfassung.Helpers.Child> Children
        {
            get { return GetCollection<BestellErfassung.Helpers.Child>("Children"); }
        }
    }
    public class Child : XPObject
    {
        public Child(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetPropertyValue("Name", ref _Name, value);
            }
        }
        private BestellErfassung.Helpers.Parent _Parent;
        [Association("ParentChildren")]
        public BestellErfassung.Helpers.Parent Parent
        {
            get
            {
                return _Parent;
            }
            set
            {
                SetPropertyValue("Parent", ref _Parent, value);
            }
        }
    }
}