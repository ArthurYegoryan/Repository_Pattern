using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAddressRepository Address { get; }
        IEmailRepository Email { get; }
        IPersonRepository Person { get; }
        int Save();
    }
}
