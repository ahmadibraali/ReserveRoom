using ReserveRoom.Exceptions;
using ReserveRoom.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Model
{
    public class ReservationBook
    {
        private readonly ObservableCollection<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new ObservableCollection<Reservation>();
        }
        /// <summary>
        /// Get All reservations in reservation book
        /// </summary>
        /// <returns>The reservations </returns>
        public ObservableCollection<Reservation> GetAllReservations()
        {  
           return _reservations;

        } 
        /// <summary>
        /// Add a reservation into reservation book
        /// </summary>
        /// <param name="reservation"> The incoming reservation </param>
        /// <exception cref="ReservationConflictException">Thrown if the incoming reservation conflicts with existing reservation</exception>
        public void AddReservation(Reservation reservation)
        {   foreach(Reservation existingReservation in _reservations )
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation,reservation);
                }

            }
            _reservations.Add(reservation);
        }

    }
}
