using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task_2
{
    public class FileManager : IDisposable
    {
      
        private readonly string _path;
        private FileStream _fileStream;

        public FileManager(string path)
        {
            _path = path;
            _fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void WriteToFile(string data)
        {
            using (var writer = new StreamWriter(_fileStream))
            {
                writer.Write(data);
            }
        }

        public string ReadFromFile()
        {
            using (var reader = new StreamReader(_fileStream))
            {
                return reader.ReadToEnd();
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }

        bool disposed;
        protected void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //Clean up managed code
                _fileStream.Dispose();
            }
            //clean up unmanaged code
            disposed = true;
        }
        //public void Dispose()
        //{
        //    if (_fileStream != null)
        //    {
        //        _fileStream.Dispose();
        //        _fileStream = null;
        //    }
        //}

        ~FileManager()
        {
            Dispose(false);
        }

    }
}
