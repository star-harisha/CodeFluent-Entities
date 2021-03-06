﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated Thursday, 13 February 2014 19:31.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    public partial class AddressService : ContactManager.Services.IAddressService
    {
        
        public virtual string Validate(ContactManager.Address address, string culture)
        {
            System.Globalization.CultureInfo cultureInfo = ConvertUtilities.ToCultureInfo(culture);
            ContactManager.Address address1 = address;
            if ((address1 == null))
            {
                return default(string);
            }
            return address1.Validate(cultureInfo);
        }
        
        public virtual bool Delete(ContactManager.Address address)
        {
            ContactManager.Address address1 = address;
            if ((address1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return address1.Delete();
        }
        
        public virtual ContactManager.Address Load(int id)
        {
            return ContactManager.Address.Load(id);
        }
        
        public virtual ContactManager.Address LoadByContact(int contactId)
        {
            return ContactManager.Address.LoadByContact(contactId);
        }
        
        public virtual bool Save(ContactManager.Address address)
        {
            ContactManager.Address address1 = address;
            if ((address1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return address1.Save();
        }
        
        public virtual bool SaveByRef(ref ContactManager.Address address)
        {
            ContactManager.Address address1 = address;
            if ((address1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            bool ret = address1.Save();
            address = address1;
            return ret;
        }
        
        public virtual ContactManager.Address LoadByEntityKey(string key)
        {
            return ContactManager.Address.LoadByEntityKey(key);
        }
        
        public virtual bool DeleteByKey(int id)
        {
            ContactManager.Address address = ContactManager.Address.Load(id);
            if ((address == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return address.Delete();
        }
        
        public virtual void SaveAll(ContactManager.AddressCollection addressCollection)
        {
            ContactManager.AddressCollection addressCollection1 = addressCollection;
            addressCollection1.SaveAll();
        }
        
        public virtual ContactManager.AddressCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            return ContactManager.AddressCollection.PageLoadAll(pageIndex, pageSize, pageOptions);
        }
        
        public virtual ContactManager.AddressCollection LoadAll()
        {
            return ContactManager.AddressCollection.LoadAll();
        }
    }
}
