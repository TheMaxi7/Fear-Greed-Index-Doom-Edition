using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fear_and_Greed_Index_Doom_Edition
{
    public partial class MainWindow : Window
    {
        private FearAndGreedIndexFetcher _indexFetcher;

        public MainWindow()
        {
            InitializeComponent();
            _indexFetcher = new FearAndGreedIndexFetcher();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            int indexValue;
            string indexState;
            (indexValue, indexState) = await _indexFetcher.FetchIndexValueAsync();
            fearAndGreedIndexValue.Text = indexValue.ToString();
            fearAndGreedIndexState.Text = indexState.ToString();

            if (indexState.ToString() == "Extreme Fear")
            {
                doomguyImage.Source = new BitmapImage(new Uri("C:\\Users\\david\\Desktop\\github\\Fear-and-Greed-Index-Doom-Edition\\doomguy\\extreme_fear.png"));
                doomguyImage.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
                fearAndGreedIndexValue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e3242b"));
                fearAndGreedIndexValue.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 80,
                    ShadowDepth=0
                };
                fearAndGreedIndexState.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e3242b"));
                fearAndGreedIndexState.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
            }
            else if (indexState.ToString() == "Fear")
            {
                doomguyImage.Source = new BitmapImage(new Uri("C:\\Users\\david\\Desktop\\github\\Fear-and-Greed-Index-Doom-Edition\\doomguy\\fear.png"));
                doomguyImage.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
                fearAndGreedIndexValue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e3242b"));
                fearAndGreedIndexValue.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
                fearAndGreedIndexState.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e3242b"));
                fearAndGreedIndexState.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#e3242b"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
            }
            else if (indexState.ToString() == "Extreme Greed")
            {
                doomguyImage.Source = new BitmapImage(new Uri("C:\\Users\\david\\Desktop\\github\\Fear-and-Greed-Index-Doom-Edition\\doomguy\\extreme_greed.png"));
                doomguyImage.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
                fearAndGreedIndexValue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98fb98"));
                fearAndGreedIndexValue.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
                fearAndGreedIndexState.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98fb98"));
                fearAndGreedIndexState.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
            }
            else if (indexState.ToString() == "Greed")
            {
                doomguyImage.Source = new BitmapImage(new Uri("C:\\Users\\david\\Desktop\\github\\Fear-and-Greed-Index-Doom-Edition\\doomguy\\greed.png"));
                doomguyImage.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
                fearAndGreedIndexValue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98fb98"));
                fearAndGreedIndexValue.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
                fearAndGreedIndexState.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98fb98"));
                fearAndGreedIndexState.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#98fb98"),
                    BlurRadius = 40,
                    ShadowDepth = 0
                };
            }
            else
            {
                doomguyImage.Source = new BitmapImage(new Uri("C:\\Users\\david\\Desktop\\github\\Fear-and-Greed-Index-Doom-Edition\\doomguy\\neutral.png"));
                doomguyImage.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#ffffff"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
                fearAndGreedIndexValue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
                fearAndGreedIndexValue.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#ffffff"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
                fearAndGreedIndexState.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
                fearAndGreedIndexState.Effect = new DropShadowEffect()
                {
                    Color = (Color)ColorConverter.ConvertFromString("#ffffff"),
                    BlurRadius = 80,
                    ShadowDepth = 0
                };
            }
        }

    }
}
