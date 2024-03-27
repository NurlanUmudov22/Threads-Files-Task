using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threads_Task_Files.Extensions;
using Threads_Task_Files.Services;
using Threads_Task_Files.Services.Interfaces;

namespace Threads_Task_Files.Controllers
{
    internal class FileController
    {

        private readonly IFileService _fileService;

        public FileController()
        {
            _fileService = new FileService();
        }


        public async Task ReadDataAsync() 
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Users\\nurlanmu\\Desktop\\file1\\test10.txt");
            await Console.Out.WriteLineAsync(result);
        }

        public async Task CreateFileWithContentAsync()
        {
            await Console.Out.WriteLineAsync("Add path:");
            string path = Console.ReadLine();

            await Console.Out.WriteLineAsync("Add file name");
            string fileName = Console.ReadLine();

            await Console.Out.WriteLineAsync("Add your text");
            string text = Console.ReadLine();


            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath, text);
        }


        public async Task DeleteFileAsync()
        {
            await _fileService.DeleteFileAsync("C:\\Users\\nurlanmu\\Desktop\\file1\\testsilmek.txt");
        }





    }
}
