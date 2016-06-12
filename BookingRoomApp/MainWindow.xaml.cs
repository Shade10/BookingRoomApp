using System;
using System.Collections;
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

        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            this.GuestsList = new ObservableCollection<Guests>();
            this.RoomList = new ObservableCollection<Room>();
            //ICollectionView NrRoomList = CollectionViewSource.GetDefaultView(RoomList);
            ShowRoomList();

            this.RoomComboBox.ItemsSource = Enum.GetValues(typeof(HowManyBedInRooms));

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



        private void AddGuestToRoom_OnClick(object sender, RoutedEventArgs e)
        {

            if (Roome.StatusRoom == Status.Free)
            {
                var selectedItems = RoomListView.SelectedItems;

                int nrRoom = RoomListView.SelectedIndex + 1;
                string name = this.NameTextBox.Text;
                string surName = this.SurnameTextBox.Text;
                HowManyBedInRooms typeRoom = Roome.HowManyBedInRoom; // bad solution but i dont kno what I should give here
               

                Guests Guest = new Guests(nrRoom, name, surName, typeRoom);
                GuestsList.Add(Guest);






            }

        }

        private void DeleteGuestFromRoom_OnClick(object sender, RoutedEventArgs e)
        {
        }


        //private void SelectedGuestRoom()
        //{
        //    int nrRoom = RoomListView.SelectedIndex = Roome.NrRoom;
        //    string name = NameTextBox.Text;
        //    string surName = SurnameTextBox.Text;

        //    HowManyBedInRooms TypeRoom = Roome.HowManyBedInRoom;
        //    Guest = new Guests(nrRoom, name, surName );

        //    GuestsList.Add(Guest);

        //}

    }
}
