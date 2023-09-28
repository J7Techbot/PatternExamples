using Observer.Models;

namespace Observer
{
    internal class Main
    {
        EULAManager _EULAManager;
        FileManager _fileManager;
        User _johnny;
        User _jimmy;

        public Main()
        {
            _EULAManager = new EULAManager();
            _fileManager = new FileManager();
            _johnny = new User("Johnny");
            _jimmy = new User("Jimmy");

           
        }

        public void MainMethod()
        {
            _EULAManager.Attach(_johnny);
            _EULAManager.Attach(_jimmy);
            _EULAManager.Attach(_fileManager);

            _EULAManager.UpdateEULA();

            _EULAManager.Detach(_jimmy);

            Console.WriteLine("Jimmy detached\n");

            _EULAManager.UpdateEULA();
        }
    }
}
