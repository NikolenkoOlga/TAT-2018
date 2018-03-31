using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    public class Catalog
    {
        [DataMember]
        public string Brand { get; set; }        
        
        public Catalog(string brend)
        {
            Brand = brend;           
        }
    }
}