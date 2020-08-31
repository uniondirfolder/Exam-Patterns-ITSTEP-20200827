using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem.Model
{
    public enum FileExtension
    {
        sps
    }
    public interface IFile
    {
        bool Read();
        bool Write();
        bool Close();
    }

    class FileFactoryMethod
    {
        public abstract class FileAbstractFactory 
        {
            public abstract IFile CreateOrOpenFile(string file);
        }

        public class SPSFileFactory : FileAbstractFactory
        {
            string filename;
            public override IFile CreateOrOpenFile(string file)
            {
                return new SPSFile(filename);
            }

        }

        [Serializable]
        public class SPSFile : IFile
        {
            [NonSerialized]
            string file;
            bool change = false;
            private List<SPSTask> db = new List<SPSTask>();

            public List<SPSTask> Context { get { return db; } }
            public void CreateNewDb(string path) 
            {
                try
                {
                    var t = FileFactory.CreateFile(FileExtension.sps, path);
                    t.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            public bool Read()
            {
                bool result = false;
                var len = new FileInfo(file);
                if (len.Length != 0)
                {
                    if (Path.GetExtension(file) == FileExtension.sps.ToString())
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                        {
                            db = (List<SPSTask>)formatter.Deserialize(fs);
                            result = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Wrong file extension!");
                    }
                }
                return result;
            }
            public bool Write()
            {
                bool result = false;
                if (db.Count != 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, db);
                        result = true;
                    }
                }
                return result;
            }

            public bool Close() 
            {
                bool close = Write();
                if (close == false)
                    throw new Exception("False db access!");
                db = null;
                file = "";
                return close;
            }

            public bool Open(string file) 
            {
                if (db != null) { Close(); }
                if (Path.GetExtension(file) != FileExtension.sps.ToString()) { throw new Exception("Wrong file extension!"); }
                if (!File.Exists(file)) { throw new Exception("File not exists!"); }
                this.file = file;
                return Read();
            }
            public SPSFile(string path)
            {
                this.file = file ?? throw new ArgumentNullException(paramName: nameof(file));

                if (Path.GetExtension(file) != FileExtension.sps.ToString())
                    throw new Exception("Incorrect file extension!");

                if (!File.Exists(file))
                {
                    var f = File.Create(file);
                    f.Close();
                }
            }
        }

        public class FileFactory
        {
            public static IFile CreateFile(FileExtension ext, string file)
            {

                switch (ext)
                {
                    case FileExtension.sps:
                        return new SPSFile(file);

                    default:
                        return new SPSFile(file);
                }

            }
        }
    }

}
