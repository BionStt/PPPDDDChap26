using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPPDDD.Chap20.RequestReply.Application.Infrastructure;
using PPPDDD.Chap20.RequestReply.Tests.Stubs;
using NUnit.Framework;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace PPPDDD.Chap20.RequestReply.Tests
{
    [TestFixture]
    public class StructureMapConfigurationTests
    {
        [Test]
        public void StructureMapShouldBeAbleToScanForAllIBusinessUseCaseHandlers()
        {
            ObjectFactory.ResetDefaults();
            ObjectFactory.Configure(c => c.AddRegistry<BusinessUseCaseHandlerRegistry>());

            var handler = ObjectFactory.GetInstance<IBusinessUseCaseHandler<StubBusinessUseCase, StubBusinessUseCaseOutcome>>();

            Assert.IsInstanceOf<StubBusinessUseCaseHandler>(handler);
        }

        public class BusinessUseCaseHandlerRegistry : Registry
        {
            public BusinessUseCaseHandlerRegistry()
            {
                Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.ConnectImplementationsToTypesClosing(typeof(IBusinessUseCaseHandler<,>));
                });
            }
        }
    }
}
