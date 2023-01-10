// вид 4
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "текст");
// Console.WriteLine(res);

// Использование цикла for

string Method4(int count, string c)
{
    
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "текст");
Console.WriteLine(res);

