namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomKeyManager roomKeyManager1 = RoomKeyManager.GetInstance();
            RoomKeyManager roomKeyManager2 = RoomKeyManager.GetInstance();

            Console.WriteLine(roomKeyManager1 == roomKeyManager2);

        }
    }
}