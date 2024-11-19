using Microsoft.Maui.Controls;

namespace MiracleListVueHybridDemo
{
  public partial class MainPage : ContentPage
  {


    public MainPage()
    {
      InitializeComponent();
    }

    private void OnSendMessageButtonClicked(object sender, EventArgs e)
    {
      hybridWebView.SendRawMessage(messageText.Text);
    }

    private async void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
    {
      await DisplayAlert("Raw Message Received", e.Message, "OK");
    }

  }

}
