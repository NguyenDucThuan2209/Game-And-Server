using Microsoft.AspNetCore.Mvc;
using SharedLibrary;
using System;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("{id}")]
        public Player Get([FromRoute] int id)
        {
            var player = new Player() { ID = id };
            return player;
        }

        [HttpPost]
        public Player Post(Player player)
        {
            Console.WriteLine("Player has been added to the Database");
            return player;
        }
    }
}
