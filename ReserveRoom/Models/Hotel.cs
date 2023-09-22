using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Model
{
    public class Hotel
    {
        private readonly ReservationBook reservationBook;
        public string Name { get; }
        public Hotel(string _name)
        {
            this.Name = _name;
            this.reservationBook = new ReservationBook(); ;
        }
        /// <summary>
        /// Get All reservations in reservation book
        /// </summary>
        /// <returns>The reservations in hotel reservation book </returns>
        public ObservableCollection<Reservation> GetAllReservations() => reservationBook.GetAllReservations();

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="_reservation">The incoming reservation</param>
        /// <exception cref="ReservationConflictException"></exception>
        public void MakeReservation(Reservation _reservation) => reservationBook.AddReservation(_reservation);

    }
}
