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
    
    public partial class Byke
    {
        public Byke()
        {
            this.BykeImages = new HashSet<BykeImage>();
            this.Finance_Insuarance = new HashSet<Finance_Insuarance>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string CylinderCapacity { get; set; }
        public string TopSpeed { get; set; }
        public string LogoURL { get; set; }
        public Nullable<int> Price { get; set; }
        public string Engine { get; set; }
        public string Type { get; set; }
        public string MaxPower { get; set; }
        public string MaxTorque { get; set; }
        public string StartAid { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<BykeImage> BykeImages { get; set; }
        public virtual ICollection<Finance_Insuarance> Finance_Insuarance { get; set; }
    }
}
