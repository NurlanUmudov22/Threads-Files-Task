using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Threads_Task_Files.Extensions
{
    internal static class FileExtensions
    {
        public static string GenerateFullPath(this string path, string fileName)
        {
            return $"{path}\\{fileName}";
        }
    }
}
