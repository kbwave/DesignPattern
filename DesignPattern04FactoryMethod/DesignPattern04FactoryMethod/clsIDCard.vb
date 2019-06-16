Public Class clsIDCard
	Inherits clsProduct

	Private _owner As String = String.Empty

	Public Sub New(ByVal owner As String)
		Me._owner = owner
		System.Console.WriteLine(Me._owner & "のカードを作ります。")
	End Sub

	Public Overrides Sub use()
		System.Console.WriteLine(Me._owner & "のカードを使います。")
	End Sub

	Public Function GetOwner() As String
		Return Me._owner
	End Function

End Class
