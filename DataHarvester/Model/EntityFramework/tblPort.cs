//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataHarvester.Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPort
    {
        public int ID { get; set; }
        public string openPort { get; set; }
        public int resultID { get; set; }
    
        public virtual tblResult tblResult { get; set; }
    }
}
