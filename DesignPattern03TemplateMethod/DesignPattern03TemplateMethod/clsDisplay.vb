''' <summary>
''' 抽象Displayクラス
''' </summary>
''' <remarks></remarks>
Public MustInherit Class clsDisplay
	
	MustOverride Sub Open()
	MustOverride Sub Print()
	MustOverride Sub Close()

	Shadows Sub Display()
		Open()

		For i As Integer = 0 To 5
			Print()
		Next

		Close()
	End Sub

End Class
