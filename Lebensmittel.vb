Public Class Lebensmittel
    Private bezeichnung As String
    Private kcal As Decimal
    Private kohlenhydrate As Decimal
    Private glukose As Decimal
    Private fruktose As Decimal
    Private protein As Decimal
    Private fett As Decimal
    Private gesFett As Decimal
    Private ungesFett As Decimal
    Private paleo As Boolean
    Private vegetarisch As Boolean
    Private vegan As Boolean
    Private glutenfrei As Boolean


    Public Sub New(bez As String, kc As Decimal, kh As Decimal, gluk As Decimal, fruk As Decimal,
                   pro As Decimal, Fat As Decimal, gfat As Decimal, ungfat As Decimal)
        bezeichnung = bez
        kcal = kc
        kohlenhydrate = kh
        glukose = gluk
        fruktose = fruk
        protein = pro
        fett = Fat
        gesFett = gfat
        ungesFett = ungfat



    End Sub
    Public Sub New(bez As String)
        bezeichnung = bez
        kcal = 0
        kohlenhydrate = 0
        glukose = 0
        fruktose = 0
        protein = 0
        fett = 0
        gesFett = 0
        ungesFett = 0
    End Sub

    Public Sub rezept(bez As String, kc As Double, kh As Decimal, gluk As Decimal,
                      fruk As Decimal, prot As Decimal, fat As Decimal, gfat As Decimal, ungfat As Decimal)
        Me.bezeichnung = bez
        Me.kcal = kc
        Me.kohlenhydrate = kh
        Me.glukose = gluk
        Me.fruktose = fruk
        Me.protein = prot
        Me.fett = fat
        Me.gesFett = gfat
        Me.ungesFett = ungfat

    End Sub
    Public Property Pbezeichnung() As String
        Get
            Return bezeichnung
        End Get
        Private Set(value As String)
            bezeichnung = value
        End Set
    End Property
    Public Property Pkcal() As Double
        Get
            Return kcal

        End Get
        Private Set(value As Double)
            kcal = value
        End Set
    End Property

    Public Property Pkohlenhydrate() As Decimal
        Get
            Return kohlenhydrate

        End Get
        Private Set(value As Decimal)
            kohlenhydrate = value
        End Set
    End Property

    Public Property pglukose() As Decimal
        Get
            Return glukose
        End Get
        Set(value As Decimal)
            glukose = value
        End Set
    End Property

    Public Property pfruktose() As Decimal
        Get
            Return fruktose
        End Get
        Set(value As Decimal)
            fruktose = value
        End Set
    End Property

    Public Property pprotein() As Decimal
        Get
            Return protein
        End Get
        Set(value As Decimal)
            protein = value
        End Set
    End Property

    Public Property pfett() As Decimal
        Get
            Return fett
        End Get
        Set(value As Decimal)
            fett = value
        End Set
    End Property

    Public Property pgesfett() As Decimal
        Get
            Return fett
        End Get
        Set(value As Decimal)
            fett = value
        End Set
    End Property

    Public Property pungesfett() As Decimal
        Get
            Return gesFett
        End Get
        Set(value As Decimal)
            gesFett = value
        End Set
    End Property

    ' Public Sub New(b As String, kcal As Double, kohlenhydrate As Double, glukose As Double, fruktose As Double, protein As Double, fett As Double, gesfett As Double, ungesfett As Double, paleo as boolean, vegetarisch as boolean, vegan as boolean, glutenfrei as boolean)

    ' End Sub
    Public Sub anzeigen()
        MessageBox.Show(Me.Pkcal)
    End Sub
End Class
