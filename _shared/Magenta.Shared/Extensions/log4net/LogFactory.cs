using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Diagnostics;

namespace log4net
{
    /// <summary>
    /// Represents factory for log4net loggers
    /// </summary>
    public static class LogFactory
    {
        #region Static methods

        /// <summary>
        /// Creates log4net logger for the calling type
        /// </summary>        
        public static ILog Create()
        {
            return Create(new StackTrace(1).GetFrame(0).GetMethod().ReflectedType);
        }

        /// <summary>
        /// Creates log4net logger for the specified type
        /// </summary>        
        public static ILog Create(Type type)
        {
            return LogManager.GetLogger(type);
        } 

        #endregion
    }

}
