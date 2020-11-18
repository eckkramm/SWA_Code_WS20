using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SimpleChatClient;


using System.Collections.ObjectModel;

namespace WpfChatClient.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ConnectBtnClickCmd { get; set; }
        public RelayCommand SendBtnClickCmd { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public ObservableCollection<string> ReceivedData { get; set; }

        bool isConnected = false;
        Client client;
        public MainViewModel()
        {
            Message = "";
            Name = "";
            ConnectBtnClickCmd = new RelayCommand(
                () => {
                    client = new Client(10100);
                    client.SendData(Name + "\r\n"); //Send name information
                    isConnected = true;
                }, //Action - what to do after button clicked
                () => { return !isConnected && Name.Length>1; }); //is Clickable?

            SendBtnClickCmd = new RelayCommand(
                () => { client.SendData(Message +"\r\n"); },
                () => { return isConnected && Message.Length > 1; });
            
        }
    }
}