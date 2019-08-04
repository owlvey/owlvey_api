using System;
using System.Collections.Generic;
using System.Text;

namespace Owlvey.Core
{
    public class FeatureEntity: BaseEntity
    {
        public string Name { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<JournalEntity> JournalEntities { get; set; }
    }
}
