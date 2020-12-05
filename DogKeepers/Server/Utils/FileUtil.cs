using System.IO;
using DogKeepers.Server.Interfaces.Utils;

namespace DogKeepers.Server.Utils
{
    public class FileUtil : IFileUtil
    {
        public byte[] GetFile(string path)
        {
            if(!File.Exists(path))
                return null;
            
            return File.ReadAllBytes(path);
        }
    }
}