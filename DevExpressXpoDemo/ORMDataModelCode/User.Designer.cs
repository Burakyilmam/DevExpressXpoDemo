﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DevExpressXpoDemo.Xdb
{

    public partial class User : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fUsername;
        public string Username
        {
            get { return fUsername; }
            set { SetPropertyValue<string>(nameof(Username), ref fUsername, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        bool fStatus;
        public bool Status
        {
            get { return fStatus; }
            set { SetPropertyValue<bool>(nameof(Status), ref fStatus, value); }
        }
    }

}
