// ================================
// Copyright (c) coalition of good-Hearted Engineers
//Free To Use  Comfort and peace
// ================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => 
            Ok("Hello Mario, the princess is in another  castle");

    }
}
