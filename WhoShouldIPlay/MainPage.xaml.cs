using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WhoShouldIPlay.Resources;
using System.Linq;

namespace WhoShouldIPlay
{
    public partial class MainPage : PhoneApplicationPage
    {
         
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            #region list addings
            MarksmanList.Add("Ashe");
            MarksmanList.Add("Caitlyn");
            MarksmanList.Add("Corki");
            MarksmanList.Add("Draven");
            MarksmanList.Add("Ezreal");
            MarksmanList.Add("Graves");
            MarksmanList.Add("Kog'Maw");
            MarksmanList.Add("Lucian");
            MarksmanList.Add("Miss Fortune");
            MarksmanList.Add("Quinn");
            MarksmanList.Add("Sivir");
            MarksmanList.Add("Teemo");
            MarksmanList.Add("Tristana");
            MarksmanList.Add("Twitch");
            MarksmanList.Add("Urgot");
            MarksmanList.Add("Varus");
            MarksmanList.Add("Vayne");
            MidList.Add("Ahri");
            MidList.Add("Anivia");
            MidList.Add("Annie");
            MidList.Add("Brand");
            MidList.Add("Cassiopeia");
            MidList.Add("Elise");
            MidList.Add("Fiddlesticks");
            MidList.Add("Gragas");
            MidList.Add("Heimerdinger");
            MidList.Add("Karma");
            MidList.Add("Karthus");
            MidList.Add("Kennen");
            MidList.Add("Lissandra");
            MidList.Add("Lux");
            MidList.Add("Malzahar");
            MidList.Add("Morgana");
            MidList.Add("Orianna");
            MidList.Add("Ryze");
            MidList.Add("Swain");
            MidList.Add("Syndra");
            MidList.Add("Twisted Fate");
            MidList.Add("Veigar");
            MidList.Add("Viktor");
            MidList.Add("Vladimir");
            MidList.Add("Xerath");
            MidList.Add("Ziggs");
            MidList.Add("Zyra");
            MidList.Add("Janna");
            MidList.Add("Katarina");
            MidList.Add("Kassadin");
            MidList.Add("Evelynnn");
            MidList.Add("Kog'Maw");
            MidList.Add("LeBlanc");
            MidList.Add("Akali");
            MidList.Add("Jayce");
            MidList.Add("Kha'Zix");
            MidList.Add("Talon");
            MidList.Add("Teemo");
            MidList.Add("Tristana");
            MidList.Add("Zilean");
            MidList.Add("Nidalee");
            MidList.Add("Zed");
            MidList.Add("Sion");
            MidList.Add("Diana");
            MidList.Add("Ezreal");
            MidList.Add("Fizz");
            MidList.Add("Galio");
            MidList.Add("Kayle");
            MidList.Add("Kennen");
            MidList.Add("Lee Sin");
            MidList.Add("Pantheon");
            TopList.Add("Aatrox");
            TopList.Add("Akali");
            TopList.Add("Cho'Gath");
            TopList.Add("Darius");
            TopList.Add("Diana");
            TopList.Add("Elise");
            TopList.Add("Evelynn");
            TopList.Add("Ezreal");
            TopList.Add("Fiora");
            TopList.Add("Fizz");
            TopList.Add("Galio");
            TopList.Add("Gangplank");
            TopList.Add("Garen");
            TopList.Add("Irelia");
            TopList.Add("Jarvan IV");
            TopList.Add("Jax");
            TopList.Add("Jayce");
            TopList.Add("Kayle");
            TopList.Add("Kennen");
            TopList.Add("Kha'Zix");
            TopList.Add("Lee Sin");
            TopList.Add("Lissandra");
            TopList.Add("Malphite");
            TopList.Add("Master Yi");
            TopList.Add("Mordekaiser");
            TopList.Add("Nasus");
            TopList.Add("Nidalee");
            TopList.Add("Olaf");
            TopList.Add("Pantheon");
            TopList.Add("Poppy");
            TopList.Add("Renekton");
            TopList.Add("Rengar");
            TopList.Add("Riven");
            TopList.Add("Rumble");
            TopList.Add("Ryze");
            TopList.Add("Shen");
            TopList.Add("Shyvana");
            TopList.Add("Singed");
            TopList.Add("Sion");
            TopList.Add("Swain");
            TopList.Add("Teemo");
            TopList.Add("Trundle");
            TopList.Add("Tryndamere");
            TopList.Add("Udyr");
            TopList.Add("Vi");
            TopList.Add("Vladimir");
            TopList.Add("Volibear");
            TopList.Add("Warwick");
            TopList.Add("Wukong");
            TopList.Add("Xin Zhao");
            TopList.Add("Yorick");
            TopList.Add("Zac");
            TopList.Add("Zed");
            TopList.Add("Vayne");
            TopList.Add("Tristana");
            SupportList.Add("Alistar");
            SupportList.Add("Janna");
            SupportList.Add("Lulu");
            SupportList.Add("Nami");
            SupportList.Add("Nunu");
            SupportList.Add("Sona");
            SupportList.Add("Soraka");
            SupportList.Add("Taric");
            SupportList.Add("Thresh");
            SupportList.Add("Zilean");
            SupportList.Add("Fiddlesticks");
            SupportList.Add("Leona");
            SupportList.Add("Blitzcrank");
            TankList.Add("Amumu");
            TankList.Add("Blitzcrank");
            TankList.Add("Cho'Gath");
            TankList.Add("Darius");
            TankList.Add("Dr. Mundo");
            TankList.Add("Galio");
            TankList.Add("Gangplank");
            TankList.Add("Garen");
            TankList.Add("Hecarim");
            TankList.Add("Irelia");
            TankList.Add("Jarvan IV");
            TankList.Add("Lee Sin");
            TankList.Add("Leona");
            TankList.Add("Malphite");
            TankList.Add("Maokai");
            TankList.Add("Nasus");
            TankList.Add("Nautilus");
            TankList.Add("Nocturne");
            TankList.Add("Nunu");
            TankList.Add("Olaf");
            TankList.Add("Rammus");
            TankList.Add("Renekton");
            TankList.Add("Sejuani");
            TankList.Add("Shen");
            TankList.Add("Shyvana");
            TankList.Add("Singed");
            TankList.Add("Trundle");
            TankList.Add("Udyr");
            TankList.Add("Vi");
            TankList.Add("Volibear");
            TankList.Add("Warwick");
            TankList.Add("Zac");
            JungleList.Add("Aatrox");
            JungleList.Add("Alistar");
            JungleList.Add("Amumu");
            JungleList.Add("Cho'Gath");
            JungleList.Add("Darius");
            JungleList.Add("Diana");
            JungleList.Add("Dr. Mundo");
            JungleList.Add("Elise");
            JungleList.Add("Evelynn");
            JungleList.Add("Ezreal");
            JungleList.Add("Fiddlesticks");
            JungleList.Add("Gangplank");
            JungleList.Add("Hecarim");
            JungleList.Add("Jarvan IV");
            JungleList.Add("Karthus");
            JungleList.Add("Kha'Zix");
            JungleList.Add("Les Sin");
            JungleList.Add("Malphite");
            JungleList.Add("Maokai");
            JungleList.Add("Master Yi");
            JungleList.Add("Nasus");
            JungleList.Add("Nautilus");
            JungleList.Add("Nocturne");
            JungleList.Add("Nunu");
            JungleList.Add("Olaf");
            JungleList.Add("Pantheon");
            JungleList.Add("Rammus");
            JungleList.Add("Rengar");
            JungleList.Add("Riven");
            JungleList.Add("Sejuani");
            JungleList.Add("Shaco");
            JungleList.Add("Shenn");
            JungleList.Add("Shyvana");
            JungleList.Add("Singed");
            JungleList.Add("Skarner");
            JungleList.Add("Trundle");
            JungleList.Add("Tryndamere");
            JungleList.Add("Twitch");
            JungleList.Add("Udyr");
            JungleList.Add("Vi");
            JungleList.Add("Volibear");
            JungleList.Add("Warwick");
            JungleList.Add("Wukong");
            JungleList.Add("Zac");
            JungleList.Add("Zed");
            APList.Add("Ahri");
            APList.Add("Akali");
            APList.Add("Amumu");
            APList.Add("Anivia");
            APList.Add("Annie");
            APList.Add("Brand");
            APList.Add("Cassiopeia");
            APList.Add("Cho'Gath");
            APList.Add("Diana");
            APList.Add("Elise");
            APList.Add("Evelynn");
            APList.Add("Ezreal");
            APList.Add("Fiddlesticks");
            APList.Add("Fizz");
            APList.Add("Galio");
            APList.Add("Gragas");
            APList.Add("Heimerdinger");
            APList.Add("Janna");
            APList.Add("Karma");
            APList.Add("Karthus");
            APList.Add("Kassadin");
            APList.Add("Katarina");
            APList.Add("Kayle");
            APList.Add("Kennen");
            APList.Add("Kog'MMaw");
            APList.Add("LeBlanc");
            APList.Add("Lissandra");
            APList.Add("Lux");
            APList.Add("Malzahar");
            APList.Add("Maokai");
            APList.Add("Mordekaiser");
            APList.Add("Morgana");
            APList.Add("Nidalee");
            APList.Add("Orianna");
            APList.Add("Rumble");
            APList.Add("Ryze");
            APList.Add("Singed");
            APList.Add("Sion");
            APList.Add("Swain");
            APList.Add("Syndra");
            APList.Add("Teemo");
            APList.Add("Tristana");
            APList.Add("Twisted Fate");
            APList.Add("Veigar");
            APList.Add("Vladimir");
            APList.Add("Xerath");
            APList.Add("Ziggs");
            APList.Add("Zilean");
            APList.Add("Zyra");
            FighterList.Add("Darius");
            FighterList.Add("Diana");
            FighterList.Add("Gangplank");
            FighterList.Add("Garen");
            FighterList.Add("Hecarim");
            FighterList.Add("Blitzcrank");
            FighterList.Add("Irelia");
            FighterList.Add("Jarvan IV");
            FighterList.Add("Jayce");
            FighterList.Add("Kha'Zix");
            FighterList.Add("Lee Sin");
            FighterList.Add("Aatrox");
            FighterList.Add("Fiora");
            FighterList.Add("Jax");
            FighterList.Add("Kayle");
            FighterList.Add("Mordekaiser");
            FighterList.Add("Nasus");
            FighterList.Add("Olaf");
            FighterList.Add("Pantheon");
            FighterList.Add("Poppy");
            FighterList.Add("Talon");
            FighterList.Add("Renekton");
            FighterList.Add("Riven");
            FighterList.Add("Rumble");
            FighterList.Add("Shyvana");
            FighterList.Add("Sion");
            FighterList.Add("Skarner");
            FighterList.Add("Trundle");
            FighterList.Add("Tryndamere");
            FighterList.Add("Udyr");
            FighterList.Add("Vi");
            FighterList.Add("Volibear");
            FighterList.Add("Warwick");
            FighterList.Add("Wukong");
            FighterList.Add("Xin Zhao");
            FighterList.Add("Yorick");
            #endregion
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            
        }

