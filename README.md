# Common

## Files Class
Method|Return|Description
------|------|-----------
WriteCsvFile(string baseFolder, string fileName, IEnumerable\<string[]> values)|string|Write list of string array into CSV file format in specified directory
ReadCsvFile(string baseFolder, string fileName)|IEnumerable\<string[]>|Read CSV file from specified directory
DownloadFile(string baseFolder, string fileName)|-|Trigger download from specified file directory

## Logger Class
Constructor|Description
-----------|-----------
Logger(string baseFolder, string fileName)|Create Logger object with baseFolder and fileName parameters

Method|Return|Description
------|------|-----------
Info(string message)|-|Write log message with INFO tag
Debug(string message)|-|Write log message with DEBUG tag
Warn(string message)|-|Write log message with WARN tag
Error(string message)|-|Write log message with ERROR tag
Fatal(string message)|-|Write log message with FATAL tag

### Logger Class Example
```c#
Logger logger = new Logger("/logFolder/", "log.txt");
logger.Info("Enter your message here.");
```

## Versions

### v0.2.0
- Logger class added

### v0.1.0
- Files class added
