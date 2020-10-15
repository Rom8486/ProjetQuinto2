using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetQuinto
{
    [Serializable]
    
    public class Mots : HashSet<Mot>
    {
        public static object LoadJson(Type dataType)
        {
           
            JObject obj = null;
            string test;
            JsonSerializer jsonS = new JsonSerializer();

            string filepath = @"c:\Windows\temp\MotsJson.json";
            if (File.Exists(filepath))
            {
                StreamReader sr = new StreamReader(filepath);
                JsonReader jsonR = new JsonTextReader(sr);
               test = jsonS.Deserialize(jsonR).ToString() ;
                Mots mots = JsonConvert.DeserializeObject<Mots>(test);

                jsonR.Close();
                sr.Close();
                return obj.ToObject(dataType);

            }
            else
            {
                throw new Exception();
            }
        }
    }
}