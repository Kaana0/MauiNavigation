namespace MauiNavigation;

public partial class MainPage : ContentPage
{
    public string Navi { get; set; } //タイトルのゲッター・セッター

    public MainPage(string title)
    {
        InitializeComponent();
        this.Navi = title + "Main > ";
        this.BindingContext = this;
    }

    //サブページへ
    private void OnPush(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPage(Navi));
    }

    //前のページへ
    private void OnPop(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    //初期画面へ
    private void OnPopRoot(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}


