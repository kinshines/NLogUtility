using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogUtility
{
    public class Logger
    {
        public static void Info(string module, string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger(module);
            logger.Info(message, args);
        }
        public static void Pure(string module, string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger(module + ".pure");
            logger.Info(message, args);
        }

        public static void Trace(string module, string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger(module);
            logger.Trace(message, args);
        }

        public static void Error(Exception ex, string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger("error");
            logger.Error(ex, message, args);
        }
        public static void Error(Exception ex)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger("error");
            logger.Error(ex);
        }

        public static void Alert(string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger("alert");
            logger.Fatal(message, args);
        }

        public static void Alert(Exception ex, string message, params object[] args)
        {
            NLog.Logger logger = NLog.LogManager.GetLogger("alert");
            logger.Fatal(ex, message, args);
        }
    }
}
