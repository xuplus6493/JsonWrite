using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonWrite
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // 確認是否有json檔案存在
      string jsonPath = System.Environment.CurrentDirectory + "\\project.json";
      if (!File.Exists(jsonPath))
      {
        var result = new
        {
          project = new
          {
            nodemanager = new List<object>()
            {
              new
              {
                 nodename = "Server",
                 nodes = new List<object>()
                 {
                   new
                   {
                      deviceName = "Device1",
                      tags = new List<object>()
                      {
                        new
                        {
                          tagName = "Tag1",
                          tagType =  1,
                          readWriteAccess = 1,
                          description = "初始預設建立Tag"
                        },
                        new
                        {
                          tagName = "Tag2",
                          tagType =  1,
                          readWriteAccess = 1,
                          description = "初始預設建立Tag"
                        },
                      }
                   }

                 }
              }
            }
          }
        };

        Console.Write(JsonConvert.SerializeObject(result));
        string jsonString = JsonConvert.SerializeObject(result, Formatting.Indented);
        System.IO.File.WriteAllText(jsonPath, jsonString);
      }
      Console.ReadLine();
    }
  }
}
