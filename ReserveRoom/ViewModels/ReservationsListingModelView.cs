using ReserveRoom.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReserveRoom.ViewModels
{
    public class ReservationsListingModelView:ViewModelBase
    {
        #region Data To Be Binding In Reservations Listing View
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations=> _reservations;
        #endregion
        #region Commands That Bind in Buttons
        /// <summary>
        /// Must Be Initialized In Constructor 
        /// </summary>
        public ICommand MakeAReservationCommand { get; }
        #endregion
        #region CTOR
        public ReservationsListingModelView()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Zookshh", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 4), "aaaa", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 2), "test", DateTime.Now, DateTime.Now)));
        }
        #endregion
    }
}
