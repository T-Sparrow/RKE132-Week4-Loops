Random rnd = new Random();

//int myRandomNum = rnd.Next(0, 11); //ehk 0-10
//Console.WriteLine($"My random number is: {myRandomNum}");

int myRandomNum;

//for(int i = 0; i < 3; i++)
//{
//    myRandomNum = rnd.Next(0, 11);
//    Console.WriteLine($"My random number is: {myRandomNum}");
//}

int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"random sum total: {randomSum}");