using System;
using System.IO;

namespace Server
{
    public static class Log
    {
        private static string _fileAddress = @"../../logs/log.txt";

        public static void WriteMessage(string message, string action)
        {
            string _message = String.Format("[{0}][{1}]", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            _message += "[" + action +"]\n";
            _message += "\t[" + message + "]";
            _message += '\n';
            File.AppendAllText(_fileAddress, _message);
        }
    }
}
