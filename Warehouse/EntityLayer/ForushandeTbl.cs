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
    
    public partial class ForushandeTbl
    {
        public ForushandeTbl()
        {
            this.VorudTbls = new HashSet<VorudTbl>();
        }
    
        public long forushandecode { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string address { get; set; }
        public string tell { get; set; }
    
        public virtual ICollection<VorudTbl> VorudTbls { get; set; }
    }
}
