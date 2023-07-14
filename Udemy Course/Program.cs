using System;

string path = @"Documents/sistemas%20operacionais%20ta1.pdf";

Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
Console.WriteLine($"GetFileNaemWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
Console.WriteLine($"GetFullPath {Path.GetFullPath(path)}");
Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");