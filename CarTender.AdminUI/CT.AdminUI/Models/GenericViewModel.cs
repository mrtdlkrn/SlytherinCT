using System.Collections.Generic;

namespace CT.AdminUI.Models
{
    public class GenericViewModel
    {
        //Form'da donus yapacagimiz Controller ismi
        public string ModelName { get; set; }

        //DTO objelerimizi gonderecegimiz model
        public object MyModel { get; set; }

        //Sayfa sekmesinin basligi
        public string Title { get; set; }

        //Sayfa basligi
        public string PageHeader { get; set; }

        //Sayfa baslik detay bilgileri
        public string Information { get; set; }
    }
}
