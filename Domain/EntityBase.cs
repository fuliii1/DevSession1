using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class EntityBase<TEntity>
    {
        protected long _id;
        public long Id { get => _id; protected set => _id = value; }

        public virtual void Update(TEntity item)
        {
            var entityBase = item as EntityBase<TEntity>;
            entityBase.Validate();
            Mapping(item);
        }

        protected abstract void Mapping(TEntity item);

        public void Validate()
        {
            var validationErrors = new List<string>();

            ValidateModel(validationErrors);

            if (validationErrors.Any())
            {
                throw new ValidationException(GetType(), validationErrors);
            }
        }

        protected abstract void ValidateModel(ICollection<string> validationErrors);
    }
}
