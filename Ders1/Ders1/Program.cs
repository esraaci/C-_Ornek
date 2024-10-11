int sayi1, sayi2, toplam = 0;

Console.Write("1.Sayıyı Giriniz: ");
sayi1 = int.Parse(Console.ReadLine());


Console.Write("2.Sayıyı Giriniz: ");
sayi2 = int.Parse(Console.ReadLine());

toplam = sayi1 + sayi2;

Console.WriteLine("Toplam: " + toplam);

Console.ReadLine();