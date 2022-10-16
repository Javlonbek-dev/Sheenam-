//==============================================
//Copyright (c) Coalition Good-Hearted Engineers
//Free to Use Comfort And Peace
//==============================================


using Microsoft.AspNetCore.Mvc;


namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class HomeController : RestfulController
    {
        [HttpGet]

        public ActionResult<string> Get() => "Hello Mario, the princes is another castle.";


    }
}
