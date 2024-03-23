Imports System.Collections.Generic

Namespace Unidad5
    Partial Public Class Form1
        Inherits Form
        Private archivos As New List(Of Archivo)()
        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Configuración de la DataGridView
            archivosDataGridView.AutoGenerateColumns = False
            archivosDataGridView.Columns.Add("Nombre", "Nombre")
            archivosDataGridView.Columns.Add("Tipo", "Tipo")
            archivosDataGridView.Columns.Add("Tamaño", "Tamaño")
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Aquí puedes agregar la lógica para agregar archivos
            ' en este ejemplo se agregan datos de muestra
            archivos.Add(New Archivo With {
                .Aspecto = "Costo inicial",
                .ArchivosFisicos = "Bajo costo inicial para establecerlo.",
                .ArchivosDigitales = "Costo moderado para la infraestructura.",
                .AlmacenamientoEnLaNube = "Puede requerir un costo inicial moderado."
            })
            archivos.Add(New Archivo With {
                .Aspecto = "Costo operativo.",
                .ArchivosFisicos = "Mantenimiento físico y seguridad.",
                .ArchivosDigitales = "Costos de electricidad y mantenimiento.",
                .AlmacenamientoEnLaNube = "Costos de suscripción o almacenamiento."
            })
            archivos.Add(New Archivo With {
                .Aspecto = "Accesibilidad",
                .ArchivosFisicos = "Acceso limitado dependiendo de la ubicación física.",
                .ArchivosDigitales = "Acceso remoto desde cualquier ubicación.",
                .AlmacenamientoEnLaNube = "Acceso remoto desde cualquier ubicación."
            })
            archivos.Add(New Archivo With {
                .Aspecto = "Escalabilidad",
                .ArchivosFisicos = "Limitada por espacio físico.",
                .ArchivosDigitales = "Escalabilidad alta sin limitaciones físicas.",
                .AlmacenamientoEnLaNube = "Escalabilidad alta sin limitaciones físicas."
            })
            archivos.Add(New Archivo With {
                .Aspecto = "Seguridad",
                .ArchivosFisicos = "Riesgo de pérdida por desastres naturales.",
                .ArchivosDigitales = "Vulnerable a ciberataques y fallos de hardware.",
                .AlmacenamientoEnLaNube = "Mayor seguridad con cifrado y redundancia."
            })

            ' Actualizar la DataGridView
            ActualizarDataGridView()
        End Sub

        Private Sub ActualizarDataGridView()
            archivosDataGridView.Rows.Clear()

            For Each archivo In archivos
                archivosDataGridView.Rows.Add(archivo.Aspecto, archivo.ArchivosFisicos, archivo.ArchivosDigitales, archivo.AlmacenamientoEnLaNube)
            Next
        End Sub

        Public Class Archivo
            Public Property Aspecto As String
            Public Property ArchivosFisicos As String
            Public Property ArchivosDigitales As String
            Public Property AlmacenamientoEnLaNube As String
        End Class

        Friend WithEvents archivosDataGridView As DataGridView
        Friend WithEvents Button1 As Button

        Private Sub InitializeComponent()
            archivosDataGridView = New DataGridView()
            Button1 = New Button()
            CType(archivosDataGridView, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' archivosDataGridView
            ' 
            archivosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            archivosDataGridView.Location = New Point(12, 197)
            archivosDataGridView.Name = "archivosDataGridView"
            archivosDataGridView.RowHeadersWidth = 51
            archivosDataGridView.Size = New Size(812, 260)
            archivosDataGridView.TabIndex = 0
            ' 
            ' Button1
            ' 
            Button1.Location = New Point(12, 149)
            Button1.Name = "Button1"
            Button1.Size = New Size(94, 29)
            Button1.TabIndex = 1
            Button1.Text = "Button1"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            ClientSize = New Size(836, 491)
            Controls.Add(Button1)
            Controls.Add(archivosDataGridView)
            Name = "Form1"
            CType(archivosDataGridView, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub
    End Class
End Namespace

