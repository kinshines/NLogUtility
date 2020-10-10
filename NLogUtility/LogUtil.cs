using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogUtility
{
    public class LogUtil
    {
        public static void Info(string module, string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger(module);
            logger.Info(message, args);
        }
        public static void PureInfo(string module, string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger(module + ".pure");
            logger.Info(message, args);
        }

        public static void Trace(string module, string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger(module);
            logger.Trace(message, args);
        }

        public static void Error(Exception ex, string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger("error");
            logger.Error(ex, message, args);
        }
        public static void Error(Exception ex)
        {
            Logger logger = LogManager.GetLogger("error");
            logger.Error(ex);
        }
        public static void Error(string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger("error");
            logger.Error(message, args);
        }

        public static void Alert(string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger("alert");
            logger.Fatal(message, args);
        }

        public static void Alert(Exception ex, string message, params object[] args)
        {
            Logger logger = LogManager.GetLogger("alert");
            logger.Fatal(ex, message, args);
        }
    }
}
