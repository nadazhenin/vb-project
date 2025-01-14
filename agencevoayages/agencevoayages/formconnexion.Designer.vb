<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lbl_User = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_user = New TextBox()
        txt_pwd = New TextBox()
        btn_cnx = New Button()
        cmb_role = New ComboBox()
        SuspendLayout()
        ' 
        ' lbl_User
        ' 
        lbl_User.AutoSize = True
        lbl_User.Font = New Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_User.ForeColor = Color.Coral
        lbl_User.Location = New Point(27, 128)
        lbl_User.Name = "lbl_User"
        lbl_User.Size = New Size(171, 35)
        lbl_User.TabIndex = 0
        lbl_User.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(27, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 35)
        Label1.TabIndex = 1
        Label1.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Coral
        Label2.Location = New Point(27, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 35)
        Label2.TabIndex = 2
        Label2.Text = "Role"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 22.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(247, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 45)
        Label3.TabIndex = 3
        Label3.Text = "Zheni  Voyages"
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(286, 128)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(125, 27)
        txt_user.TabIndex = 4
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Location = New Point(286, 217)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(125, 27)
        txt_pwd.TabIndex = 5
        txt_pwd.UseSystemPasswordChar = True
        ' 
        ' btn_cnx
        ' 
        btn_cnx.Font = New Font("Segoe UI Variable Display Semib", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cnx.ForeColor = Color.IndianRed
        btn_cnx.Location = New Point(247, 383)
        btn_cnx.Name = "btn_cnx"
        btn_cnx.Size = New Size(209, 55)
        btn_cnx.TabIndex = 7
        btn_cnx.Text = "Connexion"
        btn_cnx.UseVisualStyleBackColor = True
        ' 
        ' cmb_role
        ' 
        cmb_role.FormattingEnabled = True
        cmb_role.Location = New Point(260, 323)
        cmb_role.Name = "cmb_role"
        cmb_role.Size = New Size(151, 28)
        cmb_role.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmb_role)
        Controls.Add(btn_cnx)
        Controls.Add(txt_pwd)
        Controls.Add(txt_user)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_User)
        Name = "formconnexion"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_User As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents btn_cnx As Button
    Friend WithEvents cmb_role As ComboBox

End Class
