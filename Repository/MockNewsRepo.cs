using Haber.Models;
using System.Collections.Generic;
using System.Linq;

namespace Haber.Repository
{
    public class MockNewsRepo : newRepository
    {
        private List<New> _newList;

        public MockNewsRepo()
        {
            _newList = new List<New>()
            {
                new New { Id=1, Type= "Spor", Title= "Fenerbahçenin yeni transferi", Text= "Transfer çalışmalarına hız kesmeden devam eden Fenerbahçe, Beşiktaş’ta sözleşmesi sona eren 33 yaşındaki santrfor Cenk Tosun’u 2 yıllığına kadrosuna kattığını açıkladı. Sarı-lacivertli kulüpten yapılan açıklamada, “Fenerbahçemiz, kadrosunu millî futbolcu Cenk Tosun ile güçlendirdi. Tecrübeli golcü kendisini 2 yıllığına Sarı Lacivert renklere bağlayan sözleşmeye imza attı. Cenk Tosun’a ‘Ailemize hoş geldin’ diyor; Fenerbahçemiz ile başarılar diliyoruz” ifadelerine yer verildi.", Photo="1.jpg"},
                new New { Id=2, Type = "Spor" ,Title= "Galatasaray’da Mathias Ross Sparta Prag’a kiralandı", Text= "Sarı-kırmızılı kulüpten yapılan açıklamada, “Profesyonel futbolcumuz Mathias Ross Jensen’in 2024-2025 sezonu için şarta bağlı satın alma opsiyonlu geçici transferi konusunda AC Sparta Praha Fotbal A.S. ile anlaşmaya varılmıştır. Yapılan anlaşmaya göre, satın alma opsiyonunun gerçekleşmesi durumunda AC Sparta Praha Fotbal A.S. kulübümüze kesin transfer bedeli olarak 1.200.000 euro ödeyecektir. İlaveten anlaşmada 300.000 euro tutarında şarta bağlı bonus yer almaktadır” ifadelerine yer verildi.", Photo="2.jpg"},
                new New { Id=3, Type="Ekonomi", Title= "Euro 36₺ oldu.", Text= "Kur güncellendi Euro 36₺ oldu.", Photo="3.jpg"},
                new New { Id=4, Type= "Ekonomi", Title= "Ekonomi bakanı haber verdi!", Text= "Bakan Şimşek, sosyal medya hesabı üzerinden açıklamada bulundu. Bakan Şimşek,Vergide adaleti artırmaya ve kayıt dışılığı azaltmaya yönelik çalışmalarımız aralıksız sürüyor. Aylık harcamaları 5 milyon TL’nin üzerinde olup hiç gelir beyan etmeyen kişileri gerçek kazançlarını vergilendirmek üzere denetim kapsamına alıyoruz. IBAN veya 'mail order' ödeme yönetimi ile tahsilat yaparak vergisini ödemeyen işletmeler de inceleniyor. Vergi kayıp ve kaçağına sebebiyet vererek haksız kazanç sağlayanların ve haksız rekabet oluşturanların takipçisi olmaya devam edeceğiz ifadelerini kullandı.", Photo="4.jpg"},
                 new New { Id=5, Type="Ekonomi", Title= "Euro 36₺ oldu.", Text= "Kur güncellendi Euro 36₺ oldu.", Photo="3.jpg"},
                  new New { Id=6, Type="Spor", Title= "Fenerbahçe Haberi", Text= "Yeni haber", Photo="1.jpg"},
                   new New { Id=7, Type="Ekonomi", Title= "Euro 36₺ oldu.", Text= "Kur güncellendi Euro 36₺ oldu.", Photo="3.jpg"},
                    new New { Id=8, Type="Spor", Title= "Fenerbahçe", Text= "Turu geçti.", Photo="1.jpg"},
                     new New { Id=9, Type="Ekonomi", Title= "Euro 36₺ oldu.", Text= "Kur güncellendi Euro 36₺ oldu.", Photo="3.jpg"},
                      new New { Id=10, Type="Spor", Title= "Galatasaray", Text= "haberleri", Photo="2.jpg"}
            };
        }

        public IEnumerable<New> GetAll()
        {
            return _newList;
        }

       public New GetById(int id)
          {
            return _newList.FirstOrDefault(n => n.Id == id) ?? new New(); 
          }


    }
}
