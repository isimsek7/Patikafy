using Patikafy;
List<object> DataList = new List<object>();

DataList.Add(new Data("Ajda Pekkan", "Pop", 1968, 20));
DataList.Add(new Data("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10));
DataList.Add(new Data("Funda Arar", "Pop", 1999, 3));
DataList.Add(new Data("Sertab Erener", "Pop", 1994, 5));
DataList.Add(new Data("Sıla", "Pop", 2009, 3));
DataList.Add(new Data("Serdar Ortaç", "Pop", 1994, 10));
DataList.Add(new Data("Tarkan", "Pop", 1992, 40));
DataList.Add(new Data("Hande Yener", "Pop", 1999, 7));
DataList.Add(new Data("Hadise", "Pop", 2005, 5));
DataList.Add(new Data("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10));
DataList.Add(new Data("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2));

var snames = DataList.Cast<Data>().Where(data => data.sanatciAdi.StartsWith('S')).Select(data => data.sanatciAdi);
Console.WriteLine("S ile baslayan sanatci adlari");
foreach (var e in snames) Console.WriteLine(e);
Console.WriteLine("Satisi 10 milyonun uzerinde olan sanatcilar");
var aboveTen = DataList.Cast<Data>().Where(data => data.sold > 10).Select(data => data.sanatciAdi);
foreach (var e in aboveTen) Console.WriteLine(e);
Console.WriteLine("2000 sonrasi Pop");
var after2000 = DataList.Cast<Data>().Where(data => data.date > 2000 && data.janra.Contains("pop", StringComparison.OrdinalIgnoreCase))
    .GroupBy(data => data.date).OrderBy(group => group.Key).SelectMany(group => group.Select(data => new
    {
        Tarih = group.Key,
        Sanatci = data.sanatciAdi,
        Tur = data.janra
    }));
            

foreach (var e in after2000) Console.WriteLine("{0} ìsimli sanatci, {1}'yilinda {2}'muzigi ile ugrasiyordu.",e.Sanatci,e.Tarih,e.Tur);
var maxAlbums = DataList.Cast<Data>().Max(data => data.sold);
var nameOfMax = DataList.Cast<Data>().First(data => data.sold==maxAlbums);
Console.WriteLine("En cok album satan sanatci: {0}",nameOfMax.sanatciAdi);
var firstLast = DataList.Cast<Data>().Min(data => data.date);
var nameOfOldest = DataList.Cast<Data>().Last(data => data.date == firstLast);
Console.WriteLine("En eski cikis yapan: {0}",nameOfOldest.sanatciAdi);
var latest = DataList.Cast<Data>().Max(data => data.date);
var nameOfNew = DataList.Cast<Data>().First(data => data.date == latest);
Console.WriteLine("En yeni cikis yapan: {0}",nameOfNew.sanatciAdi);

       




