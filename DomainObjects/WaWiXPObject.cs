using System;
using DevExpress.Xpo;
//using BestellErfassung.DomainObjects.Systemdaten;
//using BestellErfassung.FileHelpers;
//using System.Windows.Forms;
using DevExpress.Xpo.Metadata;
//using DevExpress.ExpressApp.Utils;
using System.Collections.Generic;
//using DevExpress.ExpressApp;
using System.ComponentModel;

namespace BestellErfassung.DomainObjects
{
    [NonPersistent]
    public class WaWiXPObject : XPObject
    {
        public WaWiXPObject(Session session) : base(session) { } 

        //public class AuditMemberInfo
        //{
        //    internal AuditMemberInfo(XPMemberInfo memberInfo, object originalValue)
        //    {
        //        _memberInfo = memberInfo;
        //        _originalValue = originalValue;
        //    }

        //    private XPMemberInfo _memberInfo;
        //    public XPMemberInfo MemberInfo
        //    {
        //        get { return _memberInfo; }
        //    }

        //    private object _originalValue;
        //    public object OriginalValue
        //    {
        //        get { return _originalValue; }
        //    }
        //}

        //private DevExpress.Xpo.Metadata.Helpers.MemberInfoCollection _ChangedMembers;
        //public DevExpress.Xpo.Metadata.Helpers.MemberInfoCollection ChangedMembers
        //{
        //    get
        //    {
        //        if (_ChangedMembers == null)
        //        {
        //            _ChangedMembers = new DevExpress.Xpo.Metadata.Helpers.MemberInfoCollection(ClassInfo);
        //        }
        //        return _ChangedMembers;
        //    }
        //}

        //private Dictionary<string, AuditMemberInfo> _ChangedMembers_2;
        //public Dictionary<string, AuditMemberInfo> ChangedMembers_2
        //{
        //    get
        //    {
        //        if (_ChangedMembers_2 == null)
        //        {
        //            _ChangedMembers_2 = new Dictionary<string, AuditMemberInfo>();
        //        }
        //        return _ChangedMembers_2;
        //    }
        //}

        
        private bool _IsDirty;
        [NonPersistent]
        public bool IsDirty
        {
            get { return _IsDirty; }
            set { SetPropertyValue<bool>("IsDirty", ref _IsDirty, value); }
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            if (!IsLoading && !IsDeleted && !IsSaving)
            {
                IsDirty = true;
                //XPMemberInfo Member = ClassInfo.GetPersistentMember(propertyName);
                //if (Member != null && !ChangedMembers.Contains(Member))
                //{
                //    AuditMemberInfo Auditvalue = new AuditMemberInfo(Member, oldValue);
                //    ChangedMembers.Add(Member);
                //    ChangedMembers_2.Add(propertyName, Auditvalue);
                //}
            }
            base.OnChanged(propertyName, oldValue, newValue);
        }

        protected override void OnSaving()
        {
            if (!IsLoading && !IsDeleted)
            {
                IsDirty = false;
            }
            base.OnSaving();
        }

        //protected override void OnSaved()
        //{
        //    if (!IsLoading && !IsDeleted)
        //    {
                //using (UnitOfWork AuditUOW = new UnitOfWork())
                //{
                //    foreach (AuditMemberInfo item in ChangedMembers_2.Values)
                //    {
                //        AuditTrail NewAudit = new AuditTrail(AuditUOW);
                //        XPMemberInfo memberInfo = item.MemberInfo;
                //        NewAudit.FieldName = memberInfo.Name;
                //        object Value = Evaluate(memberInfo.Name);

                //        if (memberInfo.MappingFieldSize != SizeAttribute.Unlimited)
                //        {
                //            if (Value != null)
                //            {
                //                NewAudit.NewValue = Value.ToString();
                //            }
                //            else
                //            {
                //                NewAudit.NewValue = "";
                //            }

                //            if (item.OriginalValue != null)
                //            {
                //                NewAudit.OldValue = item.OriginalValue.ToString();
                //            }
                //            else
                //            {
                //                NewAudit.OldValue = "";
                //            }

                //            Form CurrentForm = Form.ActiveForm;
                //            if (CurrentForm != null)
                //            {
                //                if (CurrentForm.ActiveMdiChild != null)
                //                    NewAudit.FormName = CurrentForm.ActiveMdiChild.Text;
                //            }
                //            NewAudit.Aktion = "Change";
                //            NewAudit.KeyValue = Evaluate(XPObject.Fields.Oid).ToString();
                //            NewAudit.Datumzeit = DateTime.Now;
                //            NewAudit.UserOid = SystemSettingsHelper.LoggedInUserOid;
                //            NewAudit.SachbearbeiterKZ = SystemSettingsHelper.LoggedInUserKz;
                //            NewAudit.Datenbank = ClassInfo.ClassType.Name;
                //            NewAudit.Save();
                //        }
                //    }
                //    AuditUOW.CommitChanges();
                //    ChangedMembers.Clear();
                //    ChangedMembers_2.Clear();
                //}
                //base.OnSaved();
        //    }
        //}

     
        //protected override XPCollection CreateCollection(XPMemberInfo property)
        //{
        //    XPCollection collection = base.CreateCollection(property);
        //    collection.DeleteObjectOnRemove = true;
        //    return collection;
        //}

    }
}
