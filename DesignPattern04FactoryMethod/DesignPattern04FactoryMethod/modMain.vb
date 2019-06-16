''' <summary>
''' メインモジュール
''' </summary>
''' <remarks></remarks>
Module modMain

	''' <summary>
	''' エントリーポイント
	''' </summary>
	''' <remarks></remarks>
	<STAThread> _
	Public Sub Main()

		Dim cFactory As clsIDCardFactory = Nothing

		cFactory = New clsIDCardFactory

		Dim card1 As clsProduct = cFactory.create("はじめさん")
		Dim card2 As clsProduct = cFactory.create("いちのしたさん")
		Dim card3 As clsProduct = cFactory.create("にのつぎさん")

		card1.use()
		card2.use()
		card3.use()

		Return
	End Sub


End Module
