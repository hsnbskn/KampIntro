using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    public class EdevketCheckManager : IGamerCheckService
    {
        //E-devket simülasyonu için bilgiler
        string Name = "HASAN";
        //string Surname = "BASKIN";
        //int Birtday = 1997;
        //string TcNumber = "1987654123";
               

        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.FirstName.ToUpper() == Name)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
