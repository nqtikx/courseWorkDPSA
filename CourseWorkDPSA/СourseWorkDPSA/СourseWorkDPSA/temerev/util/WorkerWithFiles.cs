using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Cursac.temerev.util
{
    class WorkerWithFiles
    {
        const string pathFile = @"C:\Users\user\Desktop\Учёба\Семестр 3\Курсовая работа с++\курсач1\СourseWorkDPSA\СourseWorkDPSA\DataFile.txt";
        const string compressedFilePath = @"C:\Users\user\Desktop\Учёба\Семестр 3\Курсовая работа с++\курсач1\СourseWorkDPSA\СourseWorkDPSA\CompressedDataFile.gz";

        public static void WriteToFile(string str)
        {
            using (FileStream objFile = new FileStream(pathFile, FileMode.Create))
            {
                using (StreamWriter objWriter = new StreamWriter(objFile))
                {
                    objWriter.Write(str);
                }
            }
        }

        public static long GetSizeOfFile()
        {
            return new FileInfo(pathFile).Length * 8;
        }

        public static void CompressFile()
        {
            using (FileStream originalFileStream = new FileStream(pathFile, FileMode.Open))
            {
                using (FileStream compressedFileStream = File.Create(compressedFilePath))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}
