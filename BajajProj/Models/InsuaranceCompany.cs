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
    
    public partial class InsuaranceCompany
    {
        public InsuaranceCompany()
        {
            this.Finance_Insuarance = new HashSet<Finance_Insuarance>();
            this.FinanceCompanies = new HashSet<FinanceCompany>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Finance_Insuarance> Finance_Insuarance { get; set; }
        public virtual ICollection<FinanceCompany> FinanceCompanies { get; set; }
    }
}
