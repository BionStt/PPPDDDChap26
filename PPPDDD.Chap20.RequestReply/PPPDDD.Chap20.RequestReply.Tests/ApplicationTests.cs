using System;
using PPPDDD.Chap20.RequestReply.Application;
using PPPDDD.Chap20.RequestReply.Application.Infrastructure;
using PPPDDD.Chap20.RequestReply.Tests.Stubs;
using NUnit.Framework;
using StructureMap;
using Rhino.Mocks;

namespace PPPDDD.Chap20.RequestReply.Tests
{
    [TestFixture]
    public class ApplicationTests
    {
        [Test]
        public void ApplicationFindsAndInvokesTheCorrectBusinessUseCaseHandler()
        {
            ObjectFactory.ResetDefaults();

            var businessUseCaseHandler =
                MockRepository.GenerateMock<IBusinessUseCaseHandler<StubBusinessUseCase, StubBusinessUseCaseOutcome>>();
            var businessUseCase = new StubBusinessUseCase();

            ObjectFactory.Configure(
                x =>
                    x.For(typeof (IBusinessUseCaseHandler<StubBusinessUseCase, StubBusinessUseCaseOutcome>))
                        .Use(businessUseCaseHandler));

            var application = new ApplicationServiceService(ObjectFactory.Container);

            application.Process<StubBusinessUseCase, StubBusinessUseCaseOutcome>(businessUseCase);

            businessUseCaseHandler.AssertWasCalled(x => x.Handle(businessUseCase));
        }
    }
}
