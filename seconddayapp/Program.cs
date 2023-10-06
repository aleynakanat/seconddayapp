//  app.AppGet("/") veya home ifadesi anasayfada olduğumuzu belirtir
//değer veri yapısı char 
// char karakter 
// int değer atama tam sayılar
// uint ushort
// double float değeri yazıldıktan sonra f koyulur ayrım için double daha büyük sayılar için temel yapılar için float

//referans veri tipi

String r = "Aleyna";
r += "Kanat";
r = r + "Aleyna";
Console.WriteLine(r);

//işaretçi veri tipi
int m = 10;
int p = 20;
int sonuc = m * p;
Console.WriteLine("Deger: {0}", sonuc);

//operatörler
// == verilen işlenenin eşit olup olmadığını kontrol eder aksi halde false olur
// != veriler eşitse false döndürür değilse true döndürür
// > < büyüktür küçüktür
// <= >= büyük eşit küçük eşit

// else değilse for için 
// go to atlama
// bağlamsal anahtar kelimeler
//  var= variable değişken değer int veya başka bir şey yerine var string hata payını azaltır
// get ve set get ile komut alınıp set ile uygulanır ayarlanır modalda yazılır

int x = 1;
while (x <= 4)
{
    Console.WriteLine("aleynakanat");
    x++;
}

//karar durumlarında if kullanılır, sürdürebilir şartlar sağlanana kadar işin yapılması için while kullanılır
string name = "Aleyna";
if (name== "Aleyna")
{
    Console.WriteLine("Aleyna Kanat");
}

//if else yapısı
int y = 15;
{
    if (y == 10)
        Console.WriteLine("y 10dur");
    else if (y == 15)
        Console.WriteLine("y 15tir");
    else
        Console.WriteLine("y tanımlanamadı");
}

int i = 10;
if (i ==10)
{
    if (i < 12)
        Console.WriteLine("i 12den küçüktür");
    else if (i > 12)
        Console.WriteLine("i 12den büyüktür");
}

// switch case, şart kontrolüdür, switch istediğimiz değerdir case ise bunu kontrol eder case'den sonra ":" iki nokta kullanılır 
int numb = 40;
switch (numb)
{
    case 10:
        Console.WriteLine("case 10");
        break;
    case 20:
        Console.WriteLine("case 20");
        break;
    default:
        Console.WriteLine("eslesme yok");
        break;
}
// eşleşme olsa bile mutlaka break kullanılmalıdır
