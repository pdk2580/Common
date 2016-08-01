# Common

## Files Class
Method|Return|Description
------|------|-----------
WriteCsvFile(string baseFolder, string fileName, IEnumerable\<string[]> values)|string|Write list of string array into CSV file format in specified directory
ReadCsvFile(string baseFolder, string fileName)|IEnumerable\<string[]>|Read CSV file from specified directory
DownloadFile(string baseFolder, string fileName)|-|Trigger download from specified file directory

## Versions

### v0.1.0
- Files class added
