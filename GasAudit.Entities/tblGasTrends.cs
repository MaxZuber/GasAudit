//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GasAudit.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblGasTrends
    {
        public int ID { get; set; }
        public decimal Preasure { get; set; }
        public decimal Flow { get; set; }
        public decimal Temperature { get; set; }
        public System.DateTime Time { get; set; }
    }
}
