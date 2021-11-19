using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class County : EntityBase<County>
    {
        protected override void Mapping(County item)
        {
            throw new NotImplementedException();
        }

        protected override void ValidateModel(ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }
    }
}
