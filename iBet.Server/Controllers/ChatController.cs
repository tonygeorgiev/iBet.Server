using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iBet.Server.Controllers.Base;
using iBet.Server.Hubs;
using iBet.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace iBet.Server.Controllers
{
    [Produces("application/json")]
    public class ChatController : ApiController
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")]                                           
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageRequest message)
        {
            //_hubContext.Clients.All.SendAsync("ReceiveOne", message.User, message.MessageText);
            return Ok(message.MessageText);
        }
    }
}
