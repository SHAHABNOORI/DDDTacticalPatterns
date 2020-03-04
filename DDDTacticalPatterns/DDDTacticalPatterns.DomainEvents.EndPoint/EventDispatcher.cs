using System;
using System.Linq;
using System.Reflection;
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.EndPoint
{
    public class EventDispatcher : IEventDispatcher
    {
        public void Dispatch<T>(params T[] events) where T : IDomainEvent
        {
            var handlers = AppDomain.CurrentDomain.GetAssemblies().SelectMany(c =>
                c.GetTypes().Where(x => x.GetInterfaces().Any(y => 
                    y.IsGenericType && y.GetGenericTypeDefinition() == typeof(IEventHandler<>)))).ToList();

            foreach (var @event in events)
            {
                if (@event == null)
                    throw new ArgumentNullException(nameof(@event), "Event can not be null.");

                foreach (var handler in handlers)
                {
                    var canHandleEvent = handler.GetInterfaces()
                        .Any(x => x.IsGenericType
                                  && x.GetGenericTypeDefinition() == typeof(IEventHandler<>)
                                  && x.GenericTypeArguments[0] == @event.GetType());
                    if (!canHandleEvent) continue;
                    {
                        var instance = Activator.CreateInstance(handler);

                        var method = instance.GetType().GetRuntimeMethods().First(x => x.Name.Equals("Handle"));
                        var parametersArray = new object[] { @event };
                        method.Invoke(instance, parametersArray);
                    }

                }
            }
        }
    }
}
