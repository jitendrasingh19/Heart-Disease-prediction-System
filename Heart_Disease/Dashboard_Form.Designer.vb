<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Form))
        Me.Button1 = New System.Windows.Forms.Button
        Me.New_Input = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Cambria", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(36, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 52)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'New_Input
        '
        Me.New_Input.BackColor = System.Drawing.Color.Blue
        Me.New_Input.Font = New System.Drawing.Font("Cambria", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Input.ForeColor = System.Drawing.Color.White
        Me.New_Input.Location = New System.Drawing.Point(36, 62)
        Me.New_Input.Name = "New_Input"
        Me.New_Input.Size = New System.Drawing.Size(170, 52)
        Me.New_Input.TabIndex = 22
        Me.New_Input.Text = "New Data"
        Me.New_Input.UseVisualStyleBackColor = False
        '
        'Dashboard_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1037, 645)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.New_Input)
        Me.Name = "Dashboard_Form"
        Me.Text = "HEART DISEASE PREDICTION SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents New_Input As System.Windows.Forms.Button
End Class
