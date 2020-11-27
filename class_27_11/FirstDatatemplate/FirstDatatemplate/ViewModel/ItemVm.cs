using GalaSoft.MvvmLight;

namespace FirstDatatemplate.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        public string OrderId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string Prio { get; set; }
        public decimal Price { get; set; }

        public decimal FullPrice
        {
            get { return Price*Amount; }
           
        }

    }
}