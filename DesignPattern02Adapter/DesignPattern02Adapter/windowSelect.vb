Public Class windowSelect

	Private _selectedMethod As Integer
	Public ReadOnly Property SelectedMethod() As Integer
		Get
			Return _selectedMethod
		End Get
	End Property



	Private Sub btnDecide_Click(sender As Object, e As EventArgs) Handles btnDecide.Click
		If Me.rbtnInherits.Checked Then
			Me._selectedMethod = modMain.Method.InheritsMethod
		ElseIf Me.rbtnTransfer.Checked Then
			Me._selectedMethod = modMain.Method.TransferMethod
		End If

		DialogResult = Windows.Forms.DialogResult.OK
	End Sub

	Public Sub New()

		' この呼び出しはデザイナーで必要です。
		InitializeComponent()

		' InitializeComponent() 呼び出しの後で初期化を追加します。
		Me._selectedMethod = modMain.Method.None

	End Sub
End Class
