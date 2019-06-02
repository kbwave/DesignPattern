''' <summary>
''' Printクラスを継承したクラス
''' </summary>
''' <remarks></remarks>
Public Class clsPrintChild
	Inherits clsPrint

	Private _banner As clsBanner = Nothing

	Public Sub New(ByVal text As String)
		Me._banner = New clsBanner(text)
	End Sub

	Public Overrides Sub PrintWeek()
		Me._banner.ShowWithParen()
	End Sub

	Public Overrides Sub PrintStrong()
		Me._banner.ShowWithAster()
	End Sub

End Class
