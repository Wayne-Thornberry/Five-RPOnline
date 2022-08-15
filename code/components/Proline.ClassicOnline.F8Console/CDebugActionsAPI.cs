﻿using Proline.Resource.Logging;
using Proline.ServerAccess.IO;
using System;
using Console = Proline.Resource.Console;

namespace Proline.ClassicOnline.CDebugActions
{
    public class CDebugActionsAPI : ICDebugActionsAPI
    {
        private static Log _log => new Log();

        public void LogDebug(object obj, bool outputToServer = false)
        {
            try
            {
                // Log in memory
                var line = _log.Debug(obj.ToString());
                // Output to console
                Console.WriteLine(line);
                if (outputToServer)
                    ServerConsole.WriteLine(line);
                // Duplciate to server
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LogWarn(object obj, bool outputToServer = false)
        {
            try
            {
                // Log in memory
                var line = _log.Warn(obj.ToString());
                // Output to console
                Console.WriteLine(line);
                if (outputToServer)
                    ServerConsole.WriteLine(line);
                // Duplciate to server
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LogInfo(object obj, bool outputToServer = false)
        {
            try
            {
                // Log in memory
                var line = _log.Info(obj.ToString());
                // Output to console
                Console.WriteLine(line);
                if (outputToServer)
                    ServerConsole.WriteLine(line);
                // Duplciate to server
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LogError(object obj, bool outputToServer = false)
        {
            try
            {
                // Log in memory
                var line = _log.Error(obj.ToString());
                // Output to console
                Console.WriteLine(line);
                if (outputToServer)
                    ServerConsole.WriteLine(line);
                // Duplciate to server
            }
            catch (Exception e)
            {

                throw;
            }
        }

    }
}
