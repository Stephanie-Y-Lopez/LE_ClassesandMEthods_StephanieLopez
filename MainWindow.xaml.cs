using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LE_ClassesandMEthods_StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamRoster<FootBallPlayer> seahawks = new TeamRoster<FootBallPlayer>();
        TeamRoster<BadmintonPlayer> husky = new TeamRoster<BadmintonPlayer>();

        public MainWindow()
        {

            string name1 = "Oswaldo";
            string name2 = "Diana";

            string temp = name1;
            name1 = name2;
            name2 = temp;

            //name1 = Diana
            //name2 = Oswaldo

            FootBallPlayer p1 = new FootBallPlayer();
            FootBallPlayer p2 = new FootBallPlayer();
            BadmintonPlayer p3 = new BadmintonPlayer("west", "6", 5, 4);
            
            int a = 6;
            int b = 8;

            ChangeA(a);

            Swap(ref a, ref b);
            Swap(ref p1, ref p2);
        }

        public void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }

        public void ChangeA(int a)
        {
            a = 12;
        }

        public void AddingPlayersToTeamRoster()
        {
            InitializeComponent();
            seahawks.AddPlayer(new FootBallPlayer("Oswaldo", "23", 1000000000, 26));
            seahawks.AddPlayer(new FootBallPlayer("Pedro", "13", 1000000, 20));

            MessageBox.Show(seahawks.TeamSalary().ToString());

            husky.AddPlayer(new BadmintonPlayer("Will", "8", 10000000, 50));
        }

        //1. Making a class generic allows us to pass in any type.

        //2. By doing this, it allows us to increase our type flexibility.

        //3. What keyword do we use to restrict what types we want to pass in? Extend.

        //4. What letter do we use to represent the keyword Type in our generic class? T.

        //5. When creating a generic method, where do you put<T>? You put the T before the return type. 

        //6. When calling a generic method, is it required to pass in the type you working with? It is not always required.

    }
}