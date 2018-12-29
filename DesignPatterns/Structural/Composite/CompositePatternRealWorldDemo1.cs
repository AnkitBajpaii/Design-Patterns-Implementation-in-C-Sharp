using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structural.Composite.RealWorld
{
    public interface IFileComponent
    {
        void Delete();
        void PrintName();
    }

    public class LeafFile : IFileComponent
    {
        string fileName;

        public LeafFile(string fileName)
        {
            this.fileName = fileName;
        }

        public void Delete()
        {
            Console.WriteLine("File Deleted");
        }

        public void PrintName()
        {
            Console.WriteLine("File name: " + this.fileName);
        }
    }

    public class Directory : IFileComponent
    {
        string directoryName;
        List<IFileComponent> filesOrFolders = new List<IFileComponent>();

        public Directory(string directoryName)
        {
            this.directoryName = directoryName;
        }

        public void Delete()
        {
            Console.WriteLine("Directory Deleted");
        }

        public void PrintName()
        {
            Console.WriteLine("Directory name: " + this.directoryName);
        }

        public void Add(IFileComponent fileOrFolder)
        {
            this.filesOrFolders.Add(filesOrFolder);
        }


    }
}
