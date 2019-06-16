''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class clsCharDisplay
	Inherits clsDisplay

	Private _ch As Char
	Public Sub New(ByVal ch As Char)
		Me._ch = ch
	End Sub

	Public Overrides Sub Close()
		System.Console.WriteLine(">>")
	End Sub

	Public Overrides Sub Open()
		System.Console.Write("<<")
	End Sub

	Public Overrides Sub Print()
		System.Console.Write(Me._ch)
	End Sub

End Class
