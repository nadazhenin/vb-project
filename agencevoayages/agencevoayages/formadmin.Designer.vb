<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formadmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_num = New Label()
        Lbl_nbr = New Label()
        lbl_des = New Label()
        Label3 = New Label()
        lbl_prix = New Label()
        txt_num = New TextBox()
        txt_nbr = New TextBox()
        txt_prix = New TextBox()
        txt_des = New TextBox()
        pick_dt = New DateTimePicker()
        btn_ajout = New Button()
        btn_modif = New Button()
        btn_supp = New Button()
        btn_dnx = New Button()
        dgv_vols = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        Dt = New DataGridViewTextBoxColumn()
        nbpl = New DataGridViewTextBoxColumn()
        prix = New DataGridViewTextBoxColumn()
        CType(dgv_vols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_num
        ' 
        lbl_num.AutoSize = True
        lbl_num.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_num.ForeColor = Color.IndianRed
        lbl_num.Location = New Point(12, 20)
        lbl_num.Name = "lbl_num"
        lbl_num.Size = New Size(204, 37)
        lbl_num.TabIndex = 0
        lbl_num.Text = "Numero vol"
        ' 
        ' Lbl_nbr
        ' 
        Lbl_nbr.AutoSize = True
        Lbl_nbr.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbl_nbr.ForeColor = Color.IndianRed
        Lbl_nbr.Location = New Point(12, 139)
        Lbl_nbr.Name = "Lbl_nbr"
        Lbl_nbr.Size = New Size(252, 37)
        Lbl_nbr.TabIndex = 1
        Lbl_nbr.Text = "Nombre Places"
        ' 
        ' lbl_des
        ' 
        lbl_des.AutoSize = True
        lbl_des.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_des.ForeColor = Color.IndianRed
        lbl_des.Location = New Point(12, 258)
        lbl_des.Name = "lbl_des"
        lbl_des.Size = New Size(213, 37)
        lbl_des.TabIndex = 2
        lbl_des.Text = "Destination"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(362, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 37)
        Label3.TabIndex = 3
        Label3.Text = "Date et Heure"
        ' 
        ' lbl_prix
        ' 
        lbl_prix.AutoSize = True
        lbl_prix.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_prix.ForeColor = Color.IndianRed
        lbl_prix.Location = New Point(362, 167)
        lbl_prix.Name = "lbl_prix"
        lbl_prix.Size = New Size(92, 37)
        lbl_prix.TabIndex = 4
        lbl_prix.Text = "Prix"
        ' 
        ' txt_num
        ' 
        txt_num.Location = New Point(12, 80)
        txt_num.Name = "txt_num"
        txt_num.Size = New Size(234, 27)
        txt_num.TabIndex = 5
        ' 
        ' txt_nbr
        ' 
        txt_nbr.Location = New Point(12, 203)
        txt_nbr.Name = "txt_nbr"
        txt_nbr.Size = New Size(234, 27)
        txt_nbr.TabIndex = 6
        ' 
        ' txt_prix
        ' 
        txt_prix.Location = New Point(357, 229)
        txt_prix.Name = "txt_prix"
        txt_prix.Size = New Size(245, 27)
        txt_prix.TabIndex = 7
        ' 
        ' txt_des
        ' 
        txt_des.Location = New Point(12, 338)
        txt_des.Name = "txt_des"
        txt_des.Size = New Size(234, 27)
        txt_des.TabIndex = 8
        ' 
        ' pick_dt
        ' 
        pick_dt.Location = New Point(362, 107)
        pick_dt.Name = "pick_dt"
        pick_dt.Size = New Size(250, 27)
        pick_dt.TabIndex = 9
        ' 
        ' btn_ajout
        ' 
        btn_ajout.Font = New Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ajout.Location = New Point(154, 406)
        btn_ajout.Name = "btn_ajout"
        btn_ajout.Size = New Size(146, 48)
        btn_ajout.TabIndex = 10
        btn_ajout.Text = "ajouter"
        btn_ajout.UseVisualStyleBackColor = True
        ' 
        ' btn_modif
        ' 
        btn_modif.Font = New Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_modif.Location = New Point(422, 406)
        btn_modif.Name = "btn_modif"
        btn_modif.Size = New Size(146, 48)
        btn_modif.TabIndex = 11
        btn_modif.Text = "Modifier"
        btn_modif.UseVisualStyleBackColor = True
        ' 
        ' btn_supp
        ' 
        btn_supp.Font = New Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_supp.Location = New Point(682, 406)
        btn_supp.Name = "btn_supp"
        btn_supp.Size = New Size(199, 48)
        btn_supp.TabIndex = 12
        btn_supp.Text = "supprimer"
        btn_supp.UseVisualStyleBackColor = True
        ' 
        ' btn_dnx
        ' 
        btn_dnx.Font = New Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_dnx.Location = New Point(968, 406)
        btn_dnx.Name = "btn_dnx"
        btn_dnx.Size = New Size(229, 48)
        btn_dnx.TabIndex = 13
        btn_dnx.Text = "Deconnexion"
        btn_dnx.UseVisualStyleBackColor = True
        ' 
        ' dgv_vols
        ' 
        dgv_vols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vols.Columns.AddRange(New DataGridViewColumn() {Numero, Destination, Dt, nbpl, prix})
        dgv_vols.Location = New Point(639, 42)
        dgv_vols.Name = "dgv_vols"
        dgv_vols.RowHeadersWidth = 51
        dgv_vols.Size = New Size(680, 188)
        dgv_vols.TabIndex = 14
        ' 
        ' Numero
        ' 
        Numero.HeaderText = "Numero"
        Numero.MinimumWidth = 6
        Numero.Name = "Numero"
        Numero.Width = 125
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' Dt
        ' 
        Dt.HeaderText = "Date"
        Dt.MinimumWidth = 6
        Dt.Name = "Dt"
        Dt.Width = 125
        ' 
        ' nbpl
        ' 
        nbpl.HeaderText = "nombreplaces"
        nbpl.MinimumWidth = 6
        nbpl.Name = "nbpl"
        nbpl.Width = 125
        ' 
        ' prix
        ' 
        prix.HeaderText = "Prix"
        prix.MinimumWidth = 6
        prix.Name = "prix"
        prix.Width = 125
        ' 
        ' formadmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1344, 477)
        Controls.Add(dgv_vols)
        Controls.Add(btn_dnx)
        Controls.Add(btn_supp)
        Controls.Add(btn_modif)
        Controls.Add(btn_ajout)
        Controls.Add(pick_dt)
        Controls.Add(txt_des)
        Controls.Add(txt_prix)
        Controls.Add(txt_nbr)
        Controls.Add(txt_num)
        Controls.Add(lbl_prix)
        Controls.Add(Label3)
        Controls.Add(lbl_des)
        Controls.Add(Lbl_nbr)
        Controls.Add(lbl_num)
        Name = "formadmin"
        Text = "formadmin"
        CType(dgv_vols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_num As Label
    Friend WithEvents Lbl_nbr As Label
    Friend WithEvents lbl_des As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_prix As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_nbr As TextBox
    Friend WithEvents txt_prix As TextBox
    Friend WithEvents txt_des As TextBox
    Friend WithEvents pick_dt As DateTimePicker
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_modif As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents btn_dnx As Button
    Friend WithEvents dgv_vols As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents Dt As DataGridViewTextBoxColumn
    Friend WithEvents nbpl As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
End Class
