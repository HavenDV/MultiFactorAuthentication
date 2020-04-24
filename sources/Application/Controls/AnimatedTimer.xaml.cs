using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MultiFactorAuthentication.Controls
{
    public class AnimatedTimer : UserControl
    {
        public AnimatedTimer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}