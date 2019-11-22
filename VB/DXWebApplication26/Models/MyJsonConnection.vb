Imports Microsoft.VisualBasic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity

Namespace DXWebApplication26
	Public Class MyJsonConnection
		Private privateID As Integer
		<Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateConnectionString As String
		Public Property ConnectionString() As String
			Get
				Return privateConnectionString
			End Get
			Set(ByVal value As String)
				privateConnectionString = value
			End Set
		End Property
	End Class

	Friend Class JsonConnectionContext
		Inherits DbContext
		Private privateConnections As DbSet(Of MyJsonConnection)
		Public Property Connections() As DbSet(Of MyJsonConnection)
			Get
				Return privateConnections
			End Get
			Set(ByVal value As DbSet(Of MyJsonConnection))
				privateConnections = value
			End Set
		End Property
		Public Sub New()
			MyBase.New("ConnectionsStorage")
		End Sub
	End Class
End Namespace