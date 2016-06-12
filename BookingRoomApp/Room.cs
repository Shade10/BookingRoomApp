using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRoomApp
{
    public enum Status { Free, Busy }
    public enum HowManyBedInRooms { Single, Double, Triple }
    public class Room
    {
        public int NrRoom { get; set; }
        public Status StatusRoom { get; set; } = Status.Free;
        public HowManyBedInRooms TypeRoom { get; set; } = HowManyBedInRooms.Single;



        public Room() { }

        public Room(int nrRoom, Status statusRoom, HowManyBedInRooms typeRoom)
        {
            this.NrRoom = nrRoom;
            this.StatusRoom = statusRoom;
            this.TypeRoom = typeRoom;
        }



    }
}
