'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 07/11/2021
' Time: 14:18
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim inputnum As Int16 = 0
		Dim fivenum As Double = 0
		Dim multiplynum As Int16 = 1
		Dim outputnum As Int16 = 0
		
		Console.WriteLine("Please enter a number . . . ")
		inputnum = Val(Console.ReadLine())
		
		fivenum = inputnum / 5
		Console.WriteLine(fivenum)
		Math.Floor(fivenum)
		Console.WriteLine(fivenum)
		
		For c=1 To fivenum
			outputnum = multiplynum * 5
			Console.WriteLine(outputnum)
			multiplynum += 1
		Next
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
