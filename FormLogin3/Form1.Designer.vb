<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextUser = New TextBox()
        TextPassword = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(99, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 23)
        Label1.TabIndex = 0
        Label1.Text = "Form Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(13, 54)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(13, 88)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextUser
        ' 
        TextUser.Location = New Point(119, 51)
        TextUser.Name = "TextUser"
        TextUser.Size = New Size(157, 28)
        TextUser.TabIndex = 3
        ' 
        ' TextPassword
        ' 
        TextPassword.Location = New Point(119, 85)
        TextPassword.Name = "TextPassword"
        TextPassword.Size = New Size(157, 28)
        TextPassword.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(112, 133)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 183)
        Controls.Add(BtnLogin)
        Controls.Add(TextPassword)
        Controls.Add(TextUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents BtnLogin As Button
End Class
