Public Class MainForm
    Const moneyFormat = "N2"

    'Checks if string is in valid number format and not empty
    Private Function isValidNumber(s As String) As Boolean
        Return (s <> "" And IsNumeric(s))
    End Function

    'Checks if price field is valid
    'Returns value as Double if true
    'Returns -1 if false
    Private Function getPrice(field As TextBox) As Double
        Return IIf(isValidNumber(field.Text), field.Text, -1)
    End Function

    'Checks if quantity field is valid
    'Returns value as Integer if true
    'Returns -1 if false
    Private Function getQuantity(field As TextBox) As Integer
        Return IIf(isValidNumber(field.Text), field.Text, -1)
    End Function

    'Takes pair of fields for calculations
    'Returns calculated result
    'Returns -1 if either field is not a valid number
    Private Function calculateTicketSales(priceField As TextBox, quantityField As TextBox) As Double
        Dim price = getPrice(priceField)
        Dim quantity = getQuantity(quantityField)

        Return IIf(price = -1 Or quantity = -1, -1, price * quantity)
    End Function

    'Iterates through first-level children of given parent and clears the TextBoxes
    Private Sub clearChildTextBoxes(parent As Control)
        For Each control As Control In parent.Controls
            If (TypeOf control Is TextBox) Then control.ResetText()
        Next
    End Sub

    'Gets calculations and displays results accordingly
    'Shows message if error
    'Error handling via -1 is faster than Try...Catch
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim grossAdult = calculateTicketSales(PricePerAdultField, AdultTicketsSoldField)
        Dim grossChild = calculateTicketSales(PricePerChildField, ChildTicketsSoldField)

        If Not (grossAdult = -1 Or grossChild = -1) Then
            GrossAdultTicketSalesField.Text = grossAdult.ToString(moneyFormat)
            GrossChildTicketSalesField.Text = grossChild.ToString(moneyFormat)
            TotalGrossRevenueField.Text = (grossAdult + grossChild).ToString(moneyFormat)

            NetAdultTicketSalesField.Text = (grossAdult * 0.2).ToString(moneyFormat)
            NetChildTicketSalesField.Text = (grossChild * 0.2).ToString(moneyFormat)
            TotalNetRevenueField.Text = ((grossAdult + grossChild) * 0.2).ToString(moneyFormat)
        Else
            MessageBox.Show("Invalid Numeric Input")
        End If
    End Sub

    'Clears TextBoxes of each groupbox
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        clearChildTextBoxes(Me.AdultTicketSalesBox)
        clearChildTextBoxes(Me.ChildTicketSalesBox)
        clearChildTextBoxes(Me.GrossTicketRevenueBox)
        clearChildTextBoxes(Me.NetTicketRevenueBox)
    End Sub

    'Exits the program
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub
End Class
