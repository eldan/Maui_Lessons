namespace MauiApp1;

public partial class Example : ContentPage
{
    private string[] arrOfImages = { "p_1.jpg", "p_2.jpg", "p_3.jpg", "p_4.jpg" };
    int indexImage = 0;
	public Example()
	{   
        InitializeComponent();
        UpdateSlideShowImage();
        HandleHideShowButtonText(true);
    }

    private void btnHide1_Clicked(object sender, EventArgs e)
    {
        layoutSlideShow.IsVisible = !layoutSlideShow.IsVisible;
        HandleHideShowButtonText(layoutSlideShow.IsVisible);
    }

    private void Button_Down_Clicked(object sender, EventArgs e)
    {
        indexImage++;
        if (indexImage > arrOfImages.Length-1) indexImage = 0;
        UpdateSlideShowImage();
    }

    private void Button_Up_Clicked(object sender, EventArgs e)
    {
        indexImage--;
        if (indexImage < 0) indexImage = arrOfImages.Length-1;
        UpdateSlideShowImage();
    }
    private void UpdateSlideShowImage()
    {
        imgSlideShow.Source = arrOfImages[indexImage];
    }
    private void HandleHideShowButtonText(bool tf)
    {
        if (tf) btnHide.Text = "Hide SlideShow";
        else btnHide.Text = "Show SlideShow";
    }
}