using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ProjetQuinto
{
    [Serializable]

    public class Mots : HashSet<Mot>
    {
        
       
        public static Mot ChargerMot(Mots mots)
        {
            Random rand = new Random();
          

                int index = rand.Next(mots.Count);
                Mot mot = mots.ElementAt(index);

            return mot;

        }
    }
       


    

	
}