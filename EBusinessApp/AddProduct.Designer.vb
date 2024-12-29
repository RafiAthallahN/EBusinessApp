Partial Class AddProductForm
    Inherits Form

    Private components As System.ComponentModel.IContainer = Nothing
    Private txtName As TextBox
    Private cmbCategory As ComboBox
    Private numPrice As NumericUpDown
    Private numStock As NumericUpDown
    Private WithEvents btnSubmit As Button
    Private lblName As Label
    Private lblCategory As Label
    Private lblPrice As Label
    Private lblStock As Label

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.txtName = New TextBox()
        Me.cmbCategory = New ComboBox()
        Me.numPrice = New NumericUpDown()
        Me.numStock = New NumericUpDown()
        Me.btnSubmit = New Button()
        Me.lblName = New Label()
        Me.lblCategory = New Label()
        Me.lblPrice = New Label()
        Me.lblStock = New Label()
        Me.SuspendLayout()

        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()

        ' 
        ' txtName
        ' 
        Me.txtName.Location = New Point(120, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(200, 20)
        Me.txtName.TabIndex = 0

        ' 
        ' cmbCategory
        ' 
        Me.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New Point(120, 60)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New Size(200, 21)
        Me.cmbCategory.TabIndex = 1

        ' 
        ' numPrice
        ' 
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Location = New Point(120, 100)
        Me.numPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New Size(200, 20)
        Me.numPrice.TabIndex = 2

        ' 
        ' numStock
        ' 
        Me.numStock.Location = New Point(120, 140)
        Me.numStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New Size(200, 20)
        Me.numStock.TabIndex = 3

        ' 
        ' btnSubmit
        ' 
        Me.btnSubmit.Location = New Point(120, 180)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New Size(200, 30)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True

        ' 
        ' lblName
        ' 
        Me.lblName.AutoSize = True
        Me.lblName.Location = New Point(20, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New Size(38, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"

        ' 
        ' lblCategory
        ' 
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New Point(20, 63)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New Size(52, 13)
        Me.lblCategory.TabIndex = 6
        Me.lblCategory.Text = "Category:"

        ' 
        ' lblPrice
        ' 
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New Point(20, 103)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New Size(34, 13)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"

        ' 
        ' lblStock
        ' 
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New Point(20, 143)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New Size(38, 13)
        Me.lblStock.TabIndex = 8
        Me.lblStock.Text = "Stock:"

        ' 
        ' AddProductForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(350, 230)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.numStock)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblStock)
        Me.Name = "AddProductForm"
        Me.Text = "Add Product"

        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
