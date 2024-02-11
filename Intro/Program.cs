// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

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


Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";

Course[] courses = { course1, course2, course3 };
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Id + " / " + courses[i].Name);
}


CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

int number1 = 10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value types -->int, bool,double...
//reference types --> array, class, interface...
//101        //102     //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}