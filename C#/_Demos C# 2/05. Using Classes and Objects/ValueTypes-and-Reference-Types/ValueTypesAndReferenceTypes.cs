using System;

class ValueTypesAndReferenceTypes
{
	static unsafe void Main()
	{
		int intNum = 5;
		DateTime dateTime = DateTime.Now;
		int[] intArr = new int[] { 5, 6, 7 };
		string str = "telerik";

		Console.WriteLine("address(intNum) = 0x{0:x8} (in the stack)",
			(uint)&intNum);
		Console.Write("bytes(intNum)  = ");
		DumpBytes((byte*)&intNum, sizeof(int));
		Console.WriteLine();

		Console.WriteLine("address(dateTime) = 0x{0:x8} (in the stack)", 
			(uint)&dateTime);
		Console.Write("bytes(dateTime)  = ");
		DumpBytes((byte*)&dateTime, sizeof(DateTime));
		Console.WriteLine();

		fixed (int* pIntArrData = intArr)
		{
			// Arrays take 4 bytes (type_id) + 4 bytes (length) + sizeof(type) * length
			byte* pIntArr = (byte*)pIntArrData - 8;
			Console.WriteLine("address(intArr) = 0x{0:x8} (int the heap)", 
				(uint)pIntArr);
			Console.Write("bytes(intArr) = ");
			DumpBytes(pIntArr, 8 + intArr.Length * sizeof(int));
			Console.WriteLine();
		}

		fixed (char* pStrData = str)
		{
			// Strings take 4 bytes (type_id) + 4 bytes (length) + sizeof(char) * length
			byte* pStr = (byte*)pStrData - 8;
			Console.WriteLine("address(str) = 0x{0:x8} (in the heap)",
				(uint)pStr);
			Console.Write("bytes(str) = ");
			DumpBytes(pStr, 8 + str.Length * sizeof(char));
			Console.WriteLine();
		}
	}

	private static unsafe void DumpBytes(byte* bytes, int count)
	{
		for (int i = 0; i < count; i++)
		{
			Console.Write("{0:x2} ", bytes[i]);
		}
		Console.WriteLine();
	}
}
