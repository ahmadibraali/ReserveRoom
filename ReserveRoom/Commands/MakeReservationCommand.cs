using ReserveRoom.Exceptions;
using ReserveRoom.Model;
using ReserveRoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReserveRoom.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeAReservationViewModel _makeAReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeAReservationViewModel makeAReservationViewModel,Hotel hotel)
        {
            _makeAReservationViewModel = makeAReservationViewModel;
            _hotel = hotel;
            _makeAReservationViewModel.PropertyChanged += _makeAReservationViewModel_PropertyChanged;

        }

        

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeAReservationViewModel.Username) && _makeAReservationViewModel.FloorNo>0
                &&_makeAReservationViewModel.RoomNo>0 && base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeAReservationViewModel.FloorNo,_makeAReservationViewModel.RoomNo),
                _makeAReservationViewModel.Username,
                _makeAReservationViewModel.StartDate,
                _makeAReservationViewModel.EndDate
                );
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Successfully reserved room.", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (ReservationConflictException ex)
            {
                MessageBox.Show("This room is already taken.","Error",
                    MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        private void _makeAReservationViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeAReservationViewModel.Username) || 
                e.PropertyName == nameof(MakeAReservationViewModel.FloorNo) ||
                e.PropertyName == nameof(MakeAReservationViewModel.RoomNo))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
