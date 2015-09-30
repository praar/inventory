using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
namespace Inventory.Models
{
    public class CategoryModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        

        public int CategoryModelId { get; set; }
        public string CategoryModelName { get; set; }

        public int CategoryGUID { get; set; }
    }
}