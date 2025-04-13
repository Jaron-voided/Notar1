namespace Notar1;

class Pack
{
    int Align16(int value)
    {
        return (value + 0xF) & ~0xF;
    }

    NotarHeader CreateHeader(string directoryPath)
    {
        if (Directory.Exists(directoryPath))
        {
            NotarHeader header = new NotarHeader();
            var dirs = Directory.GetDirectories(directoryPath);
            header.DirectoryCount = (ushort)dirs.Length;
            ushort FileCount = 0;
            ushort fileListSize = 0;
            foreach (var dir in dirs)
            {
                DirectoryInfo directory = new DirectoryInfo(dir)
                FileCount += (ushort)directory.GetFiles().Length;
                foreach (var file in Directory.GetFiles(dir))
                {
                    fileListSize += (ushort)file.Length;
                }
            }
            header.FileCount = (ushort)FileCount;
            header.FileListSize = (ushort)fileListSize;
            

        }
        else
        {
            Console.WriteLine("Directory doesn't exist!");
        }
        
    }
}