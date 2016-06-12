using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRoomApp
{
    public class Guests : Room
    {
        //private ObservableCollection<Room> nrRooms;


        public string GuestName { get; set; } 
        public string GuestSurname { get; set; }
        public DateTime EntryTimeRoom { get; set; } 
        public DateTime QuieTimeRoom { get; set; }


        public Guests() { }
        public Guests(int nrRoom, string guestName, string guestSurname, HowManyBedInRooms typeRooms, DateTime entryTimeRoom, DateTime quieTimeRoom)  //, DateTime entryTimeRoom, DateTime quieTimeRoom
        {

            this.NrRoom = nrRoom;
            this.GuestName = guestName;
            this.GuestSurname = guestSurname;
            this.TypeRoom = typeRooms;
            this.EntryTimeRoom = entryTimeRoom;
            this.QuieTimeRoom = quieTimeRoom;
        }


    }
}
