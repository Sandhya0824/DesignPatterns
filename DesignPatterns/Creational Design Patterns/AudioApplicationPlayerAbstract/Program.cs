namespace AudioApplicationPlayerAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        void Run()
        {
            IUserInput userInput = new UserInput();

            while (true)
            {
                var selectedPlatform = userInput.ChoosePlatform();
                if (selectedPlatform == 3)
                    break;

                var factory = AudioPlayerFactory.CreateAudioPlayerFactoryFromSelection(selectedPlatform);
                OperateAudioPlayer(factory);
            }
        }

        void OperateAudioPlayer(IAudioPlayerFactory factory)
        {
            IAudioPlayer audioPlayer = factory.CreateAudioPlayer();

            while (true)
            {
                IUserInput userInput = new UserInput();

                int choice = userInput.ChooseOperation();
                if (choice == 3)
                    break;

                switch (choice)
                {
                    case 1: audioPlayer.Play(); break;
                    case 2: audioPlayer.Stop(); break;
                }
            }
        }
    }
}