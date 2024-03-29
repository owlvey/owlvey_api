﻿using System;
namespace Owlvey.Core
{
    public class IndicatorEntity: BaseEntity
    {
        public virtual FeatureEntity Feature { get; set; }
        public virtual JournalEntity Journal { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
    }
}
