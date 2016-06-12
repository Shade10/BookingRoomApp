using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace BookingRoomApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Room Roome;
        private Guests Guest;
        public ObservableCollection<Room> RoomList { get; set; }
        public ObservableCollection<Guests> GuestsList { get; set; }
        
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            this.GuestsList = new ObservableCollection<Guests>();
            this.RoomList = new ObservableCollection<Room>();
            //ICollectionView NrRoomList = CollectionViewSource.GetDefaultView(RoomList);
            ShowRoomList();


        }

        private void ShowRoomList()
        {
            for (int i = 1; i <= 5; i++)
            {
                this.Roome = new Room(i, Status.Free, HowManyBedInRooms.Single);
                RoomList.Add(Roome);
            }
            for (int i = 6; i <= 9; i++)
            {
                this.Roome = new Room(i, Status.Free, HowManyBedInRooms.Double);
                RoomList.Add(Roome);
            }
            for (int i = 10; i <= 14; i++)
            {
                this.Roome = new Room(i, Status.Free, HowManyBedInRooms.Triple);
                RoomList.Add(Roome);
            }
        }



        private void AddGuestToRoom_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int nrRoom = RoomListView.SelectedIndex + 1;
                string name = this.NameTextBox.Text;
                string surName = this.SurnameTextBox.Text;
                HowManyBedInRooms typeRoom = Roome.TypeRoom ; // bad solution but i dont kno what I should give here

                DateTime entryGuest = EntryRoomCalendar.SelectedDate.Value;
                DateTime QuietGuest = QuietRoomCalendar.SelectedDate.Value;
                if (Roome.StatusRoom == Status.Free) 
                {
                    Guests Guest = new Guests(nrRoom, name, surName, typeRoom, entryGuest, QuietGuest);
                    GuestsList.Add(Guest);
                    RoomListView.SelectedItem = (Roome.StatusRoom == Status.Busy);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First you must choose room, Date your stay end out and write Name and surname Guest", "Added Guest");
            }



        }




        private void DeleteGuestFromRoom_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                this.GuestsList.RemoveAt(this.GuestRoomBookView.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("First you have to select Guest you want to delete.", "Delete Guest From Room List");
            }
        }



        #region don't uses method at this moment
        //private void SelectedGuestRoom()
        //{
        //    int nrRoom = RoomListView.SelectedIndex = Roome.NrRoom;
        //    string name = NameTextBox.Text;
        //    string surName = SurnameTextBox.Text;

        //    HowManyBedInRooms TypeRoom = Roome.TypeRoom;
        //    Guest = new Guests(nrRoom, name, surName );

        //    GuestsList.Add(Guest);

        //}
        #endregion
    }
}
