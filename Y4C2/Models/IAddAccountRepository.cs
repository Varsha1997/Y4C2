using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y4C2.Models
{
    public interface IAddAccountRepository
    {
        IEnumerable<AddContent> AC { get; }
        IEnumerable<Y4C2.Models.Account> Account { get; }

    }
}
