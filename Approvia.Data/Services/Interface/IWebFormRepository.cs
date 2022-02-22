using Approvia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvia.Data.Services.Interface
{
    public interface IWebFormRepository
    {
        Task<bool> AddFormAsync(MySparkPlugFeedback model);
        Task<bool> DeleteFormAsync(MySparkPlugFeedback model);
        Task<bool> UpdateFormAsync(MySparkPlugFeedback model);
        Task<MySparkPlugFeedback> GetFormByIdAsync(string id);
        Task<IList<MySparkPlugFeedback>> GetAllFormsAsync();
    }
}
