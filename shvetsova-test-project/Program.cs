class InputProcessor
{
	public static void Main()
	{
		Console.Write("Введите значения через пробел:");

		string ConsoleValue = Console.ReadLine();

		string[] InputValues = ConsoleValue.Split(" ");
		string[] OutputValues = InputProcessor.ProcessArray(InputValues);

		for (var i = 0; i < OutputValues.GetLength(0); i++)
		{
			Console.WriteLine(OutputValues[i]);
		}
	}

	private static string[] ProcessArray(string[] arr)
	{
		var resultArray = new string[arr.Length];
		var resultArrayLength = 0;

		for (var i = 0; i < arr.GetLength(0); i++)
		{
			var CurrentValue = arr[i];

			if (CurrentValue.Length <= 3)
			{
				resultArray[resultArrayLength] = CurrentValue;
				++resultArrayLength;
			}
		}

		Array.Resize(ref resultArray, resultArrayLength);

		return resultArray;
	}
}
