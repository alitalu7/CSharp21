

Ciftlik.DisiSayisi = 20;
Ciftlik.ErkekSayisi = 20;
int mevcut = Ciftlik.Mevcut(Ciftlik.ErkekSayisi, Ciftlik.DisiSayisi);

Console.WriteLine($"Çiftlikte bulunan dişi sayısı = {Ciftlik.DisiSayisi}");
Console.WriteLine($"Çiftlikte bulunan erkek sayısı = {Ciftlik.ErkekSayisi}");
Console.WriteLine($"Çifliğin toplam mevcudu = {mevcut}");

static class Ciftlik
{
    private static string ad;
    private static int ayakSayisi;
    private static char kanat;
    private static int disiSayisi;
    private static int erkekSayisi;

    public static string Ad { get => ad; set => ad = value; }
    public static int AyakSayisi { get => ayakSayisi; set => ayakSayisi = value; }
    public static char Kanat { get => kanat; set => kanat = value; }
    public static int DisiSayisi { get => disiSayisi; set => disiSayisi = value; }
    public static int ErkekSayisi { get => erkekSayisi; set => erkekSayisi = value; }

    public static int Mevcut(int a , int b)
    {
        return a + b;
    }
}