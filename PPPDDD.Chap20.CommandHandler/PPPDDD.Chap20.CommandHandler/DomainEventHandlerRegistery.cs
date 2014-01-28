using PPPDDD.Chap20.CommandHandler.Infrastructure;
using StructureMap;

namespace PPPDDD.Chap20.CommandHandler.Application
{
    public class DomainEventHandlerRegistery : IDomainEventHandlerRegistery
    {        
        public void handle<TEvent>(TEvent domain_event) where TEvent : IDomainEvent
        {
            var handler = ObjectFactory.TryGetInstance<IDomainEventHandler<TEvent>>();

            handler.action(domain_event);
        }
    }
}