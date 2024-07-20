Console.WriteLine("Kim Milyoner Olmak İster ? Bilgi yarışmasına hoşgeldiniz!");
Console.WriteLine("Yarışmacı 3 sorudan 2'sini doğru cevaplar ise 1 Milyon TL'lik büyük ödülü kazanacak!");                           //Giriş Bölümü
Console.WriteLine("Cevaplayacağınız her soru için sadece seçenek şıkkkını (a,b) ekrana giriniz.");
Console.WriteLine("İlk sorunuz geliyor.....\n");
Console.WriteLine("1 ->  Çok üzülen birinin, halk arasında, burnunun nesinin sızladığı söylenir ?" + "a) Kemik b) Direk ");
string reply1 = Console.ReadLine().ToLower();
byte point = 0;

switch (reply1)
{
	case "b":
		Console.WriteLine("Doğru bildiniz.Tebrikler...");                                           //  1.SORU
		point += 1;
		break;
	default:
		Console.WriteLine("Yanlış bildiniz!!!");
		break;
}
Console.WriteLine("--------------------------------------------------");

Console.WriteLine("2 ->  Hangi enstrüman hem dizlerin arasına hem koltuk altına konularak çalınır ?" + "a) Darbuka b) Klarnet ");               
string reply2 = Console.ReadLine().ToLower();

switch (reply2)
{
    case "a":
        Console.WriteLine("Doğru bildiniz.Tebrikler...\n");                                         //  2.SORU                                                                             
        point += 1;
        break;
    default:
        Console.WriteLine("Yanlış bildiniz!!!");
        break;
}

if (point == 2)
{
    Console.WriteLine("Yarışmayı siz kazandınız.Büyük ödül sizin...");
    Environment.Exit(0);                                                      //Yarışma sonlandığı için program kapatma kodu kullanılmıştır.
}
else if (point == 0)
{
    Console.WriteLine("2 soruyu da doğru cevaplamadığınız için yarışmadan elendiniz!!!");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Final sorumuz ile yarışmaya devam ediyoruz.");
}

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("3 ->  Yemekten sonra Eline sağlık diyen kişiye verilen cevapta, afiyet ile birlikte hangisi olsun denilir?" + "a) Lokum b) Şeker ");
string reply3 = Console.ReadLine().ToLower();

switch (reply3)
{
    case "b":
        Console.WriteLine("Doğru bildiniz.Tebrikler...");                                               //  3.SORU
        point += 1;
        break;
    default:
        Console.WriteLine("Yanlış bildiniz!!!");
        break;
}

if (point>= 2)
{
    Console.WriteLine("Yarışmayı siz kazandınız.Büyük ödül sizin...");
}
else
{
    Console.WriteLine("Yarışmayı kaybettiniz. Geçmiş olsun!!!");
}

