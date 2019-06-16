''' <summary>
''' Template Methodパターン
''' </summary>
''' <remarks></remarks>
Module modMain

	<STAThread> _
	Public Sub Main()
		Dim charDsp As New clsCharDisplay("H"c)
		Dim strDsp As New clsStringDisplay("Hello world.")
		Dim strDspJp As New clsStringDisplay("こんにちは。")

		charDsp.Display()
		strDsp.Display()
		strDspJp.Display()

		Return
	End Sub

End Module
