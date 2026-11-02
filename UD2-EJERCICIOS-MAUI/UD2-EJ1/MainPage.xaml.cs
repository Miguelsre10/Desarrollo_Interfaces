using Microsoft.Maui.Graphics;

namespace UD2_EJ1
{
    public partial class MainPage : ContentPage
    {

        private int red = 0;
        private int green = 0;
        private int blue = 0;

        private String hexcolor = "#000000";

        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_red_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            red = (int)e.NewValue;
            CreateColor(red, green, blue);
        }

        private void Slider_green_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            green = (int)e.NewValue;
            CreateColor(red, green, blue);
        }

        private void Slider_blue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            blue = (int)e.NewValue;
            CreateColor(red, green, blue);
        }

        private void CreateColor (int red, int green, int blue)
        {
            hexcolor = $"#{red:X2}{green:X2}{blue:X2}";
            Pagina.BackgroundColor = Color.FromArgb(hexcolor);
            Lcolor.Text = "Hex Color: " + hexcolor;
            BtnRandom.Background = Color.FromArgb(hexcolor);
        }

        private void BtnRandom_Clicked(object sender, EventArgs e)
        {
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue= random.Next(0, 256);

            Slider_red.Value= red;
            Slider_green.Value= green;
            Slider_blue.Value= blue;
            CreateColor(red, blue, green);
        }
    }
}
