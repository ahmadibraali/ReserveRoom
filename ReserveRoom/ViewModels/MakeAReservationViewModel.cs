using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ReserveRoom.ViewModels
{
   public class MakeAReservationViewModel:ViewModelBase
    {
        #region Data To BeBinding In Make A Reservation View
        private string _userName;
        public string Username
        {
            get => _userName;


            set
            {
                _userName = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        private int _floorNo;
        public int FloorNo
        {
            get => _floorNo;


            set
            {
                _floorNo = value;
                OnPropertyChanged(nameof(FloorNo));
            }
        }
        private int _roomNo;
        public int RoomNo
        {
            get => _roomNo;


            set
            {
                _roomNo = value;
                OnPropertyChanged(nameof(RoomNo));
            }
        }
        private DateTime _startDate;
        public DateTime StartDate
        {
            get => _startDate;


            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }
        private DateTime _endDate;
        public DateTime EndDate
        {
            get => _endDate;


            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        #endregion
        #region Commands That Bind in Buttons
        /// <summary>
        /// Must Be Initialized In Constructor 
        /// </summary>
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        #endregion
        #region CTOR
        public MakeAReservationViewModel()
        {
            
        }
        #endregion

    }
}
