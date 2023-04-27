using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF
{
    
    public partial class MainWindow : Window
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();

            //Create DataGrid Items Info
           /* members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Coach", Email = "qwe@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Reza Alavi", Position = "Administrator", Email = "zxce@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Denis Castilo", Position = "Manager", Email = "23123sae@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Gabriel Cox", Position = "Manager", Email = "zx23sae@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Lena Jones", Position = "Coach", Email = "x123e@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Benhamin Caliwood", Position = "Administrator", Email = "ghlole@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Sophia Muris", Position = "Administrator", Email = "xxxe@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ali Pormand", Position = "Manager", Email = "23121@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Frank Underwood", Position = "Manager", Email = "mopop@gmail.com", Phone = "0950231232" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Saed Dasma", Position = "Coach", Email = "086hfg@gmail.com", Phone = "0950231232" });
           */
            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftBouttonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Content contentWindow = new Content();
            contentWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content contentWindow = new Content();
            contentWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            members.RemoveAt(membersDataGrid.SelectedIndex);

            membersDataGrid.ItemsSource = members;
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
