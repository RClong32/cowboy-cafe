using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.ItemCustimization;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// inititalization of MenuItemSelectionControl
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// button for ordering Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new AngryChicken();
                OrderList.Add(item);
                var screen = new ItemCustomization.AngryChickenCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }

        }

        /// <summary>
        /// button for ordering Rustler's Ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new RustlersRibs());
            }

        }
        /// <summary>
        /// button for ordering Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new PecosPulledPork();
                OrderList.Add(item);
                var screen = new ItemCustomization.PecosPulledPorkCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering a Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new TrailBurger();
                OrderList.Add(item);
                var screen = new ItemCustomization.TrailBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering a Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new DakotaDoubleBurger();
                OrderList.Add(item);
                var screen = new ItemCustomization.DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering a Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new TexasTripleBurger();
                OrderList.Add(item);
                var screen = new ItemCustomization.TexasTripleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new CowpokeChili();
                OrderList.Add(item);
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// button for ordering Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new CornDodgers());
            }
        }
        /// <summary>
        /// button for ordering Pan de Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// button for ordering Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order OrderList)
            {
                var item = new BakedBeans();
                OrderList.Add(item);
                var screen = new ItemCustomization.BakedBeansCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// button for ordering Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new JerkedSoda());
            }
        }
        /// <summary>
        /// button for ordering Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new TexasTea());
            }
        }
        /// <summary>
        /// button for ordering Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new CowboyCoffee());
            }
        }
        /// <summary>
        /// button for ordering water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order OrderList)
            {
                OrderList.Add(new Water());
            }
        }


    }
}
