Public Class clsIDCardFactory
	Inherits clsFactory

	Private _owners As List(Of String) = Nothing

	Public Sub New()
		Me._owners = New List(Of String)
	End Sub

	Protected Overrides Function CreateProduct(owner As String) As clsProduct
		Return New clsIDCard(owner)
	End Function

	Protected Overrides Sub RegisterProduct(cProduct As clsProduct)
		Me._owners.Add(DirectCast(cProduct, clsIDCard).GetOwner)
	End Sub

	Public ReadOnly Property Owners()
		Get
			Return Me._owners
		End Get
	End Property

End Class
