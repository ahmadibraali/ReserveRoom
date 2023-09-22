using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Model
{
    public class RoomID
    {
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()=> $"▓-Room Number : {RoomNumber}\n├Floor Number : {FloorNumber}";
        

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID &&
            FloorNumber==roomID.FloorNumber&&
            RoomNumber==roomID.RoomNumber;
        }
        public override int GetHashCode()=> HashCode.Combine(FloorNumber,RoomNumber);
        public static bool operator ==(RoomID left, RoomID right) =>
            (left is null && right is null) ? true : (left is null&& left.Equals(right));
        public static bool operator !=(RoomID left, RoomID right) => !(left==right);
    }
}
