
Imports System.IO

Public Class PizzaOrder

#Region "Variables"
    Private roundedCornerSize = 10  'formMain_Load
    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
#End Region

    Private Sub PizzaOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSize.Items.Add("Small")
        cmbSize.Items.Add("Medium")
        cmbSize.Items.Add("Large")
        SetDefaults()




        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, roundedCornerSize, roundedCornerSize), 180, 90)
        path.AddLine(roundedCornerSize, 0, Me.Width - roundedCornerSize, 0)
        path.AddArc(New Rectangle(Me.Width - roundedCornerSize, 0, roundedCornerSize, roundedCornerSize), -90, 90)
        path.AddLine(Me.Width, roundedCornerSize, Me.Width, Me.Height - roundedCornerSize)
        path.AddArc(New Rectangle(Me.Width - roundedCornerSize, Me.Height - roundedCornerSize, roundedCornerSize, roundedCornerSize), 0, 90)
        path.AddLine(Me.Width - roundedCornerSize, Me.Height, roundedCornerSize, Me.Height)
        path.AddArc(New Rectangle(0, Me.Height - roundedCornerSize, roundedCornerSize, roundedCornerSize), 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)

    End Sub

    Private Function GetToppings() As String
        Dim str As String

        If optCheese.Checked Then str += "Cheese" + vbCrLf
        If optHam.Checked Then str += "Ham" + vbCrLf
        If optMushroom.Checked Then str += "Mushroom" + vbCrLf
        If optPineapple.Checked Then str += "Pineapple" + vbCrLf
        If optPepperoni.Checked Then str += "Pepperoni" + vbCrLf
        If optAnchovies.Checked Then str += "Anchovies" + vbCrLf

        Return str
    End Function

    Private Function GetBase() As String
        If optThick.Checked Then Return "Checked" + vbCrLf
        If optThin.Checked Then Return "Thin" + vbCrLf
        If optStuffed.Checked Then Return "Stuffed" + vbCrLf
    End Function

    Private Function GetCustomerInfo() As String
        Dim str As String
        str += txtName.Text + vbCrLf
        str += txtAdress.Text + vbCrLf
        str += txtPhone.Text + vbCrLf
        Return str
    End Function

    Private Function GetSize() As String
        Return cmbSize.SelectedItem.ToString() + vbCrLf
    End Function

#Region "SetDefaultsMethods"
    Private Sub SetDefaults()
        SetOptDefaults()
        SetSizeDefault()
        SetToppingDefault()
    End Sub

    Private Sub SetOptDefaults()
        optThick.Select()
    End Sub

    Private Sub SetSizeDefault()
        cmbSize.SelectedIndex = 2
    End Sub

    Private Sub SetToppingDefault()
        optCheese.Checked = False
        optHam.Checked = False
        optMushroom.Checked = False
        optPineapple.Checked = False
        optPepperoni.Checked = False
        optAnchovies.Checked = False
    End Sub
#End Region
#Region "Form move"
    Private Sub formMain_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub formMain_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub formMain_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
#End Region


    Private Sub tbnAdd_Click(sender As Object, e As EventArgs) Handles tbnAdd.Click
        txtOrder.AppendText(GetCustomerInfo())
        txtOrder.AppendText(GetBase())
        txtOrder.AppendText(GetSize())
        txtOrder.AppendText("Toppings :" + vbNewLine + GetToppings())

        btnSubmit.Enabled = True
    End Sub

    Private Sub WriteToFile(filePath As String)
        Dim fs As New FileStream(filePath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
        fs.Write(System.Text.Encoding.Unicode.GetBytes(txtOrder.Text), 0, txtOrder.Text.Length)
        fs.Dispose()
        txtOrder.Clear()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        WriteToFile("H:\pizzaOrder.pzo")
        SetDefaults()
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class