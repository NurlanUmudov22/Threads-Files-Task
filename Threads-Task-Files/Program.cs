using Threads_Task_Files.Controllers;

FileController fileController = new FileController();

//await fileController.ReadDataAsync();
//await fileController.CreateFileWithContentAsync();
//await fileController.DeleteFileAsync();

await fileController.CreateFileWithContentAsync();
