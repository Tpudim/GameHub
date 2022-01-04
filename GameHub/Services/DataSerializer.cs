using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GameHub.Services
{
    class DataSerializer
    {
        public void BinarySerialize(object data,string filepath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            fileStream = File.Create(filepath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeserialize(string filepath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filepath))
            {
                fileStream = File.OpenRead(filepath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
}
