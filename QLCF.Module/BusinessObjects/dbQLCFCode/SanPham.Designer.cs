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

    public partial class SanPham : XPObject
    {
        string fmasanpham;
        public string masanpham
        {
            get { return fmasanpham; }
            set { SetPropertyValue<string>(nameof(masanpham), ref fmasanpham, value); }
        }
        string ftensanpham;
        public string tensanpham
        {
            get { return ftensanpham; }
            set { SetPropertyValue<string>(nameof(tensanpham), ref ftensanpham, value); }
        }
        string fmotasanpham;
        public string motasanpham
        {
            get { return fmotasanpham; }
            set { SetPropertyValue<string>(nameof(motasanpham), ref fmotasanpham, value); }
        }
        int fgiatien;
        public int giatien
        {
            get { return fgiatien; }
            set { SetPropertyValue<int>(nameof(giatien), ref fgiatien, value); }
        }
        int fsoluongtrongkho;
        public int soluongtrongkho
        {
            get { return fsoluongtrongkho; }
            set { SetPropertyValue<int>(nameof(soluongtrongkho), ref fsoluongtrongkho, value); }
        }
        string floaisanpham;
        public string loaisanpham
        {
            get { return floaisanpham; }
            set { SetPropertyValue<string>(nameof(loaisanpham), ref floaisanpham, value); }
        }
        CuaHang fmacuahang;
        [Association(@"SanPhamReferencesCuaHang")]
        public CuaHang macuahang
        {
            get { return fmacuahang; }
            set { SetPropertyValue<CuaHang>(nameof(macuahang), ref fmacuahang, value); }
        }
        [Association(@"DanhGiaSanPhamReferencesSanPham")]
        public XPCollection<DanhGiaSanPham> DanhGiaSanPhams { get { return GetCollection<DanhGiaSanPham>(nameof(DanhGiaSanPhams)); } }
    }

}
