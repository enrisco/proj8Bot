using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics; 

namespace _8Bot_Configuration.Controller
{
    public class Rewriter
    {
        public Rewriter(string source, string dest)
        {
            CopyAndPaste(source,dest);

            //Console.WriteLine("lendo arquivos");
        }

        private void CopyAndPaste(string source, string dest)
        {
            //string source = @"C:\Users\yskaimer\source\repos\8Bot\bin\Debug\Addons";
            string[] files;
            DirectoryInfo folders;

            try
            {
                files = Directory.GetFiles(source);
                folders = new DirectoryInfo(source);

                //Console.WriteLine("tentano");

                if (files != null)
                    CopyFiles(files, source, dest);

                if (folders != null)
                    CopyFolders(folders, source, dest);
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);

                var frame = st.GetFrame(st.FrameCount - 1);
                var line = frame.GetFileLineNumber();

                Console.WriteLine("erro na linha " + line + ", " + ex.Message);
                //Console.ReadKey();
            }
        }

        void CopyFiles(string[] files, string source, string dest)
        {
            //Console.WriteLine("copiando arquivos");
            foreach (string s in files)
            {
                string fName = s.Substring(source.Length + 1);

                File.Copy(Path.Combine(source, fName), Path.Combine(dest, fName), true);
            }
        }

        void CopyFolders(DirectoryInfo folder, string source, string dest)
        {
            try
            {
                //Console.WriteLine("copiando pasta");

                DirectoryInfo[] folders = folder.GetDirectories();

                foreach (DirectoryInfo s in folders)
                {
                    string subFolderDest = Path.Combine(dest, s.Name);
                    string subFolderSource = Path.Combine(source, s.Name);
                    Directory.CreateDirectory(subFolderDest);

                    CopyFiles(Directory.GetFiles(subFolderSource), subFolderSource, subFolderDest);

                    DirectoryInfo subfolder = new DirectoryInfo(subFolderSource);

                    if (subfolder.GetDirectories() != null)
                    {
                        CopyFolders(subfolder, subFolderSource, subFolderDest);
                    }
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);

                var frame = st.GetFrame(st.FrameCount - 1);
                var line = frame.GetFileLineNumber();

                //Console.WriteLine("erro na linha " + line + ", " + ex.Message);
                //Console.ReadKey();
            }
        }
    }
}
