using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatBotController : BaseController
    {
        private readonly IChatBotService chatBotService;

        public ChatBotController(IChatBotService chatBotService)
        {
            this.chatBotService = chatBotService;
        }

        [HttpGet("chat")]
        public async Task<IActionResult> Chat([FromQuery] string prompt)
        {
            // Check if the sessionId exists in cookies, if not, generate one
            string sessionId = Request.Cookies["sessionId"];
            if (string.IsNullOrEmpty(sessionId))
            {
                sessionId = Guid.NewGuid().ToString(); // Generate a new sessionId
                                                       // Set the sessionId cookie with a 1-hour expiry time
                Response.Cookies.Append("sessionId", sessionId, new CookieOptions { Expires = DateTime.Now.AddHours(1) });
            }

            // Now pass the sessionId to the ChatBotService to track the user's conversation
            var response = await chatBotService.GetProductFeaturesAsync(prompt, sessionId);

            return Ok(new { response });
        }
    }
}
