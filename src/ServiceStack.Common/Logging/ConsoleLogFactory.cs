#if !NETFX_CORE && !PCL
using System;

namespace ServiceStack.Logging
{
    /// <summary>
    /// Creates a Console Logger, that logs all messages to: System.Console
    /// 
    /// Made public so its testable
    /// </summary>
	public class ConsoleLogFactory : ILogFactory
    {
        public ILog GetLogger(Type type)
        {
            return new ConsoleLogger(type);
        }

        public ILog GetLogger(string typeName)
        {
			return new ConsoleLogger(typeName);
        }
    }
}
#endif
