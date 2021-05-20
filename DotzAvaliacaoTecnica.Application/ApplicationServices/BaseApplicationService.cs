using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;

namespace DotzAvaliacaoTecnica.Application.ApplicationServices
{
    public class BaseApplicationService
    {
        private readonly IUnitOfWork _uow;
        public BaseApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Commit()
        {
            
            if (_uow.Save()) return true;

            
            return false;
        }
    }
}
