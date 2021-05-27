using Newtonsoft.Json;
using System;
using System.IO;
using Task1.App.Entities;

namespace Task1.App.Domain
{
    public class Database
    {
        private string _dbFolderPath;
        private string _dbFilePath;

        public Database()
        {
            _dbFolderPath = @"..\..\..\Db";
            _dbFilePath = _dbFolderPath + @"\Dogs.json";

            if (!Directory.Exists(_dbFolderPath))
            {
                Directory.CreateDirectory(_dbFolderPath);
            }

            if (!File.Exists(_dbFilePath))
            {
                File.Create(_dbFilePath).Close();
            }
            Dog[] data = Read();
            if (data == null)
            {
                Dog[] dogs = new Dog[0] { };
                Write(dogs);
            }
        }
        public void Insert(Dog entity)
        {
            Dog[] data = Read();
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = entity;
            Write(data);
        }
        public void GetAll()
        {
            foreach (Dog dog in Read())
            {
                Console.WriteLine(dog.GetInfo());
            }
        }
        private Dog[] Read()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(_dbFilePath))
                {
                    string data = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Dog[]>(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void Write(Dog[] dogs)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(_dbFilePath))
                {
                    string data = JsonConvert.SerializeObject(dogs);
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
