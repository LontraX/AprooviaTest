using Approvia.Data.Models;
using Approvia.Data.Services.Interface;
using Approvia.Data.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvia.Data.Services.Implementation
{
    public class WebFormRepository : IWebFormRepository
    {
        private IMongoDatabase _db;
        private readonly MongoClient _client;

        public WebFormRepository(IOptions<MongoDbSettings> options)
        {
            _client = new MongoClient(options.Value.ConnectionString);
        }
        public async Task<bool> AddFormAsync(MySparkPlugFeedback model)
        {
            try
            {
                _db = _client.GetDatabase(model._FormDomainName); // creates a new database for every new domain name.
                var collection = _db.GetCollection<MySparkPlugFeedback>("MySparkPlugFeedBack"); // gets the collection and if it does not exist, it creates one. 
                collection.InsertOne(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public Task<bool> DeleteFormAsync(MySparkPlugFeedback model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<MySparkPlugFeedback>> GetAllFormsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MySparkPlugFeedback> GetFormByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFormAsync(MySparkPlugFeedback model)
        {
            throw new NotImplementedException();
        }
    }
}
