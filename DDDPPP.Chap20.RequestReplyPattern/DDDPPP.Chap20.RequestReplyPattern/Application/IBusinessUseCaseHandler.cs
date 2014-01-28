using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDPPP.Chap20.RequestReplyPattern.Application
{
    public interface IBusinessUseCaseHandler<TBusinessUseCase, TResponse> 
        where TBusinessUseCase : IReturnTheResultOf<TResponse>
    {      
        TResponse Handle(TBusinessUseCase useCase);    
    }

    public class DoThisTask : IReturnTheResultOf<ResponseForThisTask>
    {}

    public class ResponseForThisTask
    {
    }

    public class SomeRequestHandler : IBusinessUseCaseHandler<DoThisTask, ResponseForThisTask>
    {
        public ResponseForThisTask Handle(DoThisTask useCase)
        {
            throw new NotImplementedException();
        }
    }

}
