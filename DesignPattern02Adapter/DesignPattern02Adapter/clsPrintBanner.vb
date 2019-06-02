Imports System.Runtime.CompilerServices

''' <summary>
''' clsPrintのアダプタ
''' </summary>
''' <remarks></remarks>
Public Class clsPrintBanner
	Inherits clsBanner
	Implements IPrint


	Public Sub PrintWeek() Implements IPrint.PrintWeek
		ShowWithParen()
	End Sub

	Public Sub PrintStrong() Implements IPrint.PrintStrong
		ShowWithAster()
	End Sub

	Public Sub New(ByVal text As String)
		MyBase.New(text)
	End Sub
End Class
