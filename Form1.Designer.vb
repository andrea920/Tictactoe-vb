<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnAA = New System.Windows.Forms.Button()
        Me.btnAAA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnBB = New System.Windows.Forms.Button()
        Me.btnBBB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.btnCCC = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(23, 12)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(94, 83)
        Me.btnA.TabIndex = 0
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnAA
        '
        Me.btnAA.Location = New System.Drawing.Point(123, 12)
        Me.btnAA.Name = "btnAA"
        Me.btnAA.Size = New System.Drawing.Size(94, 83)
        Me.btnAA.TabIndex = 0
        Me.btnAA.UseVisualStyleBackColor = True
        '
        'btnAAA
        '
        Me.btnAAA.Location = New System.Drawing.Point(223, 12)
        Me.btnAAA.Name = "btnAAA"
        Me.btnAAA.Size = New System.Drawing.Size(94, 83)
        Me.btnAAA.TabIndex = 0
        Me.btnAAA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(23, 101)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(94, 83)
        Me.btnB.TabIndex = 0
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnBB
        '
        Me.btnBB.Location = New System.Drawing.Point(123, 101)
        Me.btnBB.Name = "btnBB"
        Me.btnBB.Size = New System.Drawing.Size(94, 83)
        Me.btnBB.TabIndex = 0
        Me.btnBB.UseVisualStyleBackColor = True
        '
        'btnBBB
        '
        Me.btnBBB.Location = New System.Drawing.Point(223, 101)
        Me.btnBBB.Name = "btnBBB"
        Me.btnBBB.Size = New System.Drawing.Size(94, 83)
        Me.btnBBB.TabIndex = 0
        Me.btnBBB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(23, 190)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(94, 83)
        Me.btnC.TabIndex = 0
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnCC
        '
        Me.btnCC.Location = New System.Drawing.Point(123, 190)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(94, 83)
        Me.btnCC.TabIndex = 0
        Me.btnCC.UseVisualStyleBackColor = True
        '
        'btnCCC
        '
        Me.btnCCC.Location = New System.Drawing.Point(223, 190)
        Me.btnCCC.Name = "btnCCC"
        Me.btnCCC.Size = New System.Drawing.Size(94, 83)
        Me.btnCCC.TabIndex = 0
        Me.btnCCC.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(45, 293)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(94, 29)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Location = New System.Drawing.Point(202, 293)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(94, 29)
        Me.btnQuitGame.TabIndex = 1
        Me.btnQuitGame.Text = "Quit Game"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 344)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnCCC)
        Me.Controls.Add(Me.btnBBB)
        Me.Controls.Add(Me.btnAAA)
        Me.Controls.Add(Me.btnCC)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnBB)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnAA)
        Me.Controls.Add(Me.btnA)
        Me.Name = "Form1"
        Me.Text = "My TicTacToe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnA As Button
    Friend WithEvents btnAA As Button
    Friend WithEvents btnAAA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnBB As Button
    Friend WithEvents btnBBB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnCC As Button
    Friend WithEvents btnCCC As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnQuitGame As Button
End Class
