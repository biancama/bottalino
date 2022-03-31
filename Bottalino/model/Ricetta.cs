namespace Bottalino.model
{
    public class Ricetta
    {
        private string _Id;
        private int _speed;
        private int _temperature;
        private int _hours;
        private int _minutes;
        private int _seconds;
        private int _numberOfTimeCards;

        public Ricetta(string id)
        {
            _Id = id;
        }

        public string Id { get => _Id; }

        public int Minutes { get => _minutes; set => _minutes = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public int Temperature { get => _temperature; set => _temperature = value; }
        public int Hours { get => _hours; set => _hours = value; }
        public int Seconds { get => _seconds; set => _seconds = value; }
        public int NumberOfTimeCards { get => _numberOfTimeCards; set => _numberOfTimeCards = value; }
    }
}
