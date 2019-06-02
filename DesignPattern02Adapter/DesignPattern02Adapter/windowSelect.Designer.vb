<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowSelect
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.rbtnInherits = New System.Windows.Forms.RadioButton()
		Me.rbtnTransfer = New System.Windows.Forms.RadioButton()
		Me.btnDecide = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'rbtnInherits
		'
		Me.rbtnInherits.AutoSize = True
		Me.rbtnInherits.Location = New System.Drawing.Point(12, 12)
		Me.rbtnInherits.Name = "rbtnInherits"
		Me.rbtnInherits.Size = New System.Drawing.Size(53, 24)
		Me.rbtnInherits.TabIndex = 0
		Me.rbtnInherits.TabStop = True
		Me.rbtnInherits.Text = "継承"
		Me.rbtnInherits.UseVisualStyleBackColor = True
		'
		'rbtnTransfer
		'
		Me.rbtnTransfer.AutoSize = True
		Me.rbtnTransfer.Location = New System.Drawing.Point(93, 12)
		Me.rbtnTransfer.Name = "rbtnTransfer"
		Me.rbtnTransfer.Size = New System.Drawing.Size(53, 24)
		Me.rbtnTransfer.TabIndex = 1
		Me.rbtnTransfer.TabStop = True
		Me.rbtnTransfer.Text = "委譲"
		Me.rbtnTransfer.UseVisualStyleBackColor = True
		'
		'btnDecide
		'
		Me.btnDecide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnDecide.Location = New System.Drawing.Point(12, 52)
		Me.btnDecide.Name = "btnDecide"
		Me.btnDecide.Size = New System.Drawing.Size(157, 23)
		Me.btnDecide.TabIndex = 2
		Me.btnDecide.Text = "決定(&O)"
		Me.btnDecide.UseVisualStyleBackColor = True
		'
		'windowSelect
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(181, 87)
		Me.Controls.Add(Me.btnDecide)
		Me.Controls.Add(Me.rbtnTransfer)
		Me.Controls.Add(Me.rbtnInherits)
		Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "windowSelect"
		Me.ShowIcon = False
		Me.Text = "選択画面"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents rbtnInherits As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnTransfer As System.Windows.Forms.RadioButton
	Friend WithEvents btnDecide As System.Windows.Forms.Button

End Class