        List<string> MarksmanList = new List<string>();
        List<string> MidList = new List<string>();           
        List<string> TopList = new List<string>();
        List<string> SupportList = new List<string>();
        List<string> TankList = new List<string>();
        List<string> JungleList = new List<string>();
        List<string> APList = new List<string>();
        List<string> FighterList = new List<string>();

        static Random rand = new Random();

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            
            if (Marksman.IsChecked == true && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(MarksmanList);
            }
            else if(Marksman.IsChecked == false && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(MidList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(TopList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == true && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(SupportList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(TankList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == true && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                oneCombo(JungleList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                oneCombo(APList);
            }
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                oneCombo(FighterList);
            }
                // ap and mid checked
            else if (Marksman.IsChecked == false && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                twoCombo(APList, MidList);
            }
                //mid fighter
            else if (Marksman.IsChecked == false && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                twoCombo(MidList, FighterList);
            }
            //mid fighter
            else if (Marksman.IsChecked == false && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                twoCombo(MidList, FighterList);
            }
            //top fighter
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                twoCombo(TopList, FighterList);
            }
            //top AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                twoCombo(TopList, APList);
            }
            //Support Tank
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == true && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(SupportList, TankList);
            }
            //top tank
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(TopList, TankList);
            }
            //ap tank
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                twoCombo(APList, TankList);
            }
            //top marksman
            else if (Marksman.IsChecked == true && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(TopList, MarksmanList);
            }
            //jungle tank
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == true && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(JungleList, TankList);
            }
            //fighter tank
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                twoCombo(FighterList, TankList);
            }
            //marksman mid
            else if (Marksman.IsChecked == true && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(MarksmanList, MidList);
            }
            //Support AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == true && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                twoCombo(SupportList, APList);
            }
            //fighter AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == true)
            {
                twoCombo(FighterList, APList);
            }
                //support jungle
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == true && Tank.IsChecked == false && Jungle.IsChecked == true && AP.IsChecked == false && Fighter.IsChecked == false)
            {
                twoCombo(SupportList, JungleList);
            
            }
            //jungle AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == false && Jungle.IsChecked == true && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                twoCombo(JungleList, APList);
            }
            //top tank AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                threeCombo(TopList, TankList, APList);
            }
           
            //mid tank AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == true && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                threeCombo(MidList, TankList, APList);
            }
            //jungle tank AP
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == false && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == true && AP.IsChecked == true && Fighter.IsChecked == false)
            {
                threeCombo(JungleList, TankList, APList);
            }
            //top tank bruiser
            else if (Marksman.IsChecked == false && Mid.IsChecked == false && Top.IsChecked == true && Support.IsChecked == false && Tank.IsChecked == true && Jungle.IsChecked == false && AP.IsChecked == false && Fighter.IsChecked == true)
            {
                threeCombo(TopList, TankList, FighterList);
            }
            else
            {
                MessageBox.Show("No results! Please check different boxes");
            }
           
        }

        private void twoCombo(List<string> one, List<string> two)
        {
            var result = one.Intersect(two);
            List<string> temp = new List<string>();
            temp = result.ToList();
            string tempname = "";
            int r = rand.Next(temp.Count);
            tempname = (string)temp[r];
            ChampName.Text = tempname;
        }

        private void threeCombo(List<string> one, List<string> two, List<string> three)
        {
            var result = one.Intersect(two).Intersect(three);
            List<string> temp = new List<string>();
            temp = result.ToList();
            string tempname = "";
            int r = rand.Next(temp.Count);
            tempname = (string)temp[r];
            ChampName.Text = tempname;
        }

        private void oneCombo(List<string> one)
        {
            string tempname = "";
            int r = rand.Next(one.Count);
            tempname = (string)one[r];
            ChampName.Text = tempname;
        }
     
       

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}