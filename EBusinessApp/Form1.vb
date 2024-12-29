' MainForm.vb
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class MainForm

    Private products As New List(Of Product)()
    Public Sub New()
        InitializeComponent()
        lstProducts = New ListBox() With {
            .Location = New Point(12, 40),
            .Size = New Size(360, 200)
        }
        Me.Controls.Add(lstProducts)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateProductList()
    End Sub

    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim addForm As New AddProductForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            products.Add(addForm.NewProduct)
            UpdateProductList()
        End If
    End Sub

    Private Sub BtnCalculateStockValue_Click(sender As Object, e As EventArgs) Handles btnCalculateStockValue.Click
        Dim totalValue As Double = 0
        For Each product In products
            totalValue += product.Price * product.Stock
        Next
        MessageBox.Show($"Total Inventory Value: {totalValue:C}", "Stock Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateProductList()
        If lstProducts Is Nothing Then
            lstProducts = New ListBox() With {
                .Location = New Point(10, 10),
                .Size = New Size(300, 200)
            }
            Me.Controls.Add(lstProducts)
        End If

        lstProducts.Items.Clear()
        For Each product In products
            lstProducts.Items.Add(product.ToString())
        Next
    End Sub
End Class

' Product Category Enum
Public Enum ProductCategory
    Electronics
    Clothing
    HomeAppliance
    Beauty
    Food
End Enum

' Product Class
Public Class Product
    Public Property Name As String
    Public Property Category As ProductCategory
    Public Property Price As Double
    Public Property Stock As Integer

    Public Overrides Function ToString() As String
        Return $"{Name} ({Category}) - ${Price:F2} x {Stock}"
    End Function
End Class
