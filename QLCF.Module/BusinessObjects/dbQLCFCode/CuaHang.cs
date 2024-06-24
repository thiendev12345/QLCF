using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace QLCF.Module.dbQLCF
{
    [DefaultClassOptions]
    [NavigationItem]
    public partial class CuaHang
    {
        public CuaHang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
