//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BajajProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finance_Insuarance
    {
        public int BykeID { get; set; }
        public int InsuaranceCompanyID { get; set; }
        public int FinanceCompanyID { get; set; }
    
        public virtual Byke Byke { get; set; }
        public virtual FinanceCompany FinanceCompany { get; set; }
        public virtual InsuaranceCompany InsuaranceCompany { get; set; }
    }
}