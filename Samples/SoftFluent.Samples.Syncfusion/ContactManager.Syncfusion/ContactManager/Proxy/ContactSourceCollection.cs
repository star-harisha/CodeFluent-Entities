﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Proxy
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Wednesday, 12 February 2014 15:18.
    // Build:1.0.61214.0762
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    [System.ComponentModel.DataObjectAttribute()]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.CollectionTypeConverter))]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Namespace="http://schemas.mycie.com/contactmanager/contactmanager", ItemName="ContactSource")]
    public partial class ContactSourceCollection : CodeFluent.Runtime.ServiceModel.CodeFluentEntityCollection<int, ContactManager.Proxy.ContactSource>, CodeFluent.Runtime.ServiceModel.ICodeFluentSet, CodeFluent.Runtime.Diagnostics.ITraceable
    {
        
        [System.NonSerializedAttribute()]
        private System.Collections.Hashtable _relations = new System.Collections.Hashtable();
        
        public ContactSourceCollection()
        {
        }
        
        public ContactSourceCollection(string contextName, System.ServiceModel.Channels.IChannel channel, string pageMethodName, CodeFluent.Runtime.PageOptions pageOptions, params object[] arguments) : 
                base(contextName, channel, pageMethodName, pageOptions, arguments)
        {
        }
        
        System.Collections.IDictionary CodeFluent.Runtime.ServiceModel.ICodeFluentSet.Relations
        {
            get
            {
                return this._relations;
            }
        }
        
        public virtual void SaveAll()
        {
            ContactManager.Proxy.ContactSourceCollection changed = new ContactManager.Proxy.ContactSourceCollection();
            this.FindAllPending(changed);
            if ((changed.Count <= 0))
            {
                return;
            }
            ContactManager.Proxy.ContactSource.WcfClient.Current.Channel.SaveAll(changed);
            this.Commit();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static ContactManager.Proxy.ContactSourceCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            ContactManager.Proxy.ContactSourceCollection collection = ContactManager.Proxy.ContactSource.WcfClient.Current.Channel.PageLoadAll(pageIndex, pageSize, pageOptions);
            return collection;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static ContactManager.Proxy.ContactSourceCollection LoadAll()
        {
            ContactManager.Proxy.ContactSourceCollection collection = new ContactManager.Proxy.ContactSourceCollection(MyCie.ContactManager.Proxy.Constants.MyCie_ContactManagerStoreName, ((System.ServiceModel.Channels.IChannel)(ContactManager.Proxy.ContactSource.WcfClient.Current.Channel)), "PageLoadAll", null);
            collection.LoadKnownItems();
            return collection;
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write(string.Concat("Count=", this.Count));
            writer.Write("]");
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.Diagnostics.ITraceable.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(ContactManager.Proxy.ContactSource contactSource)
        {
            if ((contactSource == null))
            {
                return false;
            }
            return contactSource.Save();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(ContactManager.Proxy.ContactSource contactSource)
        {
            if ((contactSource == null))
            {
                return false;
            }
            return contactSource.Delete();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(ContactManager.Proxy.ContactSource contactSource)
        {
            if ((contactSource == null))
            {
                return false;
            }
            return contactSource.Save();
        }
        
        protected override void Add(int key, ContactManager.Proxy.ContactSource item)
        {
            base.Add(key, item);
        }
        
        protected override void Insert(int index, int key, ContactManager.Proxy.ContactSource item)
        {
            base.Insert(index, key, item);
        }
        
        public override bool Remove(int key)
        {
            ContactManager.Proxy.ContactSource item = ((ContactManager.Proxy.ContactSource)(base[key]));
            if ((item == null))
            {
                return false;
            }
            bool ret = base.Remove(key);
            return ret;
        }
        
        protected virtual void Relate(ContactManager.Proxy.ContactSource item, CodeFluent.Runtime.CodeFluentRelationType relationType)
        {
            ((CodeFluent.Runtime.ServiceModel.ICodeFluentSet)(this)).Relations[item] = relationType;
        }
        
        public new virtual ContactManager.Proxy.ContactSourceCollection Clone(bool deep)
        {
            ContactManager.Proxy.ContactSourceCollection ret = new ContactManager.Proxy.ContactSourceCollection();
            this.CopyTo(ret, deep);
            return ret;
        }
        
        protected override string GetUserMessage(System.Globalization.CultureInfo culture, CodeFluent.Runtime.UserExceptionType type, string name, object[] args)
        {
            return MyCie.ContactManager.Proxy.Resources.Manager.GetUserMessage(culture, type, name, args);
        }
    }
}
