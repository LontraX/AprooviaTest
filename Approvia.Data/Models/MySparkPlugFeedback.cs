using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvia.Data.Models
{
    public class MySparkPlugFeedback
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMessage { get; set; }
        public string _FormDomainName { get; set; }
        public string _FormName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
