<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.Textbox1 = New System.Windows.Forms.TextBox()
        Me.Division = New System.Windows.Forms.Button()
        Me.AorS = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Multiplication = New System.Windows.Forms.Button()
        Me.nine = New System.Windows.Forms.Button()
        Me.eight = New System.Windows.Forms.Button()
        Me.seven = New System.Windows.Forms.Button()
        Me.Subtraction = New System.Windows.Forms.Button()
        Me.six = New System.Windows.Forms.Button()
        Me.five = New System.Windows.Forms.Button()
        Me.four = New System.Windows.Forms.Button()
        Me.three = New System.Windows.Forms.Button()
        Me.two = New System.Windows.Forms.Button()
        Me.one = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Button()
        Me.Percentage = New System.Windows.Forms.Button()
        Me.dot = New System.Windows.Forms.Button()
        Me.zero = New System.Windows.Forms.Button()
        Me.Addition = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Textbox1
        '
        Me.Textbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Textbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textbox1.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox1.ForeColor = System.Drawing.Color.White
        Me.Textbox1.Location = New System.Drawing.Point(21, 42)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(259, 56)
        Me.Textbox1.TabIndex = 1
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division
        '
        Me.Division.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Division.FlatAppearance.BorderSize = 0
        Me.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Division.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division.ForeColor = System.Drawing.Color.White
        Me.Division.Location = New System.Drawing.Point(220, 117)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(60, 53)
        Me.Division.TabIndex = 2
        Me.Division.Text = "÷"
        Me.Division.UseVisualStyleBackColor = False
        '
        'AorS
        '
        Me.AorS.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AorS.FlatAppearance.BorderSize = 0
        Me.AorS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AorS.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AorS.ForeColor = System.Drawing.Color.White
        Me.AorS.Location = New System.Drawing.Point(154, 117)
        Me.AorS.Name = "AorS"
        Me.AorS.Size = New System.Drawing.Size(60, 53)
        Me.AorS.TabIndex = 3
        Me.AorS.Text = "±"
        Me.AorS.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Delete.FlatAppearance.BorderSize = 0
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.Location = New System.Drawing.Point(87, 117)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(60, 53)
        Me.Delete.TabIndex = 4
        Me.Delete.Text = "⌫"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Multiplication
        '
        Me.Multiplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Multiplication.FlatAppearance.BorderSize = 0
        Me.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Multiplication.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplication.ForeColor = System.Drawing.Color.White
        Me.Multiplication.Location = New System.Drawing.Point(220, 176)
        Me.Multiplication.Name = "Multiplication"
        Me.Multiplication.Size = New System.Drawing.Size(60, 53)
        Me.Multiplication.TabIndex = 8
        Me.Multiplication.Text = "x"
        Me.Multiplication.UseVisualStyleBackColor = False
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.nine.FlatAppearance.BorderSize = 0
        Me.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nine.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine.ForeColor = System.Drawing.Color.White
        Me.nine.Location = New System.Drawing.Point(154, 176)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(60, 53)
        Me.nine.TabIndex = 7
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.eight.FlatAppearance.BorderSize = 0
        Me.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eight.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight.ForeColor = System.Drawing.Color.White
        Me.eight.Location = New System.Drawing.Point(88, 176)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(60, 53)
        Me.eight.TabIndex = 6
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.seven.FlatAppearance.BorderSize = 0
        Me.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seven.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven.ForeColor = System.Drawing.Color.White
        Me.seven.Location = New System.Drawing.Point(21, 176)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(60, 53)
        Me.seven.TabIndex = 5
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'Subtraction
        '
        Me.Subtraction.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Subtraction.FlatAppearance.BorderSize = 0
        Me.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Subtraction.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtraction.ForeColor = System.Drawing.Color.White
        Me.Subtraction.Location = New System.Drawing.Point(220, 235)
        Me.Subtraction.Name = "Subtraction"
        Me.Subtraction.Size = New System.Drawing.Size(60, 53)
        Me.Subtraction.TabIndex = 12
        Me.Subtraction.Text = "-"
        Me.Subtraction.UseVisualStyleBackColor = False
        '
        'six
        '
        Me.six.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.six.FlatAppearance.BorderSize = 0
        Me.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.six.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six.ForeColor = System.Drawing.Color.White
        Me.six.Location = New System.Drawing.Point(154, 235)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(60, 53)
        Me.six.TabIndex = 11
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.five.FlatAppearance.BorderSize = 0
        Me.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.five.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five.ForeColor = System.Drawing.Color.White
        Me.five.Location = New System.Drawing.Point(88, 235)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(60, 53)
        Me.five.TabIndex = 10
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.four.FlatAppearance.BorderSize = 0
        Me.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.four.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four.ForeColor = System.Drawing.Color.White
        Me.four.Location = New System.Drawing.Point(21, 235)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(60, 53)
        Me.four.TabIndex = 9
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'three
        '
        Me.three.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.three.FlatAppearance.BorderSize = 0
        Me.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.three.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three.ForeColor = System.Drawing.Color.White
        Me.three.Location = New System.Drawing.Point(154, 294)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(60, 53)
        Me.three.TabIndex = 15
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'two
        '
        Me.two.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.two.FlatAppearance.BorderSize = 0
        Me.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.two.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two.ForeColor = System.Drawing.Color.White
        Me.two.Location = New System.Drawing.Point(88, 294)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(60, 53)
        Me.two.TabIndex = 14
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'one
        '
        Me.one.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.one.FlatAppearance.BorderSize = 0
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.ForeColor = System.Drawing.Color.White
        Me.one.Location = New System.Drawing.Point(21, 294)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(60, 53)
        Me.one.TabIndex = 13
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'Result
        '
        Me.Result.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Result.FlatAppearance.BorderSize = 0
        Me.Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Result.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Result.Location = New System.Drawing.Point(220, 353)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(60, 53)
        Me.Result.TabIndex = 20
        Me.Result.Text = "="
        Me.Result.UseVisualStyleBackColor = False
        '
        'Percentage
        '
        Me.Percentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Percentage.FlatAppearance.BorderSize = 0
        Me.Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Percentage.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage.ForeColor = System.Drawing.Color.White
        Me.Percentage.Location = New System.Drawing.Point(154, 353)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(60, 53)
        Me.Percentage.TabIndex = 19
        Me.Percentage.Text = "%"
        Me.Percentage.UseVisualStyleBackColor = False
        '
        'dot
        '
        Me.dot.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dot.FlatAppearance.BorderSize = 0
        Me.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dot.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dot.ForeColor = System.Drawing.Color.White
        Me.dot.Location = New System.Drawing.Point(87, 353)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(60, 53)
        Me.dot.TabIndex = 18
        Me.dot.Text = "."
        Me.dot.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.zero.FlatAppearance.BorderSize = 0
        Me.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zero.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero.ForeColor = System.Drawing.Color.White
        Me.zero.Location = New System.Drawing.Point(21, 353)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(60, 53)
        Me.zero.TabIndex = 17
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = False
        '
        'Addition
        '
        Me.Addition.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Addition.FlatAppearance.BorderSize = 0
        Me.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addition.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addition.ForeColor = System.Drawing.Color.White
        Me.Addition.Location = New System.Drawing.Point(220, 294)
        Me.Addition.Name = "Addition"
        Me.Addition.Size = New System.Drawing.Size(60, 53)
        Me.Addition.TabIndex = 21
        Me.Addition.Text = "+"
        Me.Addition.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Clear.FlatAppearance.BorderSize = 0
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Clear.Location = New System.Drawing.Point(21, 117)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(60, 53)
        Me.Clear.TabIndex = 0
        Me.Clear.Text = "C"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 426)
        Me.Controls.Add(Me.Addition)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Percentage)
        Me.Controls.Add(Me.dot)
        Me.Controls.Add(Me.zero)
        Me.Controls.Add(Me.three)
        Me.Controls.Add(Me.two)
        Me.Controls.Add(Me.one)
        Me.Controls.Add(Me.Subtraction)
        Me.Controls.Add(Me.six)
        Me.Controls.Add(Me.five)
        Me.Controls.Add(Me.four)
        Me.Controls.Add(Me.Multiplication)
        Me.Controls.Add(Me.nine)
        Me.Controls.Add(Me.eight)
        Me.Controls.Add(Me.seven)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.AorS)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Clear)
        Me.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Textbox1 As TextBox
    Friend WithEvents Division As Button
    Friend WithEvents AorS As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Multiplication As Button
    Friend WithEvents nine As Button
    Friend WithEvents eight As Button
    Friend WithEvents seven As Button
    Friend WithEvents Subtraction As Button
    Friend WithEvents six As Button
    Friend WithEvents five As Button
    Friend WithEvents four As Button
    Friend WithEvents three As Button
    Friend WithEvents two As Button
    Friend WithEvents one As Button
    Friend WithEvents Result As Button
    Friend WithEvents Percentage As Button
    Friend WithEvents dot As Button
    Friend WithEvents zero As Button
    Friend WithEvents Addition As Button
    Friend WithEvents Clear As Button
End Class
