using System;
using System.Collections.Generic;
using System.Text;

namespace Owlvey.Core
{
    public class CustomerEntity : BaseEntity
    {
        public string Name { get; set; }

        public static CustomerEntity Create(string name) {
            return new CustomerEntity() {
                Name = name
            };
        }
    }
}
