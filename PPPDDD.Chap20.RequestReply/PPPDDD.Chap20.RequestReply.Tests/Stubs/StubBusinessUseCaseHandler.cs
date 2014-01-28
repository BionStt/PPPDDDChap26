using PPPDDD.Chap20.RequestReply.Application.Infrastructure;

namespace PPPDDD.Chap20.RequestReply.Tests.Stubs
{
    public class StubBusinessUseCaseHandler : IBusinessUseCaseHandler<StubBusinessUseCase, StubBusinessUseCaseOutcome>
    {
        public StubBusinessUseCaseOutcome Handle(StubBusinessUseCase useCase)
        {
            return new StubBusinessUseCaseOutcome();
        }
    }
}
