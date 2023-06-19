// Решение с заранее заданным массивом:

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}
int ArrayLengthCount(string[] arr , int limit)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= limit && arr[i].Length != 0) count++;
    }
    return count;
}
string[] ResultArray(string[] arr, int count, int limit)
{
    string[] resArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= limit && arr[i].Length != 0)
        {
            resArr[j] = arr[i];
            j++;
        }
    }
    return resArr;
}

string valOne = "One";
string valTwo = "Two";
string valThree = "Three";
int characterLimit = 3;
string[] initialArray = { valOne, valTwo, valThree };
Console.Write("[");
PrintArray(initialArray);
Console.Write("] -> [");
int newArrLength = ArrayLengthCount(initialArray, characterLimit);
string[] resultArray = ResultArray(initialArray, newArrLength, characterLimit);
PrintArray(resultArray);
Console.Write("]");
