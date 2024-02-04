// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Daha farklı örnekler burda https://www.w3schools.com/cs/cs_intro.php 

string message1 = "Krediler";
int term = 12;
double amount = 10000;

//variable - camelCase -> case converter link : https://appdevtools.com/case-converter
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition https://www.w3schools.com/cs/cs_conditions.php
if (isAuthenticated == true) //if (isAuthenticated) Buda bir farklı yazılışı.
{
    Console.WriteLine("Hoşgeldiniz...");
}

//Daha farklısı {} süslü parantezleri olmazsa sadece 1 satır olur
//{} olursa o blok içerisini kapsar.
if (!isAuthenticated)
    Console.WriteLine("Giriş yapmadınız.");

//snippets örnekler. https://www.bytehide.com/blog/csharp-code-snippets-for-everyday-problems


//-----------------------------------------------------------------------------------------------
//string[] loans2 = new string[2];
//loans2[0] = "Kredi1";
//loans2[1] = "Kredi2";

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

//Bir dizi ve koleksiyonları iterasyon gerçekleştirerek her bir elemana erişip işlem yapabiliriz.
//Fakat loans üzerinde bir değişiklik yaparsanız foreach içerisinde exception alırsınız
//buna dikkat edin sadece mantıksal sınamalar yada farklı atamalar yapın ama siz siz olun
//array yada koleksiyonun içeriğindeki bir değeri asla değiştirmeyin. 2. bir koleksiyon
//yada dizi oluşturarak buna değer ataması ve değiştirme yapın. 

//foreach (string loan in loans)
//{
//    Console.WriteLine(loan);
//}

//Başlangıç değeri,   Dizi uzunluğundan döngü sayısı,  Değeri artırıyoruz.
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}