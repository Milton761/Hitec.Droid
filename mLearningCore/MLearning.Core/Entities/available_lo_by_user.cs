//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLearningDB
{
    using Cirrious.MvvmCross.Community.Plugins.Sqlite;
    using System;
    using System.Collections.Generic;
    
    public partial class available_lo_by_user
    {

        [PrimaryKey,AutoIncrement]
        public int id_pk { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        //public string url_package { get; set; }
        public string url_cover { get; set; }
        //public int Category_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int User_id { get; set; }
    }
}
