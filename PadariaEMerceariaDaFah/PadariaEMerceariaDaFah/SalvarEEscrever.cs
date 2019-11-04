using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Arquivos
{   
    [Serializable]
    class SalvarEEscrever
    {
        static public List<string> ReadTextFile(string path)
        {
            List<string> contents = new List<string>();

            //Forma 1
            try
            {
                if(File.Exists(path))
                    contents = File.ReadAllLines(path).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                throw ex;
            }
            //--//

            return contents;
            //Forma 2
            StreamReader fs = null;
            try
            {
                fs = new StreamReader(path);
                string currentLine = "";
                while ((currentLine = fs.ReadLine()) != null)
                {
                    contents.Add(currentLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                throw ex;
            }
            finally
            {
                fs.Close();
            }
            //--//
            
        }

        static public void SaveTextFile(string path, List<string> content, FileMode Type )
        {
            try
            {
                if (Type == FileMode.Append)
                    File.AppendAllLines(path, content);
                else
                    File.WriteAllLines(path, content);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;                               
            }
       }

        static public void SaveBinFile<T>(string path, T content)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, content);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }
            finally
            {
                if(fs != null)
                    fs.Close();
            }
        }

        static public T ReadBinFile<T>(string path)
        {
            FileStream fs = null;
            T content;
            try
            {
                if (File.Exists(path))
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    content = (T)bf.Deserialize(fs);
                }
                else
                {
                    content = default(T);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                if (File.Exists(path))
                {
                    fs.Close();
                }
            }

            return content;
        }

    }
}
