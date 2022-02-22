using Approvia.Core.Commons;
using Approvia.Data.DTOs;
using Approvia.Data.Models;
using Approvia.Data.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Approvia.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparkPlugController : ControllerBase
    {
        private readonly IWebFormRepository _webFormRepo;
        private readonly IMapper _mapper;

        public SparkPlugController(IWebFormRepository webFormRepository, IMapper mapper)
        {
            _webFormRepo = webFormRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// submits the form to the backend and returns a response.
        /// https://localhost:44321/api/SparkPlug/add-form
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("add-form")]
        public async Task<IActionResult> AddWebForm([FromForm] AddFormDTO model)
        {
            var feedBack = _mapper.Map<MySparkPlugFeedback>(model); // automapper
            var response = await _webFormRepo.AddFormAsync(feedBack);
            if (response == false)
            {
                return BadRequest(Utilities.CreateResponse("could not submit form", false));
            }

            return Ok(Utilities.CreateResponse("Form submitted successfully!",true));
        }

    }
}
