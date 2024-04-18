namespace MauiAppDemo;

public class TestPage : ContentPage
{
	int count = 0;
	Label lblCounter;
	public TestPage()
	{
		var scrollView = new ScrollView();
		var stackLayout = new StackLayout();
		scrollView.Content = stackLayout;
		lblCounter = new Label
		{
			Text = "count : 0",
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center

		};
		stackLayout.Children.Add(lblCounter);

		var btnCounter = new Button
		{
			Text = "Click to Count",
			HorizontalOptions = LayoutOptions.Center,
		};
		stackLayout.Children.Add(btnCounter);
		btnCounter.Clicked += OnClickedEvent;
		this.Content = scrollView;
	}

	private void OnClickedEvent(object sender, EventArgs e)
	{
		count++;
		lblCounter.Text = count.ToString();
		SemanticScreenReader.Announce(lblCounter.Text);
	}
}