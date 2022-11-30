namespace List_View_Maui;

public partial class MainPage : ContentPage
{
	List<string> animalList = new List<string>()
	{
		"Dog", "Rat", "Walrus", "Llama", "Hippopotamus", "Armadillo", "Snake", "Kangaroo", "Penguin", "Aye-Aye", "Hammerhead Shark"
	};

	public MainPage()
	{
		InitializeComponent();
		lvOfAnimals.ItemsSource = animalList;

	}


}

