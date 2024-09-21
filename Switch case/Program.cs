

////Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin

//string[] words = { "phone", "laptop", "mouse", "keyboard", "screen", "panel", "console" };

//for (int i = 5; i < words.Length; i++)
//{
//    Console.WriteLine(words[i]);
//}



////Rəqəmlərdən ibarət massivi tərsinə cevir və cüt ədədləri ekrana cıxatsın.Məsələn:Giriş: [1, 2, 3, 4, 5, 6] Çıxış: [6, 4, 2]



//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
//for (int i = numbers.Length; i > 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}
//array.reverse(numbers);


//console.write("cut ededler: ");

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        console.write(number);
//    }
//}


//Verilən massivdə palindrome olan elementləri tapın
//(oxunuşu həm soldan sağa, həm də sağdan sola eyni olan ədəd və ya sözlər).Məsələn:Giriş: ["level", "hello", "radar", "world"] Çıxış: ["level", "radar"]


//string[] words = { "level", "hello", "radar", "world" };


//Console.WriteLine(words[0]);
//Console.WriteLine(words[2]);





































































//using System.ComponentModel.Design;

//string[] fruits = { "apple", "banana", "grapes", "orange" };

//int numberofFruits = fruits.Length;

//Console.WriteLine("Total number of fruits " + ":" + numberofFruits);

//for (int i = 0; i < fruits.Length; i++)
//{
//    Console.WriteLine(fruits[i]+"");
//}

//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}
//Console.WriteLine("Number of fruits: " + fruits.Length);


//for (int i = 0; i < fruits.Length; i++)
//{
//    Console.WriteLine(fruits[i]);
//}
//Console.WriteLine("Enter a fruit to search: ");
//if(fruits.Length > 0 )
//string sart=Console.ReadLine();
//Console.WriteLine(fruits);



////1-den 10a qeder olan ededlerin cemini tapin
//int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8, y = 9, z = 10;
//int result=a+b+c+d+e+f+g+h+y+z;
//Console.WriteLine(result);



//2nd version of 1st exercise
//using System.Globalization;

//int sum = 0;
//for (int i = 0; i < 20; i++)
//{
//    sum+=i;//sagdaki sum-in degerini sola atiyor
//}
//Console.WriteLine(sum);

//3rd version of 1st exercise
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += i;

//}

//Console.WriteLine(sum);





//Verilmis ededin tek ve ya cut oldugunu tapin 2nd exercise


//int number = 3;

//if(number%2==0)
//{
//    Console.WriteLine("Bu reqem cut reqemdir");
//}
//else if (number%2==1)
//{
//    Console.WriteLine("Bu reqem tek reqemdir");
//}

//else
//{
//    Console.WriteLine("Bu reqem 0 a beraberdir");
//}


//for (int i = 1; i < 20; i+=2)
//{
//    Console.WriteLine(i);
//    //tek reqemleri yazdirdi
//}


//switch (1)
//{
//    case 1:
//        Console.WriteLine("yanvar");
//        break;
//    case 2:
//        Console.WriteLine("fevral");
//        break;
//    case 3:
//        Console.WriteLine("mart");
//        break;
//    case 4:
//        Console.WriteLine("aprel");
//        break;
//    case 5:
//        Console.WriteLine("may");
//        break;
//    case 6:
//        Console.WriteLine("iyun");
//        break;
//    case 7:
//        Console.WriteLine("iyul");
//        break;
//    case 8:
//        Console.WriteLine("avqust");
//        break;
//    case 9:
//        Console.WriteLine("sentyabr");
//        break;
//    case 10:
//        Console.WriteLine("oktyabr");
//        break;
//    case 11:
//        Console.WriteLine("noyabr");
//        break;
//    case 12:
//        Console.WriteLine("dekabr");
//        break;

//}
//int a = 1;
//    while(a<11)
//{
//    Console.WriteLine(a);
//    a++;
//}

//int a = 1;
//do
//{
//    Console.WriteLine(a);
//    a++;
//}
//while (a < 10);