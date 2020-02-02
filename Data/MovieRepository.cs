using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        public static List<Movie> Movies { get { return _movies; } }
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() { Id=1, Name="It", CategoryId=1,ShortDescription="It", Description= "Ezikler Kulübü olarak adlandırdıkları arkadaş ortamındaki çocuklar 27 yıl sonra birer yetişkin insan olmuşlardır ve paylaço şeytanın geri dönüşü ile tekrar bir araya gelme kararı alırlar. Pennywise, küçük çocuklar tarafından yenilgiye uğratılmasının ardından, Derry kasabasına geri döner. Artık yetişkin birey haline gelen Ezikler Kulübü üyeleri de kendi hayatlarını kurdukları için birbirlerinden ayrılmışlardır. Ancak, Mike aynı kasabada yaşamaya devam etmektedir ve yıllar önce olduğu gibi insanların tekrar ortadan kaybolmaya başlaması sonucunda arkadaşlarına ulaşarak herkesi bir araya toplama kararı alır. Şeytani varlık Pennywise’ın geri dönüşü ile bir araya gelen arkadaşlar birbirlerini yeniden tanıyacaktır…", ImageUrl="5.jpg" },
                new Movie() { Id=2, Name="Ad Astra", CategoryId=1, ShortDescription="Ad Astra", Description= " <p>Roy McBride bir astronottur ve babası da 20 yıl önce uzayda hayat olup olmadığını araştırmak için görevlendirilmiştir. Fakat babası bu görev sırasında kaybolmuş ve kendisinden bir daha haber alınamamıştır. Roy McBride, gezegeni tehdit eden bir gizemi çözmek ve aynı zamanda kaybolan babasını bulabilme umuduyla uzayın derinliklerine doğru yolculuk edecektir. Bu sonu bilinmez yolculuk, Roy’un beklediğinin çok daha üzerinde farklı şeyler öğrenmesine sebep olacaktır… </p><p>Yıldızlara Doğru filmi, macera, dram ve gizem türüyle dikkat çekerken, başrol kadrosunda başta Brad Pitt olmak üzere Tommy Lee Jones v Ruth Negga gibi isimleri görüyoruz. Yönetmenliğini James Gray’in yaptığı Ad Astra izleyenlerin karşısına 20 Eylül 2019 tarihinde çıkmıştır.</p>", ImageUrl="4.jpg" },
                new Movie() { Id=3, Name="A Beatiful Day In The Neighborhood", CategoryId=2, ShortDescription="A Beatiful Day In The Neighborhood", Description= " <p> Fred Rogers ve gazeteci Tom Junod arasındaki yaşanan olaylara dayanan Mahallede Güzel Bir Gün filminin başrolünde Tom Hanks oynuyor. Yönetmenliğini Marielle Heller’in üstlendiği A Beautiful Day in the Neighborhood – Mahallede Güzel Bir Gün filmi 22 Kasım 2019 tarihinde gösterime girdi.</p><p>Bıkkın bir gazeteci olan Tom Junod’un Fred Rogers ile birlikte iş yapmaya başlamasından sonra kurduğu arkadaşlık sayesinde empati yapmayı ve insanlara karşı nazik davranmayı öğrenecektir…</p>", ImageUrl="1.jpg" },
                new Movie() { Id=4, Name="The Irishman", CategoryId=3, ShortDescription="The Irishman", Description= " <p>1950’lerde kamyon şoförlüğü yapan Frank Sheeran, Russell Bufalino ve Pennsylvania’daki suç ailesiyle temas sağlar. Sheeran, mafyanın en iyi tetikçisi olma yolunda ilerlerken ayrıca organize suç şebekeleriyle bağı olan Jimmy Hoffa adına çalışır. 2019 Netflix yapımı The Irishman filminin başrollerinde Al Pacino ve Robert De Niro oynuyor. Biyografi, suç ve dram türündeki The Irishman filmi 7 ödüle sahip.</p>", ImageUrl="2.jpg" },
                new Movie() { Id=5, Name="Gemini Project", CategoryId=1, ShortDescription="Gemini Project", Description= " <p>Kiralık katil işi konusunda gerçekten uzman biri olarak bilinen Henry, bu tip işlerden sıyrılarak hayatına yeni bir yön verme peşindedir. Ancak hiç beklemediği bir anda büyük bir kumpasın içine düşer. Henry’nin peşine bir kiralık katil düşmüştür ve bu kiralık katil Henry’nin bir klonudur. Yaklaşık 25 yıl önce Henry’den alınan dna örnekleriyle oluşturulan bu klon, Henry’nin her türlü hareketini, neler yapacağını bildiği için her şeyi önceden tahmin etmektedir.</p><p>Pi’nin Yaşamı gibi pek çok kült filme yönetmenlik yapmış olan Ang Lee’nin kamera arkasına geçtiği Gemini Man filmi kadrosunda Will Smith, Mary Elizabeth Winstead ve Clive Owen gibi ünlü isimler yer alıyor. Dram, bilim kurgu ve aksiyon türü ile 11 Ekim 2019 tarihinde Türk sinemalarında yerini alacaktır…</p>", ImageUrl="3.jpg" }
            };
        }
        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }
        public static Movie GetMovieById(int Id)
        {
            return _movies.FirstOrDefault(x => x.Id == Id);
        }
    }
}
