// UseArrays();
ChooseMethod();

void ChooseMethod()
{
  Console.WriteLine("Выберите метод создания массивов:\n1 - использовать предсозданные массивы\n2 - создать свой массив");
  string userAnswer = Console.ReadLine();

  if (userAnswer == "1")
  {
    UseArrays();
  }
  else if (userAnswer == "2")
  {
    string[] userArray = CreateArray();
    ShowResult(userArray, FindElements(userArray));
  }
  else
  {
    Console.WriteLine("Некорректный ввод");
  }
}

string[] CreateArray()
{
  Console.WriteLine("\nСоздание собственного массива");
  Console.Write("Введите элементы массива (через пробел/запятую/точку): ");

  char[] delimiterChars = { ' ', ',', '.', '\t' };

  try
  {
    return Console.ReadLine().Split(delimiterChars);
  }
  catch
  {
    Console.WriteLine("Некорректный ввод");
    return null;
  }
}

void UseArrays()
{
  Console.WriteLine("\nИспользование педзаданных массивов");

  string[] exampleArray1 = { "hello", "2", "world", ":-)" };
  string[] exampleArray2 = { "1234", "1567", "-2", "computer science" };
  string[] exampleArray3 = { "Russia", "Denmark", "Kazan" };

  ShowResult(exampleArray1, FindElements(exampleArray1));
  Console.WriteLine();
  ShowResult(exampleArray2, FindElements(exampleArray2));
  Console.WriteLine();
  ShowResult(exampleArray3, FindElements(exampleArray3));
}

string[] FindElements(string[] array)
{

  string[] result = new string[array.Length];
  int j = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      result[j] = array[i];
      j++;
    }
  }

  Array.Resize(ref result, j);

  return result;
}

void ShowResult(string[] array, string[] result)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1)
    {
      Console.Write("'" + array[i] + "'");
    }
    else Console.Write("'" + array[i] + "', ");
  }
  Console.Write("]");

  Console.Write(" -> ");

  Console.Write("[");
  for (int i = 0; i < result.Length; i++)
  {
    if (i == result.Length - 1)
    {
      Console.Write("'" + result[i] + "'");
    }
    else Console.Write("'" + result[i] + "', ");
  }
  Console.Write("]");
}