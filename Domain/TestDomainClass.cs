using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TestDomainClass : EntityBase<TestDomainClass>
    {
        protected override void Mapping(TestDomainClass item)
        {
            throw new NotImplementedException();
        }

        protected override void ValidateModel(ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }
    }
}
