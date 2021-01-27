using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class GamerManager  
    {

       
        public void Save(Gamer gamer, IGamerCheckService gamerCheckService)
        {
            if (gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " saved.");
            }
            else
            {
                Console.WriteLine("User didn't verification!");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted.");
        }
                
    }
}
