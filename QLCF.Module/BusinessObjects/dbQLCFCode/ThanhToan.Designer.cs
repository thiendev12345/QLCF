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
namespace QLCF.Module.dbQLCF
{

    public partial class ThanhToan : XPObject
    {
        string fmathanhtoan;
        public string mathanhtoan
        {
            get { return fmathanhtoan; }
            set { SetPropertyValue<string>(nameof(mathanhtoan), ref fmathanhtoan, value); }
        }
        string fsotien;
        public string sotien
        {
            get { return fsotien; }
            set { SetPropertyValue<string>(nameof(sotien), ref fsotien, value); }
        }
        string ftrangthaithanhtoan;
        public string trangthaithanhtoan
        {
            get { return ftrangthaithanhtoan; }
            set { SetPropertyValue<string>(nameof(trangthaithanhtoan), ref ftrangthaithanhtoan, value); }
        }
        TaiKhoan fmataikhoan;
        [Association(@"ThanhToanReferencesTaiKhoan")]
        public TaiKhoan mataikhoan
        {
            get { return fmataikhoan; }
            set { SetPropertyValue<TaiKhoan>(nameof(mataikhoan), ref fmataikhoan, value); }
        }
        HoaDon fmahoadon;
        [Association(@"ThanhToanReferencesHoaDon")]
        public HoaDon mahoadon
        {
            get { return fmahoadon; }
            set { SetPropertyValue<HoaDon>(nameof(mahoadon), ref fmahoadon, value); }
        }
    }

}
