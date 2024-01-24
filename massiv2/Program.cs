// int a = 5;
// int b = 7;
// if (a > b)
// {
//     Console.Write(a);
// }
// else
// {
//     Console.Write(b);
// }

// int a = 4;
// int b = 6;
// int c = 7;
// int d = 4;
// int e = 9;
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (e > max)
// {
//     max = e;
// }
// Console.Write(max);

// int n = 9;
// int i = 1;
// while (i <= n){
//     Console.Write(i);
//     Console.Write(' ');
//     i = i + 1;
// }

// int num = 6;
// int num2 = num * (-1);
// while (num2 <= num)
// {
//     Console.Write($"{num2} ");
//     num2++;
// }

int num = 92;
if (num >= 100 && num <= 999)
{
    int num1 = num / 100;
    int num2 = num % 10;
    int sum = num1 + num2;
    Console.Write($"Sum of first and last digit in numd {num} is {sum}");
}
else{
   Console.Write($"your numbs is not 3 digit");
}
