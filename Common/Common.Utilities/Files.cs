using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common.Utilities
{
    public class Files
    {
        public static string WriteCsvFile(string baseFolder, string fileName, IEnumerable<string[]> values)
        {
            string basePath = HttpContext.Current.Server.MapPath("~\\" + ParseBaseFolder(baseFolder));
            string filePath = basePath + "\\" + fileName;

            // create file directory if it does not exist
            // if directory already exist, ignore
            Directory.CreateDirectory(basePath);

            using (var csv = File.CreateText(filePath))
            {
                foreach (var strArray in values)
                {
                    csv.WriteLine(string.Join(",", strArray));
                }
            }

            return filePath;
        }

        public static IEnumerable<string[]> ReadCsvFile(string baseFolder, string fileName)
        {
            List<string[]> valuesList = new List<string[]>();
            string basePath = HttpContext.Current.Server.MapPath("~\\" + ParseBaseFolder(baseFolder));
            string filePath = basePath + "\\" + fileName;

            using (TextFieldParser csvReader = new TextFieldParser(filePath))
            {
                csvReader.SetDelimiters(new string[] { "," });

                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadLine().Split(',');

                    valuesList.Add(fieldData);
                }
            }

            return valuesList;
        }

        public static void DownloadFile(string baseFolder, string fileName)
        {
            HttpContext.Current.Response.ContentType = "application/octet-stream";
            HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            HttpContext.Current.Response.TransmitFile(HttpContext.Current.Server.MapPath("~/" + ParseBaseFolder(baseFolder) + "/" + fileName));
            HttpContext.Current.Response.End();
        }

        private static string ParseBaseFolder(string baseFolder)
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
