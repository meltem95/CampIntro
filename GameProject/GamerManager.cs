using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;
        public void Add(Gamer gamer)
        {
          Console.WriteLine("kayıt oldu.");
        }


        public void Update(Gamer gamer)
        {
           Console.WriteLine("kayıt güncellendi");
        }
        public void Delete(Gamer gamer)
        { 
          Console.WriteLine("kayıt silindi.");
        }
      
            
    }
}
