using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRoomApp
{
    public class Guest: Room
    {
        
        
        public string UserName { get; set; } = "";
        public string UserSurname { get; set; } = "";
        public DateTime EntryTimeRoom { get; set; } 
        public DateTime QuieTimeRoom { get; set; }


        public Guest() { }
        public Guest(int nrRoom, string userName, string userSurname, DateTime entryTimeRoom, DateTime quieTimeRoom)
        {
            if (StatusRoom == Status.Free)
            {
                this.NrRoom = nrRoom;
                this.UserName = userName;
                this.UserSurname = userSurname;
                this.EntryTimeRoom = entryTimeRoom;
                this.QuieTimeRoom = quieTimeRoom;
                this.StatusRoom = Status.Busy;
            }
        }
    }
}
