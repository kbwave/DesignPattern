Public Class clsStringDisplay
	Inherits clsDisplay

	Private _str As String = String.Empty
	Private _width As Integer = 0


	Public Sub New(ByVal str As String)
		Me._str = str
		Me._width = str.Length
	End Sub

	Public Overrides Sub Close()
		Me.PrintLine()
	End Sub

	Public Overrides Sub Open()
		Me.PrintLine()
	End Sub

	Public Overrides Sub Print()
		System.Console.WriteLine("|" & Me._str & "|")
	End Sub

	Private Sub PrintLine()
		System.Console.Write("+")
		For i As Integer = 0 To Me._width
			System.Console.Write("-")
		Next
		System.Console.WriteLine("+")
	End Sub
End Class
