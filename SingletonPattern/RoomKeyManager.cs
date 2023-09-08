using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class RoomKeyManager
    {
        private static RoomKeyManager _instance;

        private RoomKeyManager() { }

        public static RoomKeyManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RoomKeyManager();
            }
            return _instance;
        }

        void DisplayMessage()
        {
            Console.WriteLine("Room Key is allotted");
        }
    }
}