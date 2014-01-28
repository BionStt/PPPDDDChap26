using PPPDDD.Chap20.RequestReply.Application.Infrastructure;

namespace PPPDDD.Chap20.RequestReply.Application
{
    public interface IApplicationService
    {
        T Process<TRequest, T>(TRequest command) where TRequest : IBusinessUseCase<T>;
    }
}