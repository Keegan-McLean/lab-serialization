using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialazation
{
    [Serializable]
    internal class Event
    {

        private int _eventNumber;
        private string _location;

        public string Location { get { return _location; } }
        public int EventNumber { get { return _eventNumber; } }

        public Event () {}

        public Event (string location, int eventNumber)
        {
            _location = location;
            _eventNumber = eventNumber;

        }
        

    }
}
