using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace CompositeModeMinBlend
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
    {
		public ObservableCollection<Item> Data { get; set; } = new ObservableCollection<Item>();

		public MainPage()
        {
			for (int i = 0; i < 500000; i++)
			{
				Data.Add(new Item { Text = "Text " + i, Hint = "Hint " + i });
			}

            this.InitializeComponent();
        }
    }
}
