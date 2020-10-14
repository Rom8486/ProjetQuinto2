//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetQuinto
{
    [Serializable]

    public class Mots : HashSet<object>
    {
        //public void LoadJson(Mots listmots)
        //{
        //    JObject obj = null;
        //    JsonSerializer jsonS = new JsonSerializer();

        //    string filepath = @"c:\Windows\temp\MotsJson.json";
        //    if (File.Exists(filepath))
        //    {
        //        StreamReader sr = new StreamReader(filepath);
        //        JsonReader jsonR = new JsonTextReader(sr);
        //        obj = jsonS.Deserialize(jsonR) as JObject;
        //        jsonR.Close();
        //        sr.Close();
        //        this.Add(obj);
        //    }
        //}
    }
}