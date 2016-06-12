using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRoomApp
{
    public class Guests: Room
    {
        private ObservableCollection<Room> nrRooms;
        

        public string UserName { get; set; } = "";
        public string UserSurname { get; set; } = "";
        public DateTime EntryTimeRoom { get; set; } 
        public DateTime QuieTimeRoom { get; set; }


        public Guests() { }
        public Guests(ObservableCollection<Room> nrRoom, string userName, string userSurname, DateTime entryTimeRoom, DateTime quieTimeRoom)
        {
            
                this.nrRooms = nrRoom;
                this.UserName = userName;
                this.UserSurname = userSurname;
                this.EntryTimeRoom = entryTimeRoom;
                this.QuieTimeRoom = quieTimeRoom;
                
            
        }

        
    }
}
