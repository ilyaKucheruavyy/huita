﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace TestProjectHotline.Extensions
{
    public static class StringExtensions
    {
        public static string ByKey(this string assemblyPath, string key)
        {
            var path = Directory.GetParent(assemblyPath).GetFiles("appsettings.json").First().FullName;
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    string configFileContent = sr.ReadToEnd();

                    var responseContent = JsonConvert.DeserializeObject<JObject>(configFileContent);
                    string value = responseContent[key].ToString();

                    return value;
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to read configuration property for '{key}' key: {e}");
                }
            }
        }
    }
}
