Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Automatically set the Date of Purchase to the current date
        txtDateOfPurchase.Text = DateTime.Now.ToString("dd/MM/yyyy")


    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click

        ' Itemsto be added to DataGridView (itemsList)
        Dim itemName As String = txtItemName.Text
        Dim quantity As Integer = CInt(txtQuantity.Text)
        Dim price As Decimal = CDec(txtPricePerItem.Text)

        ' Add the item to the grid
        Dim row As String() = New String() {itemName, quantity.ToString(), price.ToString()}
        itemsList.Rows.Add(row)

        ' Clear input fields after adding
        txtItemName.Clear()
        txtQuantity.Clear()
        txtPricePerItem.Clear()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateSubtotal.Click

        Dim subtotal As Decimal = 0
        For Each row As DataGridViewRow In itemsList.Rows
            If Not row.IsNewRow Then
                Dim quantity As Integer = CInt(row.Cells(1).Value)
                Dim price As Decimal = CDec(row.Cells(2).Value)
                subtotal += (quantity * price)
            End If
        Next
        txtSubtotal.Text = subtotal.ToString("C2") ' Display in currency format


    End Sub

    Private Sub BtnCalculateTotalAmount_Click(sender As Object, e As EventArgs) Handles btnCalculateTotalAmount.Click

        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim tax As Decimal = subtotal * 0.18D ' Assuming 18% tax rate
        Dim discount As Decimal = If(String.IsNullOrEmpty(txtDiscount.Text), 0D, CDec(txtDiscount.Text))

        txtTax.Text = tax.ToString("C2")
        Dim total As Decimal = subtotal + tax - discount
        txtTotalAmount.Text = total.ToString("C2")

    End Sub

    Private Sub BtnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click

        Dim receiptNumber As String = "GenerateUniqueReceiptNumber"
        Dim receiptDetails As String = "Receipt #: " & receiptNumber & vbCrLf &
                                       "Date: " & txtDateOfPurchase.Text & vbCrLf &
                                       "Customer: " & txtCustomerName.Text & vbCrLf &
                                       "Served By: " & cmbServedBy.Text & vbCrLf &
                                       "---------------------------------" & vbCrLf &
                                       "Items: " & vbCrLf

        ' Loop through items to add to receipt
        For Each row As DataGridViewRow In itemsList.Rows
            If Not row.IsNewRow Then
                receiptDetails &= row.Cells(0).Value & " - " & row.Cells(1).Value & " @ " & row.Cells(2).Value & vbCrLf
            End If
        Next

        receiptDetails &= "---------------------------------" & vbCrLf &
                          "Subtotal: " & txtSubtotal.Text & vbCrLf &
                          "Tax: " & txtTax.Text & vbCrLf &
                          "Discount: " & txtDiscount.Text & vbCrLf &
                          "Total Due: " & txtTotalAmount.Text & vbCrLf &
                          "Payment Method: " & cmbPaymentMethod.Text & vbCrLf


        ' Display receipt
        MessageBox.Show(receiptDetails, "Generated Receipt")

    End Sub

    Private Sub GenerateUniqueReceiptNumber_TextChanged(sender As Object, e As EventArgs) Handles GenerateUniqueReceiptNumber.TextChanged

        'Return Date.Now.ToString("yyyyMMddHHmmss")'


    End Sub
End Class
