namespace Maui.MathGame.Speedierone;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

	private void OnDelete(object sender, EventArgs e)
	{
		Button button = (Button)sender;

		App.GameRepository.Delete((int)button.BindingContext);

		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

	private void GoToMainMenuOnEvent(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
}