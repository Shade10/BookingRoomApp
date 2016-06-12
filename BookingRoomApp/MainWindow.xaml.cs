using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookingRoomApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Room> RoomList { get; set; }
        public ObservableCollection<Guests> GuestsList { get; set; }
        public Room Roome = new Room();
        public Guests Guest;
        
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = this;
            this.GuestsList = new ObservableCollection<Guests>();
            this.RoomList = new ObservableCollection<Room>();
            //ICollectionView NrRoomList = CollectionViewSource.GetDefaultView(RoomList);
            ShowRoomList();

            this.RoomComboBox.ItemsSource = Enum.GetValues(typeof(HowManyBedInRooms));
            this.NrRoomComboBox.ItemsSource = new ObservableCollection<Room>();
            //this.NrRoomComboBox.Items.Add(NrRoomList);
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

        //private void ShowNrList()
        //{
        //    foreach (Room room in RoomList)
        //    {
        //    }

        //}

        private void AddGuestToRoom_OnClick(object sender, RoutedEventArgs e)
        {
            if (Roome.StatusRoom ==  Status.Free)
            {
                //Guest = new Guests(, NameTextBox.Text, SurnameTextBox.Text, EntryRoomCalendar.DisplayDateStart.Value, QuietRoomCalendar.DisplayDateEnd.Value );
                this.Roome.StatusRoom = Status.Busy;
            }

        }

        private void DeleteGuestFromRoom_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
