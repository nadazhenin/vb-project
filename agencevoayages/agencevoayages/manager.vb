
Public Structure Vol
        Dim Numero As Integer
        Dim Destination As String
        Dim DateVol As DateTime
        Dim PlacesDisponibles As Integer
        Dim Prix As Decimal
    End Structure

Public Module manager
    Public Vols As New List(Of Vol)
End Module
