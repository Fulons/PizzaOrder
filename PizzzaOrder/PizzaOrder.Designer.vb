<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optStuffed = New System.Windows.Forms.RadioButton()
        Me.optThin = New System.Windows.Forms.RadioButton()
        Me.optThick = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optAnchovies = New System.Windows.Forms.CheckBox()
        Me.optHam = New System.Windows.Forms.CheckBox()
        Me.optPineapple = New System.Windows.Forms.CheckBox()
        Me.optPepperoni = New System.Windows.Forms.CheckBox()
        Me.optMushroom = New System.Windows.Forms.CheckBox()
        Me.optCheese = New System.Windows.Forms.CheckBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbnAdd = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optStuffed)
        Me.GroupBox1.Controls.Add(Me.optThin)
        Me.GroupBox1.Controls.Add(Me.optThick)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 99)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Pizza Base"
        '
        'optStuffed
        '
        Me.optStuffed.AutoSize = True
        Me.optStuffed.Location = New System.Drawing.Point(6, 68)
        Me.optStuffed.Name = "optStuffed"
        Me.optStuffed.Size = New System.Drawing.Size(59, 17)
        Me.optStuffed.TabIndex = 2
        Me.optStuffed.TabStop = True
        Me.optStuffed.Text = "Stuffed"
        Me.optStuffed.UseVisualStyleBackColor = True
        '
        'optThin
        '
        Me.optThin.AutoSize = True
        Me.optThin.Location = New System.Drawing.Point(6, 45)
        Me.optThin.Name = "optThin"
        Me.optThin.Size = New System.Drawing.Size(46, 17)
        Me.optThin.TabIndex = 1
        Me.optThin.TabStop = True
        Me.optThin.Text = "Thin"
        Me.optThin.UseVisualStyleBackColor = True
        '
        'optThick
        '
        Me.optThick.AutoSize = True
        Me.optThick.Location = New System.Drawing.Point(6, 21)
        Me.optThick.Name = "optThick"
        Me.optThick.Size = New System.Drawing.Size(52, 17)
        Me.optThick.TabIndex = 0
        Me.optThick.TabStop = True
        Me.optThick.Text = "Thick"
        Me.optThick.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optAnchovies)
        Me.GroupBox2.Controls.Add(Me.optHam)
        Me.GroupBox2.Controls.Add(Me.optPineapple)
        Me.GroupBox2.Controls.Add(Me.optPepperoni)
        Me.GroupBox2.Controls.Add(Me.optMushroom)
        Me.GroupBox2.Controls.Add(Me.optCheese)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 156)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'optAnchovies
        '
        Me.optAnchovies.AutoSize = True
        Me.optAnchovies.Location = New System.Drawing.Point(17, 135)
        Me.optAnchovies.Name = "optAnchovies"
        Me.optAnchovies.Size = New System.Drawing.Size(76, 17)
        Me.optAnchovies.TabIndex = 5
        Me.optAnchovies.Text = "Anchovies"
        Me.optAnchovies.UseVisualStyleBackColor = True
        '
        'optHam
        '
        Me.optHam.AutoSize = True
        Me.optHam.Location = New System.Drawing.Point(17, 45)
        Me.optHam.Name = "optHam"
        Me.optHam.Size = New System.Drawing.Size(48, 17)
        Me.optHam.TabIndex = 4
        Me.optHam.Text = "Ham"
        Me.optHam.UseVisualStyleBackColor = True
        '
        'optPineapple
        '
        Me.optPineapple.AutoSize = True
        Me.optPineapple.Location = New System.Drawing.Point(17, 91)
        Me.optPineapple.Name = "optPineapple"
        Me.optPineapple.Size = New System.Drawing.Size(73, 17)
        Me.optPineapple.TabIndex = 3
        Me.optPineapple.Text = "Pineapple"
        Me.optPineapple.UseVisualStyleBackColor = True
        '
        'optPepperoni
        '
        Me.optPepperoni.AutoSize = True
        Me.optPepperoni.Location = New System.Drawing.Point(17, 113)
        Me.optPepperoni.Name = "optPepperoni"
        Me.optPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.optPepperoni.TabIndex = 2
        Me.optPepperoni.Text = "Pepperoni"
        Me.optPepperoni.UseVisualStyleBackColor = True
        '
        'optMushroom
        '
        Me.optMushroom.AutoSize = True
        Me.optMushroom.Location = New System.Drawing.Point(17, 68)
        Me.optMushroom.Name = "optMushroom"
        Me.optMushroom.Size = New System.Drawing.Size(75, 17)
        Me.optMushroom.TabIndex = 1
        Me.optMushroom.Text = "Mushroom"
        Me.optMushroom.UseVisualStyleBackColor = True
        '
        'optCheese
        '
        Me.optCheese.AutoSize = True
        Me.optCheese.Location = New System.Drawing.Point(17, 22)
        Me.optCheese.Name = "optCheese"
        Me.optCheese.Size = New System.Drawing.Size(62, 17)
        Me.optCheese.TabIndex = 0
        Me.optCheese.Text = "Cheese"
        Me.optCheese.UseVisualStyleBackColor = True
        '
        'cmbSize
        '
        Me.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Location = New System.Drawing.Point(55, 170)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(86, 21)
        Me.cmbSize.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 201)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(93, 253)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 5
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(93, 227)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(100, 20)
        Me.txtAdress.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Adress:"
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(318, 252)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 32)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tbnAdd
        '
        Me.tbnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbnAdd.Location = New System.Drawing.Point(407, 252)
        Me.tbnAdd.Name = "tbnAdd"
        Me.tbnAdd.Size = New System.Drawing.Size(83, 32)
        Me.tbnAdd.TabIndex = 11
        Me.tbnAdd.Text = "Add to Order"
        Me.tbnAdd.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(496, 252)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(83, 31)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(26, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pizza Delivery Service"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Your order:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrders, Me.ViewToolStripMenuItem, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuOrders
        '
        Me.mnuOrders.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuDelete, Me.mnuExit})
        Me.mnuOrders.Name = "mnuOrders"
        Me.mnuOrders.Size = New System.Drawing.Size(54, 20)
        Me.mnuOrders.Text = "Orders"
        '
        'mnuNew
        '
        Me.mnuNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewOrder})
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(107, 22)
        Me.mnuNew.Text = "New"
        '
        'mnuNewOrder
        '
        Me.mnuNewOrder.Name = "mnuNewOrder"
        Me.mnuNewOrder.Size = New System.Drawing.Size(104, 22)
        Me.mnuNewOrder.Text = "Order"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(107, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(107, 22)
        Me.mnuExit.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGreen, Me.mnuBlue, Me.mnuBrown, Me.mnuNone})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mnuGreen
        '
        Me.mnuGreen.Name = "mnuGreen"
        Me.mnuGreen.Size = New System.Drawing.Size(108, 22)
        Me.mnuGreen.Text = "Green"
        '
        'mnuBlue
        '
        Me.mnuBlue.Name = "mnuBlue"
        Me.mnuBlue.Size = New System.Drawing.Size(108, 22)
        Me.mnuBlue.Text = "Blue"
        '
        'mnuBrown
        '
        Me.mnuBrown.Name = "mnuBrown"
        Me.mnuBrown.Size = New System.Drawing.Size(108, 22)
        Me.mnuBrown.Text = "Brown"
        '
        'mnuNone
        '
        Me.mnuNone.Name = "mnuNone"
        Me.mnuNone.Size = New System.Drawing.Size(108, 22)
        Me.mnuNone.Text = "None"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(367, 74)
        Me.txtOrder.Multiline = True
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(207, 169)
        Me.txtOrder.TabIndex = 16
        '
        'PizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 294)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.tbnAdd)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "PizzaOrder"
        Me.Text = "PizzaOrder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents optStuffed As System.Windows.Forms.RadioButton
    Friend WithEvents optThin As System.Windows.Forms.RadioButton
    Friend WithEvents optThick As System.Windows.Forms.RadioButton
    Friend WithEvents optAnchovies As System.Windows.Forms.CheckBox
    Friend WithEvents optHam As System.Windows.Forms.CheckBox
    Friend WithEvents optPineapple As System.Windows.Forms.CheckBox
    Friend WithEvents optPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents optMushroom As System.Windows.Forms.CheckBox
    Friend WithEvents optCheese As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tbnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtOrder As System.Windows.Forms.TextBox
End Class
