using GalaSoft.MvvmLight;

namespace FirstDatatemplate.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        private decimal price;
        private int amount;

        public string OrderId { get; set; }
        public string Description { get; set; }
        public int Amount
        {
            get => amount; set
            {
                amount = value;
                RaisePropertyChanged("FullPrice");
            }
        }
        public string Prio { get; set; }
        public decimal Price
        {
            get => price; set
            {
                price = value;
                RaisePropertyChanged("FullPrice");
            }
        }

        public decimal FullPrice
        {
            get { return Price * Amount; }

        }
        public ItemVm()
        {
            OrderId = "";
        }

    }
}