''' <summary>
''' 本を表すクラス
''' </summary>
''' <remarks></remarks>
Public Class clsBook

	Private _name As String = String.Empty
	''' <summary>
	''' 名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Name() As String
		Get
			Return _name
		End Get
		Set(ByVal value As String)
			_name = value
		End Set
	End Property


End Class
