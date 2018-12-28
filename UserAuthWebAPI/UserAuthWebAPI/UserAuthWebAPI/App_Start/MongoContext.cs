using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace UserAuthWebAPI.App_Start
{
    
    public class MongoContext
    {
       public MongoClient _client;       
      
        public MongoContext()
        {
            _client = new MongoClient("mongodb://127.0.0.1:27017"); 
        }

    }


    
}