Imports System.Windows.Forms

Public Class AddProductForm
    Public Property NewProduct As Product

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and add txtName
        If txtName Is Nothing Then
            txtName = New TextBox() With {
                .Location = New Point(10, 10),
                .Width = 200
            }
            Me.Controls.Add(txtName)
        End If

        ' Initialize and add cmbCategory
        If cmbCategory Is Nothing Then
            cmbCategory = New ComboBox() With {
                .Location = New Point(10, 40),
                .Width = 200
            }
            Me.Controls.Add(cmbCategory)
        End If
        cmbCategory.DataSource = [Enum].GetValues(GetType(ProductCategory))

        ' Initialize and add numPrice
        If numPrice Is Nothing Then
            numPrice = New NumericUpDown() With {
                .Location = New Point(10, 70),
                .Width = 200,
                .Minimum = 0,
                .Maximum = Decimal.MaxValue,
                .DecimalPlaces = 2
            }
            Me.Controls.Add(numPrice)
        End If

        ' Initialize and add numStock
        If numStock Is Nothing Then
            numStock = New NumericUpDown() With {
                .Location = New Point(10, 100),
                .Width = 200,
                .Minimum = 0,
                .Maximum = Decimal.MaxValue
            }
            Me.Controls.Add(numStock)
        End If

        ' Initialize and add btnSubmit
        If btnSubmit Is Nothing Then
            btnSubmit = New Button() With {
                .Text = "Submit",
                .Location = New Point(10, 130),
                .Width = 200
            }
            Me.Controls.Add(btnSubmit)
        End If
        btnSubmit.Visible = True
        AddHandler btnSubmit.Click, AddressOf BtnSubmit_Click
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse numPrice.Value <= 0 OrElse numStock.Value < 0 Then
            MessageBox.Show("Please enter valid product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        NewProduct = New Product With {
            .Name = txtName.Text,
            .Category = CType(cmbCategory.SelectedItem, ProductCategory),
            .Price = CDbl(numPrice.Value),
            .Stock = CInt(numStock.Value)
        }

        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class
