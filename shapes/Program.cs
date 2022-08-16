#region top to bottom line
//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine("*");
//}
//Console.Read();
#endregion

#region inverted half triangle
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 10; j > i; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//Console.Read();
#endregion

#region half triangle
//for (int i = 1; i < 10; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//Console.Read();
#endregion

#region Creating a square
//Console.Write("Please enter the side length of the square: ");
//int star = Convert.ToInt16(Console.ReadLine());
//for (int a = 1; a <= star; a++)
//{

//    for (int b = 1; b <= star; b++)
//    {
//        if (a == 1 || a == star)
//        {
//            Console.Write("* ");
//        }
//        else if (b == 1 || b == star)
//        {
//            Console.Write("* ");
//        }

//        else
//        {

//            Console.Write("  ");

//        }
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();
#endregion

#region Creating a triangle
//Console.Write("Please enter the side length of the triangle: ");
//int star = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine();

//for (int i = 1; i <= star; i++)
//{
//    for (int x = star; x > i; x--)
//    {
//        Console.Write(" ");
//    }
//    for (int y = 1; y <= i; y++)
//    {
//        Console.Write("*" + " ");
//    }
//    Console.WriteLine();
//}
//Console.Read();
#endregion

#region create an inverted and straight triangle
Console.Write("Please enter the side length of the triangle: ");
int star;
star = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
for (int i = 1; i <= star; i++)
{
    for (int j = star; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}
for (int i = 1; i <= star; i++)
{
    for (int l = 1; l <= i; l++)
    {
        Console.Write(" ");
    }
    for (int j = star; j > i; j--)
    {
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();
#endregion