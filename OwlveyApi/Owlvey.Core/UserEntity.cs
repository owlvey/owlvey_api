using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Owlvey.Core
{
    public class UserEntity: BaseEntity
    {
        public string Email { get; set; }        
        

        internal void Update(string email) {
            this.Email = email;
        }
        
    }
}
