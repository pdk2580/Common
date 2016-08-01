using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common.Utilities.Log
{
    abstract class BaseLog
    {
        public string baseFolder { get; set; }
        public string fileName { get; set; }

        public void Write(string message, string logType)
        {
            string basePath = HttpContext.Current.Server.MapPath("~\\" + ParseBaseFolder(baseFolder));
            string filePath = basePath + "\\" + fileName;

            Directory.CreateDirectory(basePath);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " " + logType + " " + message);
            }
        }

        private string ParseBaseFolder(string baseFolder)
        {
            string tempStr = baseFolder;

            if (tempStr.StartsWith("/") || tempStr.StartsWith("\\"))
                tempStr = tempStr.Substring(1);
            if (tempStr.EndsWith("/") || tempStr.EndsWith("\\"))
                tempStr = tempStr.Substring(0, tempStr.Length - 1);

            return tempStr;
        }
    }
}
