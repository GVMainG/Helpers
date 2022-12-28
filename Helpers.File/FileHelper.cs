using System;
using System.Threading.Tasks;
using IO = System.IO;



namespace Helpers.File
{
    public static class FileHelper
    {
        public static async Task<byte[]> ReadingFileAsync(string path)
        {
            using IO.FileStream fileStream = IO.File.OpenRead(path);

            byte[] result = new byte[fileStream.Length];
            await fileStream.ReadAsync(result, 0, result.Length);

            return result;
        }

        public static byte[] ReadingFile(string path)
        {
            var result = ReadingFile(path);

            return result;
        }
    }
}
