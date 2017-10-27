
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Shapes

Class MainWindow
    Public Sub New()


        InitializeComponent()

        ' Crea un stackpanel para contener la figura

        Dim myStackPanel As New StackPanel()


        ' Crea un  ellipse 
        Dim myEllipse As New Ellipse()


        ' Crea un SolidColorBrush de color  para rellenar el ellipse
        Dim mySolidColorBrush As New SolidColorBrush()


        ' Describe el color del pincel usando valors RGB 
        ' Cada valor tiene un rango de 0-225
        mySolidColorBrush.Color = Color.FromArgb(255, 0, 125, 0)
        myEllipse.Fill = mySolidColorBrush
        myEllipse.StrokeThickness = 25
        myEllipse.Stroke = Brushes.Black



        'comentaria'

        Dim variable As Integer




        ' Da el largo y el ancho del Ellipse
        myEllipse.Width = 200
        myEllipse.Height = 100


        ' Agrega el Ellipse al StackPanel 
        myStackPanel.Children.Add(myEllipse)

            Me.Content = myStackPanel
        End Sub


End Class
