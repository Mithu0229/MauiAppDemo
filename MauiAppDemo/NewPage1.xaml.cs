namespace MauiAppDemo;

public partial class NewPage1 : ContentPage
{
	private int count = 0;
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;
        lblCounter.Text = count.ToString();
        SemanticScreenReader.Announce(lblCounter.Text);
    }
}