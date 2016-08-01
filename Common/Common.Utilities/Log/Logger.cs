using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities.Log
{
    public class Logger
    {
        string baseFolder { get; set; }
        string fileName { get; set; }

        public Logger(string baseFolder, string fileName)
        {
            this.baseFolder = baseFolder;
            this.fileName = fileName;
        }

        public void Info(string message)
        {
            InfoLog infoLog = new InfoLog { baseFolder = this.baseFolder, fileName = this.fileName };
            infoLog.Write(message);
        }

        public void Debug(string message)
        {
            DebugLog debugLog = new DebugLog { baseFolder = this.baseFolder, fileName = this.fileName };
            debugLog.Write(message);
        }

        public void Warn(string message)
        {
            WarnLog warnLog = new WarnLog { baseFolder = this.baseFolder, fileName = this.fileName };
            warnLog.Write(message);
        }

        public void Error(string message)
        {
            ErrorLog errorLog = new ErrorLog { baseFolder = this.baseFolder, fileName = this.fileName };
            errorLog.Write(message);
        }

        public void Fatal(string message)
        {
            FatalLog fatalLog = new FatalLog { baseFolder = this.baseFolder, fileName = this.fileName };
            fatalLog.Write(message);
        }
    }
}
