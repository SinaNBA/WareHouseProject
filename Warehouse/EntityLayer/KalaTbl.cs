//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class KalaTbl
    {
        public KalaTbl()
        {
            this.KhorujTbls = new HashSet<KhorujTbl>();
            this.VorudTbls = new HashSet<VorudTbl>();
        }
    
        public long kalacode { get; set; }
        public string moshakhasat { get; set; }
        public string sherkat { get; set; }
        public string code { get; set; }
    
        public virtual ICollection<KhorujTbl> KhorujTbls { get; set; }
        public virtual ICollection<VorudTbl> VorudTbls { get; set; }
    }
}
