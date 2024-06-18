Module Module1

	Sub Main()

		Dim counter = 2
		Dim outputStirng
		Dim currentChar = "-"c
		Do
			counter = counter + 1
			If counter > 30 Then
				counter = 2
			End If
			If Console.KeyAvailable Then
				currentChar = Console.ReadKey.KeyChar
			End If
			outputStirng = New String(currentChar, counter)
			Console.WriteLine(outputStirng)
			Threading.Thread.Sleep(120)
		Loop While currentChar <> " "

		' example code available in git branches

	End Sub

End Module
