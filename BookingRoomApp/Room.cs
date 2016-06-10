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
        public HowManyBedInRooms HowManyBedInRoom { get; set; } = HowManyBedInRooms.Single;

        public Room()
        {
            for (int i = 1; i <= 5; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Single);
            }
            for (int i = 6; i <= 9; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Double);
            }
            for (int i = 10; i <= 14; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Triple);
            }
        }

        public Room(int nrRoom, Status statusRoom, HowManyBedInRooms howManyBedInRoom)
        {
            this.NrRoom = nrRoom;
            this.StatusRoom = statusRoom;
            this.HowManyBedInRoom = howManyBedInRoom;
        }

        

    }
}
