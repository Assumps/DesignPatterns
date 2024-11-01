using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.Abstract
{
    public abstract class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Document { get; set; }

        public virtual string InfoAccount()
        {
            return $"bank account {Name} and document: {Document}";
        }
    }
}
