//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Molotok34.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Services()
        {
            this.ClientService = new HashSet<ClientService>();
        }
    
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public Nullable<int> IdCustomer { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Img { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    
        public virtual Categoris Categoris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
