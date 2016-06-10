using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Guest> GuestsList { get; set; }
        
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = this;
            this.GuestsList = new ObservableCollection<Guest>();
            this.RoomList = new ObservableCollection<Room>();
            ShowRoomList();

            this.RoomComboBox.ItemsSource = RoomComboBoxShowList();
            


        }

        private void ShowRoomList()
        {
            for (int i = 1; i <= 5; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Single);
                RoomList.Add(room);
            }
            for (int i = 6; i <= 9; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Double);
                RoomList.Add(room);
            }
            for (int i = 10; i <= 14; i++)
            {
                Room room = new Room(i, Status.Free, HowManyBedInRooms.Triple);
                RoomList.Add(room);
            }
        }

        private string RoomComboBoxShowList()
        {

            foreach (Room room in RoomList)
            {
                return room.ToString();
            }
            return RoomComboBox.SelectionBoxItemStringFormat;

        }
    }
}
