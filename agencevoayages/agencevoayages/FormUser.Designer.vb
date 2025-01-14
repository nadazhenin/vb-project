<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        lbl_nom = New Label()
        lbl_pren = New Label()
        lbl_des = New Label()
        lbl_dt = New Label()
        lbl_num = New Label()
        txt_nom = New TextBox()
        txt_num = New TextBox()
        txt_pren = New TextBox()
        txt_des = New TextBox()
        pick_dt = New DateTimePicker()
        dgv_vols = New DataGridView()
        numeroplace = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        destination = New DataGridViewTextBoxColumn()
        dt = New DataGridViewTextBoxColumn()
        btn_rech = New Button()
        btn_res = New Button()
        btn_dnx = New Button()
        CType(dgv_vols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_nom
        ' 
        lbl_nom.AutoSize = True
        lbl_nom.Location = New Point(22, 36)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(42, 20)
        lbl_nom.TabIndex = 0
        lbl_nom.Text = "Nom"
        ' 
        ' lbl_pren
        ' 
        lbl_pren.AutoSize = True
        lbl_pren.Location = New Point(260, 36)
        lbl_pren.Name = "lbl_pren"
        lbl_pren.Size = New Size(60, 20)
        lbl_pren.TabIndex = 1
        lbl_pren.Text = "Prenom"
        ' 
        ' lbl_des
        ' 
        lbl_des.AutoSize = True
        lbl_des.Location = New Point(22, 143)
        lbl_des.Name = "lbl_des"
        lbl_des.Size = New Size(85, 20)
        lbl_des.TabIndex = 2
        lbl_des.Text = "Destination"
        ' 
        ' lbl_dt
        ' 
        lbl_dt.AutoSize = True
        lbl_dt.Location = New Point(22, 263)
        lbl_dt.Name = "lbl_dt"
        lbl_dt.Size = New Size(102, 20)
        lbl_dt.TabIndex = 3
        lbl_dt.Text = "Date et Heure"
        ' 
        ' lbl_num
        ' 
        lbl_num.AutoSize = True
        lbl_num.Location = New Point(251, 168)
        lbl_num.Name = "lbl_num"
        lbl_num.Size = New Size(134, 20)
        lbl_num.TabIndex = 4
        lbl_num.Text = "Numero téléphone"
        ' 
        ' txt_nom
        ' 
        txt_nom.Location = New Point(22, 81)
        txt_nom.Name = "txt_nom"
        txt_nom.Size = New Size(125, 27)
        txt_nom.TabIndex = 5
        ' 
        ' txt_num
        ' 
        txt_num.Location = New Point(260, 225)
        txt_num.Name = "txt_num"
        txt_num.Size = New Size(125, 27)
        txt_num.TabIndex = 6
        ' 
        ' txt_pren
        ' 
        txt_pren.Location = New Point(260, 81)
        txt_pren.Name = "txt_pren"
        txt_pren.Size = New Size(125, 27)
        txt_pren.TabIndex = 7
        ' 
        ' txt_des
        ' 
        txt_des.Location = New Point(22, 180)
        txt_des.Name = "txt_des"
        txt_des.Size = New Size(125, 27)
        txt_des.TabIndex = 8
        ' 
        ' pick_dt
        ' 
        pick_dt.Location = New Point(22, 314)
        pick_dt.Name = "pick_dt"
        pick_dt.Size = New Size(250, 27)
        pick_dt.TabIndex = 9
        ' 
        ' dgv_vols
        ' 
        dgv_vols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vols.Columns.AddRange(New DataGridViewColumn() {numeroplace, Prix, destination, dt})
        dgv_vols.Location = New Point(613, 36)
        dgv_vols.Name = "dgv_vols"
        dgv_vols.RowHeadersWidth = 51
        dgv_vols.Size = New Size(554, 188)
        dgv_vols.TabIndex = 10
        ' 
        ' numeroplace
        ' 
        numeroplace.HeaderText = "Numeroplace"
        numeroplace.MinimumWidth = 6
        numeroplace.Name = "numeroplace"
        numeroplace.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' destination
        ' 
        destination.HeaderText = "destination"
        destination.MinimumWidth = 6
        destination.Name = "destination"
        destination.Width = 125
        ' 
        ' dt
        ' 
        dt.HeaderText = "Date et heure"
        dt.MinimumWidth = 6
        dt.Name = "dt"
        dt.Width = 125
        ' 
        ' btn_rech
        ' 
        btn_rech.Location = New Point(291, 386)
        btn_rech.Name = "btn_rech"
        btn_rech.Size = New Size(94, 29)
        btn_rech.TabIndex = 11
        btn_rech.Text = "Rechercher"
        btn_rech.UseVisualStyleBackColor = True
        ' 
        ' btn_res
        ' 
        btn_res.Location = New Point(563, 386)
        btn_res.Name = "btn_res"
        btn_res.Size = New Size(94, 29)
        btn_res.TabIndex = 12
        btn_res.Text = "Réserver"
        btn_res.UseVisualStyleBackColor = True
        ' 
        ' btn_dnx
        ' 
        btn_dnx.Location = New Point(841, 386)
        btn_dnx.Name = "btn_dnx"
        btn_dnx.Size = New Size(118, 29)
        btn_dnx.TabIndex = 13
        btn_dnx.Text = "Déconnexion"
        btn_dnx.UseVisualStyleBackColor = True
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 450)
        Controls.Add(btn_dnx)
        Controls.Add(btn_res)
        Controls.Add(btn_rech)
        Controls.Add(dgv_vols)
        Controls.Add(pick_dt)
        Controls.Add(txt_des)
        Controls.Add(txt_pren)
        Controls.Add(txt_num)
        Controls.Add(txt_nom)
        Controls.Add(lbl_num)
        Controls.Add(lbl_dt)
        Controls.Add(lbl_des)
        Controls.Add(lbl_pren)
        Controls.Add(lbl_nom)
        Name = "FormUser"
        Text = "FormUser"
        CType(dgv_vols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_pren As Label
    Friend WithEvents lbl_des As Label
    Friend WithEvents lbl_dt As Label
    Friend WithEvents lbl_num As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_pren As TextBox
    Friend WithEvents txt_des As TextBox
    Friend WithEvents pick_dt As DateTimePicker
    Friend WithEvents dgv_vols As DataGridView
    Friend WithEvents numeroplace As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents destination As DataGridViewTextBoxColumn
    Friend WithEvents dt As DataGridViewTextBoxColumn
    Friend WithEvents btn_rech As Button
    Friend WithEvents btn_res As Button
    Friend WithEvents btn_dnx As Button
End Class
