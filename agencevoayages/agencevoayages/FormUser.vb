Public Class FormUser
    Private Sub formuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RafraichirTableau()
    End Sub

    Private Sub RafraichirTableau()
        dgv_vols.Rows.Clear()
        For Each vol As Vol In manager.Vols
            dgv_vols.Rows.Add(vol.Numero, vol.Destination, vol.DateVol, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub

    Private Sub btn_rech_Click(sender As Object, e As EventArgs) Handles btn_rech.Click
        Dim destination As String = txt_des.Text
        Dim dateVol As DateTime = pick_dt.Value


        Dim resultats = From vol In manager.Vols
                        Where vol.Destination.Contains(destination) AndAlso vol.DateVol.Date = dateVol.Date
                        Select vol

        If resultats.Any() Then
            dgv_vols.Rows.Clear()
            For Each vol As Vol In resultats
                dgv_vols.Rows.Add(vol.Numero, vol.Destination, vol.DateVol, vol.PlacesDisponibles, vol.Prix)
            Next
        Else
            MessageBox.Show("Aucun vol trouvé pour les critères de recherche.", "Résultat de recherche", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btn_res_Click(sender As Object, e As EventArgs) Handles btn_res.Click
        If dgv_vols.SelectedRows.Count > 0 Then
            Dim index As Integer = dgv_vols.SelectedRows(0).Index
            Dim vol As Vol = manager.Vols(index)

            If vol.PlacesDisponibles > 0 Then
                Dim nomClient As String = txt_nom.Text
                Dim prenomClient As String = txt_pren.Text
                Dim telClient As String = txt_num.Text

                If String.IsNullOrWhiteSpace(nomClient) OrElse String.IsNullOrWhiteSpace(prenomClient) OrElse String.IsNullOrWhiteSpace(telClient) Then
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                vol.PlacesDisponibles -= 1
                MessageBox.Show("Réservation effectuée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

                GenererRecu(vol, nomClient, prenomClient, telClient)

                RafraichirTableau()
            Else
                MessageBox.Show("Désolé, aucune place disponible pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un vol à réserver.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GenererRecu(vol As Vol, nomClient As String, prenomClient As String, telClient As String)
        Dim recu As String = $"Réservation de Billet
                              ----------------------------
                              Vol: {vol.Numero}
                              Destination: {vol.Destination}
                              Date et Heure: {vol.DateVol}
                              Places restantes: {vol.PlacesDisponibles}
                              Prix: {vol.Prix} TND

                              Client:
                              Nom: {nomClient}
                              Prénom: {prenomClient}
                              Téléphone: {telClient}"

        MessageBox.Show(recu, "Reçu de Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_dnx_Click(sender As Object, e As EventArgs) Handles btn_dnx.Click
        Dim formgestion As New Form1()
        formgestion.Show()
        Me.Close()
    End Sub

End Class