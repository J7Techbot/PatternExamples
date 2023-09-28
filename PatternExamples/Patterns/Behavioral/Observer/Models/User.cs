using Observer.Interfaces;

namespace Observer.Models
{
    internal class User : IObserver
    {
        private string _userName;
        public User(string userName)
        {
            _userName = userName;
        }
        
        public void Update(Event e)
        {
            switch(e.Type)
            {
                case Enums.EventType.EULA_UPDATED:
                    InformUser(((EULAManager)e.Observable).ActualEULA);
                    break;
            }            
        }

        private void InformUser(string updatedEula)
        {
            Console.WriteLine($"{_userName} informed");
            Console.WriteLine($"Content : {updatedEula}\n");
        }
    }
}
