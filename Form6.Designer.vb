<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label4 = New Label()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Label5 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Guna2CustomGradientPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderColor = Color.DimGray
        Guna2Button1.BorderRadius = 20
        Guna2Button1.BorderThickness = 2
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Button1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(402, 669)
        Guna2Button1.Margin = New Padding(3, 2, 3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(357, 57)
        Guna2Button1.TabIndex = 11
        Guna2Button1.Text = "Create Group"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(363, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 32)
        Label4.TabIndex = 15
        Label4.Text = "Group Name:"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges5
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(363, 67)
        Guna2TextBox1.Margin = New Padding(10, 11, 10, 11)
        Guna2TextBox1.Multiline = True
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.Silver
        Guna2TextBox1.PlaceholderText = "Task Name"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox1.Size = New Size(439, 63)
        Guna2TextBox1.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(363, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 32)
        Label5.TabIndex = 16
        Label5.Text = "Member/s:"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.BackColor = Color.Transparent
        FlowLayoutPanel2.Location = New Point(391, 216)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(376, 368)
        FlowLayoutPanel2.TabIndex = 17
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.Controls.Add(FlowLayoutPanel1)
        Guna2CustomGradientPanel2.Controls.Add(Label1)
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel2.Dock = DockStyle.Left
        Guna2CustomGradientPanel2.FillColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Guna2CustomGradientPanel2.FillColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        Guna2CustomGradientPanel2.FillColor3 = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Guna2CustomGradientPanel2.FillColor4 = Color.Black
        Guna2CustomGradientPanel2.Location = New Point(0, 0)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel2.Size = New Size(317, 756)
        Guna2CustomGradientPanel2.TabIndex = 18
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Location = New Point(11, 87)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(292, 657)
        FlowLayoutPanel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 16
        Label1.Text = "Friends:"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(59), CByte(0), CByte(59))
        ClientSize = New Size(850, 756)
        Controls.Add(Guna2CustomGradientPanel2)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(Guna2Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Guna2TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        Text = "Form6"
        Guna2CustomGradientPanel2.ResumeLayout(False)
        Guna2CustomGradientPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
