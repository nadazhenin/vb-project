Public Class Form1
    Private Sub btn_cnx_Click(sender As Object, e As EventArgs) Handles btn_cnx.Click
        Dim username As String = txt_user.Text
        Dim password As String = txt_pwd.Text
        Dim role As String = cmb_role.SelectedItem

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(role) Then
            MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If username = "admin" AndAlso password = "admin123" AndAlso role = "Admin" Then
            MessageBox.Show("Connexion réussie en tant qu'Admin.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim formAdmin As New formadmin()
            formAdmin.Show()
            Me.Hide()

        ElseIf username = "user" AndAlso password = "user123" AndAlso role = "Utilisateur" Then
            MessageBox.Show("Connexion réussie en tant qu'Utilisateur.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim formUser As New FormUser()
            formUser.Show()
            Me.Hide()

        Else
            MessageBox.Show("Nom d'utilisateur, mot de passe ou rôle incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub gestionvols_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_role.Items.Add("Admin")
        cmb_role.Items.Add("Utilisateur")
        cmb_role.SelectedIndex = 0

    End Sub

End Class
