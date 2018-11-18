using System.Collections.Generic;
using System.Linq;

namespace Komis.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if (samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod { Id=1, Marka="Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Opis = "Opis 1", Cena = 10000, ZdjecieUrl="/images/fordMustang.jpg", MiniaturkaUrl="images/fordMustang.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=2, Marka="Audi", Model = "S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc = "3 000 cm3", RodzajPaliwa = "benzyna", Moc = "280 KM", Opis = "Opis 2", Cena = 350000, ZdjecieUrl="/images/audiS5.jpg", MiniaturkaUrl="images/audiS5.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=5, Marka = "Nissan", Model = "Skyline", RokProdukcji = 1995, Przebieg = "144 000 km", Pojemnosc = "2 500 cm3", RodzajPaliwa = "benzyna", Moc = "410 KM", Opis = "Opis 5", Cena = 280000, ZdjecieUrl="/images/nissanSkyline.jpg", MiniaturkaUrl="images/nissanSkyline.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=4, Marka = "Chevrolet", Model = "Corveta", RokProdukcji = 1972, Przebieg = "28 000km", Pojemnosc = "5 700 cm3", RodzajPaliwa = "benzyna", Moc = "300 KM", Opis = "Opis 4", Cena = 120000, ZdjecieUrl="/images/chevroletCorvete.jpg", MiniaturkaUrl="images/chevroletCorvete.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=6, Marka = "Jaguar", Model = "ZX", RokProdukcji = 2006, Przebieg = "78 000 km", Pojemnosc = "5 000 cm3", RodzajPaliwa = "benzyna", Moc = "510 KM", Opis = "Opis 6", Cena = 2000000, ZdjecieUrl="/images/jaguarZX.jpg", MiniaturkaUrl="images/jaguarZX.jpg", JestSamochodemTygodnia = true},
                new Samochod { Id=3, Marka = "BMW", Model = "X4", RokProdukcji = 2017, Przebieg = "4 300 km", Pojemnosc = "1 995 cm3", RodzajPaliwa = "benzyna", Moc = "190 KM", Opis = "Opis 3", Cena = 250000, ZdjecieUrl = "/images/bmwX4.jpg", MiniaturkaUrl = "images/bmwX4.jpg", JestSamochodemTygodnia = true },
            };
        }

        public Samochod PobierzSamochodOId(int samochodID)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodID);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return samochody;
        }
    }
}
