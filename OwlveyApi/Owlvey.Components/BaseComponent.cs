using System;
using Owlvey.Components.Models;

namespace Owlvey.Components
{
    public abstract class BaseComponent 
    {
        public virtual TModel GetById<TModel>(int Id) {
            return default;
        }
        public virtual TModel Create<TModel>(TModel model) where TModel: BaseModel {
            return default;
        }
        public virtual TModel Update<TModel>(TModel model) where TModel: BaseModel{
            return default;
        }
        public virtual TModel Delete<TModel>(TModel model) where TModel: BaseModel{
            return default;
        }
    }
}
