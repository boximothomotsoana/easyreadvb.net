'student number

Public Class EasyRead

    'close the application when clicking ok

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim msg, style, title, help, response, CTxt As String
        msg = "Are you sure you want to terminate the application?" ' Define message
        title = "Exit-Button" ' define title
        style = CStr(vbYesNo Or vbCritical Or vbDefaultButton2) ' define buttons
        help = "DEMO.HLP" 'Define help file
        CTxt = CStr(1000) ' Define topic context
        response = CStr(MsgBox(msg.ToString, CType(style, MsgBoxStyle), title))
        If CDbl(response) = vbYes Then
            Me.Close()
        Else
        End If

    End Sub

    Private Sub cmbChoMag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChoMag.SelectedIndexChanged
        Dim selected As String = cmbChoMag.SelectedItem.ToString()
        TextMag.Text = selected.ToString()
    End Sub

    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
        Dim MagazinePrice As Double
        Dim deliveryCost As Double
        Dim TotalMagazinePrice As Double

        If rdoInsGau.Checked And TextMag.Text = "You" Then

            MagazinePrice = 25
            deliveryCost = ((5 / 100) * MagazinePrice)
            TotalMagazinePrice = MagazinePrice + deliveryCost

        ElseIf rdoInsGau.Checked And TextMag.Text = "Drum" Then

            MagazinePrice = 27
            deliveryCost = ((5 / 100) * MagazinePrice)
            TotalMagazinePrice = MagazinePrice + deliveryCost

        ElseIf rdoInsGau.Checked And TextMag.Text = "Hiusgenoot" Then

            MagazinePrice = 30
            deliveryCost = ((5 / 100) * MagazinePrice)
            TotalMagazinePrice = MagazinePrice + deliveryCost

        ElseIf rdoOutGau.Checked And TextMag.Text = "You" Then

            MagazinePrice = 25
            deliveryCost = ((15 / 100) * MagazinePrice)
            TotalMagazinePrice = MagazinePrice + deliveryCost

        ElseIf rdoOutGau.Checked And TextMag.Text = "Drum" Then

            MagazinePrice = 27
            deliveryCost = (15 / 100) * MagazinePrice
            TotalMagazinePrice = MagazinePrice + deliveryCost

        ElseIf rdoOutGau.Checked And TextMag.Text = "Hiusgenoot" Then

            MagazinePrice = 30
            deliveryCost = ((15 / 100) * MagazinePrice)
            TotalMagazinePrice = MagazinePrice + deliveryCost
        End If

        txtDel.Text = "R" + deliveryCost.ToString()
        txtPrice.Text = "R" + MagazinePrice.ToString()
        txtTotPri.Text = "R" + TotalMagazinePrice.ToString()
        ListBox1.Items.Add("")
        ListBox1.Items.Add(Today)
        ListBox1.Items.Add("_________________________")
        ListBox1.Items.Add("")
        If rdoInsGau.Checked Then
            Dim destination As String = "Inside Gauteng"
            ListBox1.Items.Add("Destination is     " & destination)
        ElseIf rdoOutGau.Checked Then
            Dim destination As String = "Outside Gauteng"
            ListBox1.Items.Add("Destination is     " & destination)
        End If

        ListBox1.Items.Add("Magazine is        " & TextMag.Text)
        ListBox1.Items.Add("Price is           " & txtPrice.Text)
        ListBox1.Items.Add("Delivery cost is   " & txtDel.Text)
        ListBox1.Items.Add("_________________________")
        ListBox1.Items.Add("Total cost is      " & txtTotPri.Text)
        ListBox1.Items.Add("_________________________")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TextMag.Clear()
        txtPrice.Clear()
        txtDel.Clear()
        txtTotPri.Clear()
        cmbChoMag.ResetText()
        cmbChoMag.Focus()
        rdoInsGau.Checked = False
        rdoOutGau.Checked = False
        'ListBox1.Items.Remove(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.Items)
        ListBox1.Items.Clear()

    End Sub

    Private Sub EasyRead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbChoMag.Items.Add("Select Magazine")
        cmbChoMag.Items.Add("Hiusgenoot")
        cmbChoMag.Items.Add("You")
        cmbChoMag.Items.Add("Drum")
        cmbChoMag.SelectedIndex = 0
    End Sub

End Class
