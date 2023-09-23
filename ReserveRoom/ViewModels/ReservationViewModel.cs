using ReserveRoom.Commands;
using ReserveRoom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReserveRoom.ViewModels
{
    public class ReservationViewModel:ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID =>_reservation.RoomID?.ToString();
        public string Username =>_reservation.Username;
        public string StartTime => _reservation.StartTime.ToString("d");
        public string EndTime => _reservation.EndTime.ToString("d");

        public ICommand MakeReservationCommand { get; }
        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;

            MakeReservationCommand = new NavigateCommand();

        }
    }
}
