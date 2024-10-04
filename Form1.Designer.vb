<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtDateOfPurchase = New TextBox()
        txtCustomerName = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtAddress = New TextBox()
        Label5 = New Label()
        itemsList = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        txtPricePerItem = New TextBox()
        BtnAddItem = New Button()
        lblSubtotal = New Label()
        lblTax = New Label()
        Label11 = New Label()
        lblTotalAmount = New Label()
        txtDiscount = New TextBox()
        btnCalculateSubtotal = New Button()
        txtSubtotal = New TextBox()
        txtTotalAmount = New TextBox()
        btnCalculateTotalAmount = New Button()
        txtTax = New TextBox()
        btnGenerateReceipt = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        cmbPaymentMethod = New ComboBox()
        cmbServedBy = New ComboBox()
        txtTransactionID = New TextBox()
        Label13 = New Label()
        GenerateUniqueReceiptNumber = New TextBox()
        CType(itemsList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(419, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(788, 61)
        Label1.TabIndex = 0
        Label1.Text = "China Town Store Receipt System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 32)
        Label2.TabIndex = 1
        Label2.Text = "Date of Purchase"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 32)
        Label3.TabIndex = 2
        Label3.Text = "Customer Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(79, 326)
        Label4.Name = "Label4"
        Label4.Size = New Size(290, 32)
        Label4.TabIndex = 3
        Label4.Text = "Store Contact Information"
        ' 
        ' txtDateOfPurchase
        ' 
        txtDateOfPurchase.Location = New Point(389, 177)
        txtDateOfPurchase.Name = "txtDateOfPurchase"
        txtDateOfPurchase.Size = New Size(346, 39)
        txtDateOfPurchase.TabIndex = 4
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(389, 245)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(604, 39)
        txtCustomerName.TabIndex = 5
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(389, 323)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(394, 39)
        txtPhoneNumber.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(818, 323)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(367, 39)
        txtEmail.TabIndex = 7
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(1242, 323)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(379, 39)
        txtAddress.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 737)
        Label5.Name = "Label5"
        Label5.Size = New Size(259, 32)
        Label5.TabIndex = 9
        Label5.Text = "List of items Purchased"
        ' 
        ' itemsList
        ' 
        itemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        itemsList.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        itemsList.Location = New Point(389, 622)
        itemsList.Name = "itemsList"
        itemsList.RowHeadersWidth = 82
        itemsList.Size = New Size(681, 303)
        itemsList.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Item Name"
        Column1.MinimumWidth = 10
        Column1.Name = "Column1"
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Quantity"
        Column2.MinimumWidth = 10
        Column2.Name = "Column2"
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Price per Item"
        Column3.MinimumWidth = 10
        Column3.Name = "Column3"
        Column3.Width = 200
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(79, 414)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 32)
        Label6.TabIndex = 11
        Label6.Text = "Item Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(79, 485)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 32)
        Label7.TabIndex = 12
        Label7.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(79, 571)
        Label8.Name = "Label8"
        Label8.Size = New Size(162, 32)
        Label8.TabIndex = 13
        Label8.Text = "Price per Item"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(389, 414)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(394, 39)
        txtItemName.TabIndex = 14
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(389, 485)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(394, 39)
        txtQuantity.TabIndex = 15
        ' 
        ' txtPricePerItem
        ' 
        txtPricePerItem.Location = New Point(389, 568)
        txtPricePerItem.Name = "txtPricePerItem"
        txtPricePerItem.Size = New Size(394, 39)
        txtPricePerItem.TabIndex = 16
        ' 
        ' BtnAddItem
        ' 
        BtnAddItem.Font = New Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddItem.Location = New Point(582, 931)
        BtnAddItem.Name = "BtnAddItem"
        BtnAddItem.Size = New Size(233, 65)
        BtnAddItem.TabIndex = 17
        BtnAddItem.Text = "Add Item"
        BtnAddItem.UseVisualStyleBackColor = True
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(79, 1047)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(113, 32)
        lblSubtotal.TabIndex = 18
        lblSubtotal.Text = "Sub Total"
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(79, 1138)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(47, 32)
        lblTax.TabIndex = 19
        lblTax.Text = "Tax"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(79, 1202)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 32)
        Label11.TabIndex = 20
        Label11.Text = "Discount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(79, 1288)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(158, 32)
        lblTotalAmount.TabIndex = 21
        lblTotalAmount.Text = "Total Amount"
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(389, 1211)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(435, 39)
        txtDiscount.TabIndex = 22
        ' 
        ' btnCalculateSubtotal
        ' 
        btnCalculateSubtotal.Font = New Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculateSubtotal.Location = New Point(1021, 1047)
        btnCalculateSubtotal.Name = "btnCalculateSubtotal"
        btnCalculateSubtotal.Size = New Size(355, 68)
        btnCalculateSubtotal.TabIndex = 23
        btnCalculateSubtotal.Text = "Calculate Subtotal"
        btnCalculateSubtotal.UseVisualStyleBackColor = True
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(389, 1047)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(435, 39)
        txtSubtotal.TabIndex = 24
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(389, 1288)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(435, 39)
        txtTotalAmount.TabIndex = 25
        ' 
        ' btnCalculateTotalAmount
        ' 
        btnCalculateTotalAmount.Font = New Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculateTotalAmount.Location = New Point(1021, 1152)
        btnCalculateTotalAmount.Name = "btnCalculateTotalAmount"
        btnCalculateTotalAmount.Size = New Size(410, 71)
        btnCalculateTotalAmount.TabIndex = 26
        btnCalculateTotalAmount.Text = "Calculate Total Amount"
        btnCalculateTotalAmount.UseVisualStyleBackColor = True
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(389, 1131)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(435, 39)
        txtTax.TabIndex = 27
        ' 
        ' btnGenerateReceipt
        ' 
        btnGenerateReceipt.Font = New Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerateReceipt.Location = New Point(1021, 1255)
        btnGenerateReceipt.Name = "btnGenerateReceipt"
        btnGenerateReceipt.Size = New Size(360, 65)
        btnGenerateReceipt.TabIndex = 28
        btnGenerateReceipt.Text = "Generate Receipt"
        btnGenerateReceipt.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(79, 1365)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 32)
        Label9.TabIndex = 29
        Label9.Text = "Payment Method"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(79, 1430)
        Label10.Name = "Label10"
        Label10.Size = New Size(164, 32)
        Label10.TabIndex = 30
        Label10.Text = "Transaction ID"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(79, 1500)
        Label12.Name = "Label12"
        Label12.Size = New Size(120, 32)
        Label12.TabIndex = 31
        Label12.Text = "Served By"
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(389, 1365)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(362, 40)
        cmbPaymentMethod.TabIndex = 32
        ' 
        ' cmbServedBy
        ' 
        cmbServedBy.FormattingEnabled = True
        cmbServedBy.Location = New Point(389, 1497)
        cmbServedBy.Name = "cmbServedBy"
        cmbServedBy.Size = New Size(435, 40)
        cmbServedBy.TabIndex = 33
        ' 
        ' txtTransactionID
        ' 
        txtTransactionID.Location = New Point(399, 1440)
        txtTransactionID.Name = "txtTransactionID"
        txtTransactionID.Size = New Size(352, 39)
        txtTransactionID.TabIndex = 34
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(894, 177)
        Label13.Name = "Label13"
        Label13.Size = New Size(187, 32)
        Label13.TabIndex = 35
        Label13.Text = "Receipt Number"
        ' 
        ' GenerateUniqueReceiptNumber
        ' 
        GenerateUniqueReceiptNumber.Location = New Point(1259, 177)
        GenerateUniqueReceiptNumber.Name = "GenerateUniqueReceiptNumber"
        GenerateUniqueReceiptNumber.Size = New Size(286, 39)
        GenerateUniqueReceiptNumber.TabIndex = 36
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1650, 1559)
        Controls.Add(GenerateUniqueReceiptNumber)
        Controls.Add(Label13)
        Controls.Add(txtTransactionID)
        Controls.Add(cmbServedBy)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnGenerateReceipt)
        Controls.Add(txtTax)
        Controls.Add(btnCalculateTotalAmount)
        Controls.Add(txtTotalAmount)
        Controls.Add(txtSubtotal)
        Controls.Add(btnCalculateSubtotal)
        Controls.Add(txtDiscount)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label11)
        Controls.Add(lblTax)
        Controls.Add(lblSubtotal)
        Controls.Add(BtnAddItem)
        Controls.Add(txtPricePerItem)
        Controls.Add(txtQuantity)
        Controls.Add(txtItemName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(itemsList)
        Controls.Add(Label5)
        Controls.Add(txtAddress)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtCustomerName)
        Controls.Add(txtDateOfPurchase)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "China Town Store Receipt System"
        CType(itemsList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDateOfPurchase As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents itemsList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPricePerItem As TextBox
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents btnCalculateSubtotal As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents btnCalculateTotalAmount As Button
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnGenerateReceipt As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents cmbServedBy As ComboBox
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GenerateUniqueReceiptNumber As TextBox

End Class
