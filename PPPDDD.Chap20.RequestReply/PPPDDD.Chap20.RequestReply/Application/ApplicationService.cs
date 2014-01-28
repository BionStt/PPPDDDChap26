using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPPDDD.Chap20.RequestReply.Application.Contracts;
using PPPDDD.Chap20.RequestReply.Application.Infrastructure;
using StructureMap;

namespace PPPDDD.Chap20.RequestReply.Application
{
    public class ApplicationServiceService : IApplicationService
    {
        private IContainer _container;

        public ApplicationServiceService(IContainer container)
        {
            _container = container;
        }

        public T Process<TRequest, T>(TRequest command) where TRequest : IBusinessUseCase<T>
        {
            var handler = _container.GetInstance<IBusinessUseCaseHandler<TRequest, T>>();

            return handler.Handle(command);
        }
    }
}
