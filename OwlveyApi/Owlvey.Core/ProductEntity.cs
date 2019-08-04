using System;
using System.Collections.Generic;
using System.Text;

namespace Owlvey.Core
{
    public class ProductEntity : BaseEntity
    {        
        public string Name { get; set; }

        public string Description { get; set; }

        public CustomerEntity Customer { get; set; }

        public virtual ICollection<ServiceEntity> Services { get; set; }

        public virtual ICollection<FeatureEntity> Features { get; set; }
    }
}
