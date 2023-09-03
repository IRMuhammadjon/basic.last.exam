Console.WriteLine("1-masala :");
int x=1, sum=0;
while (x < 1000)
{
    if (x % 2 != 0)
     sum += x; 

    x++;
}
Console.WriteLine($"1 dan 1000 gacha toq sonlar yig'indisi : {sum} ga teng!\n");
Console.WriteLine("2-masala\n");
int[] arry = { 1, 16, 25, 36, 44, 5 };
int min = int.MaxValue;
int max = int.MinValue;
for (int i = 0; i < arry.Length; i++)
{
    if (arry[i] < min)
    {
        min = arry[i];
    }
    if (arry[i] > max)
    {
        max = arry[i];
    }
}
Console.WriteLine($"Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasi : {max * min} ga teng ");

Console.WriteLine("\n 3-masala : \n");
Console.WriteLine("int tepidagi butun sonni kiriting : ");
int asli;
int a =Convert.ToInt32(Console.ReadLine());
asli = a;
int fact = 1; 
bool check = false;
if (a < 0)
{
    a = a * (-1);
    check= true;
}
// factarial 0 bolganda shart kiritishni hojati yo'q 
for (int i = 1; i <= a; i++)
{
    fact *= i;
}
if (a%2 != 0 && check)
{
    fact = fact * (-1);
}
Console.WriteLine($"{asli}! = {fact} ");