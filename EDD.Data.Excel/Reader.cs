using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace EDD.Data.Excel
{
    public class Reader
    {
        public static IEnumerable<object[]> Read(string filePath)
        {
            filePath = AppDomain.CurrentDomain.BaseDirectory + filePath;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    //Skip first row
                    reader.Read();
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        var list = new List<object>();
                        list.Add(reader.GetString(0));
                        list.Add(reader.GetDouble(1));
                        list.Add(reader.GetString(2));
                        list.Add(reader.GetString(3));
                        list.Add(reader.GetDouble(4));
                        yield return list.ToArray();
                    }
                }
            }
        }
    }
}