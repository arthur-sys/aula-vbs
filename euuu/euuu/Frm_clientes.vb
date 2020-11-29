Public Class Frm_clientes
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With abrir_foto
                .Title = "SELECIONAR UMA FOTA"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco_access()
    End Sub
End Class