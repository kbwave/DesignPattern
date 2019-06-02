''' <summary>
''' メインモジュール
''' </summary>
''' <remarks></remarks>
Module modMain

	Private _selectedMethod As Integer

	Public Enum Method As Integer
		None = -1
		InheritsMethod
		TransferMethod

	End Enum

	<STAThread> _
	Public Sub Main()

		Using winSelected As New windowSelect
			winSelected.ShowDialog()

			_selectedMethod = winSelected.SelectedMethod
		End Using

		Select Case _selectedMethod
			Case Method.InheritsMethod
				UseInherits()
			Case Method.TransferMethod
				UseTransfer()
		End Select
	End Sub

	''' <summary>
	''' 継承を使ってアダプター
	''' </summary>
	''' <remarks></remarks>
	Private Sub UseInherits()
		Dim prtBanner As New clsPrintBanner("Adapter Message(Inherits)")

		prtBanner.PrintWeek()
		prtBanner.PrintStrong()
	End Sub

	''' <summary>
	''' 委譲を使ってアダプター
	''' </summary>
	''' <remarks></remarks>
	Private Sub UseTransfer()
		Dim PrtChild As clsPrintChild = Nothing

		PrtChild = New clsPrintChild("Adapter Message(Transfer)")

		PrtChild.PrintWeek()
		PrtChild.PrintStrong()
	End Sub

End Module
