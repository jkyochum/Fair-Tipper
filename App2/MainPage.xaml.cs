using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            sldEntertaining.Value = 2;
            sldInformative.Value = 2;
            sldFoodQuality.Value = 2;
            sldServerQuality.Value = 2;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.
            var date = DateTime.Now.Date;

            
            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double bill;
            String tipAmount;
            double tipPercent = 0.2;
            float amount;
            
            int ent = Convert.ToInt32(sldEntertaining.Value);
            int inf = Convert.ToInt32(sldInformative.Value);
            int servQual = Convert.ToInt32(sldServerQuality.Value);


            if (txtBillAmount.Text == "")
            {
                txtBillAmount.PlaceholderText = "Enter Amount";
            }
            else if (!float.TryParse(txtBillAmount.Text, out amount))
            {
                txtBillAmount.Text = "";
                txtBillAmount.PlaceholderText = "Enter Price";
            }
            else
            {
                switch (ent)
                {
                    case 0:
                        tipPercent -= .03;
                        break;
                    case 1:
                        tipPercent -= .015;
                        break;
                    case 2:
                        tipPercent += .0;
                        break;
                    case 3:
                        tipPercent += .02;
                        break;
                    case 4:
                        tipPercent += .04;
                        break;
                    case 5:
                        tipPercent += .06;
                        break;

                }

                switch (inf)
                {
                    case 0:
                        tipPercent -= .03;
                        break;
                    case 1:
                        tipPercent -= .015;
                        break;
                    case 2:
                        tipPercent += .0;
                        break;
                    case 3:
                        tipPercent += .02;
                        break;
                    case 4:
                        tipPercent += .04;
                        break;
                    case 5:
                        tipPercent += .06;
                        break;
                }

                switch (servQual)
                {
                    case 0:
                        tipPercent -= .036;
                        break;
                    case 1:
                        tipPercent -= .018;
                        break;
                    case 2:
                        tipPercent += .0;
                        break;
                    case 3:
                        tipPercent += .03;
                        break;
                    case 4:
                        tipPercent += .06;
                        break;
                    case 5:
                        tipPercent += .08;
                        break;
                }


                bill = Convert.ToDouble(txtBillAmount.Text);
                tipAmount = (bill * tipPercent).ToString("C");
                txtBillAmount.Text = "";
                sldEntertaining.Value = 2;
                sldFoodQuality.Value = 2;
                sldInformative.Value = 2;
                sldServerQuality.Value = 2;

                this.Frame.Navigate(typeof(Page2), tipAmount);

            }

        }

        private void sldEntertaining_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //entertainingText.Text = sldEntertaining.Value.ToString();
            String val = sldEntertaining.Value.ToString();

            switch (val)
            {
                case "0":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, ""));
                    break;
                case "1":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, "images/Star White Filled.png"));
                    break;
                case "2":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, "images/2Star.png"));
                    break;
                case "3":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, "images/3Star.png"));
                    break;
                case "4":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, "images/4Star.png"));
                    break;
                case "5":
                    imgEnt.Source = new BitmapImage(new Uri(this.BaseUri, "images/5Star.png"));
                    break;
            }
        }

        private void sldInformative_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //informativeText.Text = sldInformative.Value.ToString();
            String val = sldInformative.Value.ToString();

            switch (val)
            {
                case "0":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, ""));
                    break;
                case "1":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, "images/Star White Filled.png"));
                    break;
                case "2":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, "images/2Star.png"));
                    break;
                case "3":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, "images/3Star.png"));
                    break;
                case "4":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, "images/4Star.png"));
                    break;
                case "5":
                    imgInf.Source = new BitmapImage(new Uri(this.BaseUri, "images/5Star.png"));
                    break;
            }
        }

        private void sldFoodQuality_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //foodQualText.Text = sldFoodQuality.Value.ToString();
            String val = sldFoodQuality.Value.ToString();

            switch (val)
            {
                case "0":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, ""));
                    break;
                case "1":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/Star White Filled.png"));
                    break;
                case "2":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/2Star.png"));
                    break;
                case "3":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/3Star.png"));
                    break;
                case "4":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/4Star.png"));
                    break;
                case "5":
                    imgFoodQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/5Star.png"));
                    break;
            }
        }

        private void sldServerQuality_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //serverQualText.Text = sldServerQuality.Value.ToString();
            String val = sldServerQuality.Value.ToString();
            

            switch (val)
            {
                case "0":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, ""));
                    break;
                case "1":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/Star White Filled.png"));
                    break;
                case "2":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/2Star.png"));
                    break;
                case "3":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/3Star.png"));
                    break;
                case "4":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/4Star.png"));
                    break;
                case "5":
                    imgServQual.Source = new BitmapImage(new Uri(this.BaseUri, "images/5Star.png"));
                    break;
            }
        }


    }
}
