using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.Core;
using UserAuthWebAPI.App_Start;

namespace UserAuthWebAPI.Controllers
{
    public class UserController : ApiController
    {
        MongoContext _dbContext;

        // GET api/values
        public string Get()
        {
            _dbContext = new MongoContext();
            IMongoDatabase db = _dbContext._client.GetDatabase("sitecore90");
            var users = db.GetCollection<BsonDocument>("users");
            var result = users.Find(new BsonDocument("userid", "EMP002")).Count().ToString();
            return result;
        }

        public string Get(string userid)
        {
            _dbContext = new MongoContext();
            IMongoDatabase db = _dbContext._client.GetDatabase("sitecore90");
            var users = db.GetCollection<BsonDocument>("users");
            var result = users.Find(new BsonDocument("userid", userid)).Count().ToString();
            return "userMatch -"  + result;

        }
    }
}
