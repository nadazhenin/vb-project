Public Class formadmin
    Private Sub formadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_vols.Columns.Add("Numero", "Numéro")
        dgv_vols.Columns.Add("Destination", "Destination")
        dgv_vols.Columns.Add("DateVol", "Date et Heure")
        dgv_vols.Columns.Add("PlacesDisponibles", "Nombres Places")
        dgv_vols.Columns.Add("Prix", "Prix (TND)")
        RafraichirTableau()
    End Sub

    Private Sub RafraichirTableau()
        dgv_vols.Rows.Clear()
        For Each vol As Vol In manager.Vols
            dgv_vols.Rows.Add(vol.Numero, vol.Destination, vol.DateVol, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub
    Private Function ValiderChamps() As Boolean
        If String.IsNullOrWhiteSpace(txt_num.Text) OrElse
           String.IsNullOrWhiteSpace(txt_des.Text) OrElse
           String.IsNullOrWhiteSpace(txt_nbr.Text) OrElse
           String.IsNullOrWhiteSpace(txt_prix.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Integer.TryParse(txt_num.Text, Nothing) OrElse Not Integer.TryParse(txt_nbr.Text, Nothing) Then
            MessageBox.Show("Numéro et Nombres Places doivent être des nombres entiers.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Decimal.TryParse(txt_prix.Text, Nothing) Then
            MessageBox.Show("Prix doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        If Not ValiderChamps() Then Exit Sub

        Dim nouveauVol As New Vol With {
            .Numero = Integer.Parse(txt_num.Text),
            .Destination = txt_des.Text,
            .DateVol = pick_dt.Value,
            .PlacesDisponibles = Integer.Parse(txt_nbr.Text),
            .Prix = Decimal.Parse(txt_prix.Text)
        }

        manager.Vols.Add(nouveauVol)
        MessageBox.Show("Vol ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RafraichirTableau()
    End Sub

    Private Sub btn_modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click
        If dgv_vols.SelectedRows.Count > 0 Then
            If Not ValiderChamps() Then Exit Sub

            Dim index As Integer = dgv_vols.SelectedRows(0).Index
            manager.Vols(index) = New Vol With {
                .Numero = Integer.Parse(txt_num.Text),
                .Destination = txt_des.Text,
                .DateVol = pick_dt.Value,
                .PlacesDisponibles = Integer.Parse(txt_nbr.Text),
                .Prix = Decimal.Parse(txt_prix.Text)
            }

            MessageBox.Show("Vol modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RafraichirTableau()
        Else
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        If dgv_vols.SelectedRows.Count > 0 Then
            Dim index As Integer = dgv_vols.SelectedRows(0).Index
            manager.Vols.RemoveAt(index)

            MessageBox.Show("Vol supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RafraichirTableau()
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_dnx_Click(sender As Object, e As EventArgs) Handles btn_dnx.Click
        Dim formconnexion As New Form1()
        formconnexion.Show()
        Me.Close()
    End Sub
End Class
