using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        bool Save();
        void Dispose();
    }
}
