using Approvia.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Approvia.Core.Commons
{
    public class Utilities
    {
        
        public static bool CheckIfDataBaseExists()
        {
            bool exists = false;
            return exists;
        }


        public static WebFormResponseDTO CreateResponse(string message, bool success)
        {
            
            var obj = new WebFormResponseDTO()
            {
                Message = message,
               Success = success
                
            };
            return obj;
        }
    }
}
