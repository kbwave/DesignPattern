Public MustInherit Class clsFactory

	Shadows Function create(ByVal owner As String) As clsProduct
		Dim cProduct As clsProduct = Nothing
		cProduct = Me.CreateProduct(owner)
		Me.RegisterProduct(cProduct)

		Return cProduct
	End Function

	Protected MustOverride Function CreateProduct(ByVal owner As String) As clsProduct

	Protected MustOverride Sub RegisterProduct(ByVal cProduct As clsProduct)

End Class
