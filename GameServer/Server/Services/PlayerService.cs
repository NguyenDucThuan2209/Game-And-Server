using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public interface IPlayerService
    {
        void DoSomething();
    }

    public class PlayerService : IPlayerService
    {
        public void DoSomething()
        {
            Console.WriteLine("Done something in the PlayerService!");
        }
    }

    public class MockPlayerService : IPlayerService
    {
        public void DoSomething()
        {
            Console.WriteLine("Done something in the MockPlayerService!");
        }
    }
}
