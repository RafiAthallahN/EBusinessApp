Partial Class MainForm
    Inherits Form

    Private components As System.ComponentModel.IContainer = Nothing
    Private lstProducts As ListBox
    Private WithEvents btnAddProduct As Button
    Private WithEvents btnCalculateStockValue As Button
    Private menuStrip As MenuStrip
    Private fileToolStripMenuItem As ToolStripMenuItem
    Private exitToolStripMenuItem As ToolStripMenuItem

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.lstProducts = New ListBox()
        Me.btnAddProduct = New Button()
        Me.btnCalculateStockValue = New Button()
        Me.menuStrip = New MenuStrip()
        Me.fileToolStripMenuItem = New ToolStripMenuItem()
        Me.exitToolStripMenuItem = New ToolStripMenuItem()

        ' 
        ' lstProducts
        ' 
        'Me.lstProducts.FormattingEnabled = True
        'Me.lstProducts.Location = New Point(12, 40)
        'Me.lstProducts.Name = "lstProducts"
        'Me.lstProducts.Size = New Size(360, 200)
        'Me.lstProducts.TabIndex = 0

        ' 
        ' btnAddProduct
        ' 
        Me.btnAddProduct.Location = New Point(12, 260)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New Size(120, 30)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True

        ' 
        ' btnCalculateStockValue
        ' 
        Me.btnCalculateStockValue.Location = New Point(152, 260)
        Me.btnCalculateStockValue.Name = "btnCalculateStockValue"
        Me.btnCalculateStockValue.Size = New Size(220, 30)
        Me.btnCalculateStockValue.TabIndex = 2
        Me.btnCalculateStockValue.Text = "Calculate Stock Value"
        Me.btnCalculateStockValue.UseVisualStyleBackColor = True

        ' 
        ' menuStrip
        ' 
        Me.menuStrip.Items.AddRange(New ToolStripItem() {Me.fileToolStripMenuItem})
        Me.menuStrip.Location = New Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New Size(400, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "menuStrip"

        ' 
        ' fileToolStripMenuItem
        ' 
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"

        ' 
        ' exitToolStripMenuItem
        ' 
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New Size(93, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItem_Click

        ' 
        ' MainForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(400, 310)
        'Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnCalculateStockValue)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "MainForm"
        Me.Text = "Product Management"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
