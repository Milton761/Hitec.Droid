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
    using System;
    using System.Collections.Generic;
    
    public partial class LearningObject
    {
        public int id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public string description { get; set; }      
        public string url_cover { get; set; }
        public string url_background { get; set; }
        public int Publisher_id { get; set; }
        public int color_id { get; set; }    
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
