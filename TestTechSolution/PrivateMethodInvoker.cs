using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechSolution
{
    /// <summary>
    /// Utility class for invoking private methods using reflection.
    /// </summary>
    public static class PrivateMethodInvoker
    {
        /// <summary>
        /// Invokes a private method on the specified instance using reflection.
        /// </summary>
        /// <typeparam name="T">The return type of the invoked method.</typeparam>
        /// <param name="instance">The instance on which to invoke the method.</param>
        /// <param name="methodName">The name of the private method.</param>
        /// <param name="parameters">The parameters to pass to the method.</param>
        /// <returns>The result of invoking the private method.</returns>
        public static T InvokePrivateMethod<T>(object instance, string methodName, params object[] parameters)
        {
            var methodInfo = instance.GetType().GetMethod(methodName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (T)methodInfo.Invoke(instance, parameters);
        }
    }
}
