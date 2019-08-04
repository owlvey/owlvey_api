using System;
namespace Owlvey.Core
{
    internal class AuditEntity : BaseEntity
    {
        public string AuditType { get; set; }
        public int Key { get; set; }
        public string Body { get; set; }        
    }
}
