//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoAppZhdan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Material = new HashSet<Material>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string INN { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> QualityRating { get; set; }
        public string SupplierType { get; set; }
    
        public virtual ICollection<Material> Material { get; set; }
    }
}