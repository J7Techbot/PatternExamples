using Observer.Interfaces;

namespace Observer.Models
{
    internal class FileManager : IObserver
    {
        public void Update(Event e)
        {
            switch(e.Type)
            {
                case Enums.EventType.EULA_UPDATED:
                    SaveFile(((EULAManager)e.Observable).ActualEULA, "C:\\Files\\EULA.txt");                    
                    break;
            }             
        }

        public void SaveFile(string content, string filename)
        {
            ///save to file
            Console.WriteLine($"FileManager informed");
            Console.WriteLine($"Soubor uložen do {filename}\n");
        }
    }
}
