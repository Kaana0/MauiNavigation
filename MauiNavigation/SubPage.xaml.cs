namespace MauiNavigation;

public partial class SubPage : ContentPage
{
    public string Navi { get; set; }//タイトルのゲッターセッター

    public SubPage(string title)
    {
        InitializeComponent();
        this.Navi = title + "Sub > ";
        this.BindingContext = this;
    }

    //メインページへ
    private void OnPush(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage(Navi));
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


