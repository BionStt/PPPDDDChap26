namespace PPPDDD.Chap20.RequestReply.Application.Infrastructure
{
    public interface IBusinessUseCaseHandler<TBusinessUseCase, TResponse> 
        where TBusinessUseCase : IBusinessUseCase<TResponse>
    {      
        TResponse Handle(TBusinessUseCase useCase);    
    }
}
