Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms


Namespace RequestDataLoadingExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim layer As New ImageLayer()
            mapControl1.Layers.Add(layer)
            Dim provider As New BingMapDataProvider()
            provider.BingKey = "YOUR_BING_KEY"
            layer.DataProvider = provider
            AddHandler layer.RequestDataLoading, AddressOf OnRequestDataLoading
            AddHandler layer.DataLoaded, AddressOf OnDataLoaded
        End Sub
        Private Sub OnRequestDataLoading(ByVal sender As Object, ByVal e As EventArgs)
            Cursor.Current = Cursors.WaitCursor
            If Not splashScreenManager1.IsSplashFormVisible Then
                splashScreenManager1.ShowWaitForm()
            End If
        End Sub
        Private Sub OnDataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Cursor.Current = Cursors.Default
            splashScreenManager1.CloseWaitForm()
        End Sub

    End Class
End Namespace
