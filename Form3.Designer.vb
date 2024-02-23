<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Label3 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        Label1 = New Label()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2Panel3.SuspendLayout()
        Guna2Panel4.SuspendLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BorderRadius = 5
        Guna2Panel3.Controls.Add(Label3)
        Guna2Panel3.Controls.Add(Guna2Button1)
        Guna2Panel3.Controls.Add(FlowLayoutPanel1)
        Guna2Panel3.Controls.Add(Guna2Panel4)
        Guna2Panel3.CustomizableEdges = CustomizableEdges6
        Guna2Panel3.Dock = DockStyle.Left
        Guna2Panel3.FillColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Guna2Panel3.Location = New Point(0, 0)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        Guna2Panel3.Size = New Size(405, 806)
        Guna2Panel3.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(21, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 32)
        Label3.TabIndex = 8
        Label3.Text = "Friends:"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderRadius = 20
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Button1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(94, 714)
        Guna2Button1.Margin = New Padding(3, 2, 3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(215, 51)
        Guna2Button1.TabIndex = 7
        Guna2Button1.Text = "Add Friend"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Location = New Point(21, 205)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(381, 478)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Guna2Panel4
        ' 
        Guna2Panel4.Controls.Add(Label2)
        Guna2Panel4.Controls.Add(Label1)
        Guna2Panel4.Controls.Add(Guna2CirclePictureBox1)
        Guna2Panel4.CustomizableEdges = CustomizableEdges4
        Guna2Panel4.Dock = DockStyle.Top
        Guna2Panel4.FillColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Guna2Panel4.Location = New Point(0, 0)
        Guna2Panel4.Name = "Guna2Panel4"
        Guna2Panel4.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2Panel4.Size = New Size(405, 127)
        Guna2Panel4.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(119, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 24)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(119, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 32)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(12, 12)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(90, 90)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 3
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1353, 806)
        Controls.Add(Guna2Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        Guna2Panel3.ResumeLayout(False)
        Guna2Panel3.PerformLayout()
        Guna2Panel4.ResumeLayout(False)
        Guna2Panel4.PerformLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label3 As Label
End Class
