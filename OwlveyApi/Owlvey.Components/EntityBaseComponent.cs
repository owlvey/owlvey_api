using System;
using Owlvey.Core;

namespace Owlvey.Components
{
    public class EntityBaseComponent<TEntity>: BaseComponent where TEntity: BaseEntity
    {

        public override TModel Create<TModel>(TModel model)
        {
            
            
            return base.Create(model);
        }


    }
}
