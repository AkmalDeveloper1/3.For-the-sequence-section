using System.Runtime.CompilerServices;
// 1.Prime numbers - Tub sonlar
Console.Write("Enter the number: ");
ulong number1 = Convert.ToUInt64(Console.ReadLine());
uint checkNumber1 = (uint)Math.Sqrt(number1);
bool result1=false;
for (uint count = 2; count <= checkNumber1; count++)
{
    result1 = number1 % count == 0 ? false : true;
    if(result1==false) break;
}
if(result1==false) Console.WriteLine("Tub emas");
else Console.WriteLine("Tub son");

//2. Numbers without divisors-Bo'luvchisiz sonlar:
Console.Write("Enter the number: ");
uint number2 = Convert.ToUInt32(Console.ReadLine());
string divisors = "Divisors: ";
uint count2 = 2;
while (count2 <= 10)
{
    if (number2 % count2 == 0)
        divisors += Convert.ToString(count2) + ", ";
    count2++;
}
Console.WriteLine(divisors);

// 3. Calculating the Power of a Number - Daraja hisoblash:
Console.Write("Enter the number: ");
decimal number3 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter the degree of number: ");
uint degree3 = Convert.ToUInt32(Console.ReadLine());
decimal result3=1;
while(degree3>0)
{
 result3*=number3;
 degree3--;
}
Console.WriteLine("Result: "+result3);

//4.Calculating the expense set-Harajatlar to'plamini hisoblash:
Console.Write("Sonnlarni \",\" belgisi bilan kiriting. \nMasalan \"1,2,3,4\": ");
string toplam4 = Console.ReadLine();
string[] sonlar4 = toplam4.Split(',');
decimal sum4=0;
for(int i4 =0;i4<sonlar4.Length;i4++)
{
  sum4 += Convert.ToDecimal(sonlar4[i4]);
}
Console.WriteLine("Sonlar yig'indisi: "+sum4);

//5. Armstrong sonlar - Armstrong numbers
Console.Write("Enter the number: ");
ulong armNum5 = Convert.ToUInt64(Console.ReadLine());
ulong sum5=0;
ulong i5 = armNum5;
while(i5>10)
{ 
    sum5+=(ulong)Math.Pow(i5%10,3);
    i5/=10; 
    if(i5<10)
    {
        sum5+=(ulong)Math.Pow(i5,3);
        break;
    }
}
if(i5==10) Console.WriteLine($"{armNum5} is Armstrong number");
else Console.WriteLine(sum5==armNum5?$"{armNum5} is Armstrong number":$"{armNum5} isn't Armstrong number");

//6.Qualitative factors - Sifatli bo'luvchilar
Console.Write("Enter the number: ");
ulong number6 = Convert.ToUInt64(Console.ReadLine());
int counter6 = 0;
for (ulong i6 = 1; i6 < number6 / 2; i6++)//1,2,3
    if (number6 % i6 == 0)
    {
        counter6 = number6 % (i6 + 1) == 0 ? counter6 + 2 : counter6;
        if(i6!=1 && number6 % (i6 + 1) == 0)counter6 = number6 % (i6 - 1) == 0 ? counter6 - 1 : counter6;
    }
Console.WriteLine("Qualitative factors: " + counter6);