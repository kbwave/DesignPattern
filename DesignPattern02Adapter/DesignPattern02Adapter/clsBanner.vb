''' <summary>
''' 広告クラス(継承・委譲と共通)
''' </summary>
''' <remarks></remarks>
Public Class clsBanner

	Private _banner As String = String.Empty

	Public Sub New(ByVal text As String)
		Me._banner = text
	End Sub

	Public Sub ShowWithParen()
		Debug.Print("(" & Me._banner & ")")
	End Sub

	Public Sub ShowWithAster()
		Debug.Print("*" & Me._banner & "*")
	End Sub

End Class
