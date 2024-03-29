﻿using System;
using System.Diagnostics;
using System.IO;
using RoutineManager.MVVM.Model;

namespace RoutineManager.MVVM.Service
{
    public class StartupService : IStartupService
    {
        public bool startProcess(string processName)
        {
            Process process = startProcessWithShell(processName);
            return (process != null);
        }

        protected virtual Process startProcessWithShell(string processName)
        {
            return Process.Start(new ProcessStartInfo($"{processName}") { UseShellExecute = true });
        }

        //Returns true if the given string is a valid HTTP or HTTPS url.
        public bool isValidURL(string str)
        {
            Uri uriResult;
            return Uri.TryCreate(str, UriKind.Absolute, out uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        //Returns true if the given string is a valid absolute file path in the user's system.
        public bool isValidFilePath(string str)
        {
            return Directory.Exists(str);
        }

        public bool readMonitorDataFromFile(string filePath)
        {
            if (!isValidFilePath(filePath))
                return false;

            //Deserialize and start processes
            return true;
        }

    }
}
