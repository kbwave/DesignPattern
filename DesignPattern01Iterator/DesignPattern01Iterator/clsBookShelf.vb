''' <summary>
''' 本棚を表すクラス
''' </summary>
''' <remarks></remarks>
Public Class clsBookShelf
	Implements IAggregate

	''' <summary>
	''' 本
	''' </summary>
	''' <remarks></remarks>
	Private _books() As clsBook = Nothing

	''' <summary>
	''' 最後の本
	''' </summary>
	''' <remarks></remarks>
	Private _last As Integer = 0



	''' <summary>
	''' 指定した要素に該当する本を取得
	''' </summary>
	''' <param name="index"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetBookAt(ByVal index As Integer) As clsBook
		If index <= Me._last Then
			Return Me._books(index)
		Else
			Return Nothing
		End If
	End Function


	Public Function Iterator() As IIterator Implements IAggregate.Iterator

	End Function


	''' <summary>
	''' インスタンス時
	''' </summary>
	''' <param name="MaxSize"></param>
	''' <remarks></remarks>
	Public Sub New(ByVal MaxSize As Integer)
		ReDim Me._books(MaxSize - 1)
		Me._last = MaxSize - 1
	End Sub
End Class
