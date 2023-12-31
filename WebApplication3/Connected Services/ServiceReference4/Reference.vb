﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference4
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="urn:sap-com:document:sap:rfc:functions", ConfigurationName:="ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV")>  _
    Public Interface ZWS_SPU_CUSTOMER_LIST_SRV
        
        'CODEGEN: Generating message contract since the operation ZFM_SPU_CUSTOMERS is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="urn:sap-com:document:sap:rfc:functions:ZWS_SPU_CUSTOMER_LIST_SRV:ZFM_SPU_CUSTOMER"& _ 
            "SRequest", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ZFM_SPU_CUSTOMERS(ByVal request As ServiceReference4.ZFM_SPU_CUSTOMERSRequest) As ServiceReference4.ZFM_SPU_CUSTOMERSResponse1
        
        <System.ServiceModel.OperationContractAttribute(Action:="urn:sap-com:document:sap:rfc:functions:ZWS_SPU_CUSTOMER_LIST_SRV:ZFM_SPU_CUSTOMER"& _ 
            "SRequest", ReplyAction:="*")>  _
        Function ZFM_SPU_CUSTOMERSAsync(ByVal request As ServiceReference4.ZFM_SPU_CUSTOMERSRequest) As System.Threading.Tasks.Task(Of ServiceReference4.ZFM_SPU_CUSTOMERSResponse1)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:rfc:functions")>  _
    Partial Public Class ZFM_SPU_CUSTOMERS
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:sap-com:document:sap:rfc:functions")>  _
    Partial Public Class ZSPU_CUST_STR
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private bRANCHCODEField As String
        
        Private bRANCHNAMEField As String
        
        Private gSTINNUMField As String
        
        Private aDDRESSField As String
        
        Private pINCODEField As String
        
        Private rEGIONCODEField As String
        
        Private rEGIONDESCField As String
        
        Private pANField As String
        
        Private mOBILENOField As String
        
        Private eMAILIDField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property BRANCHCODE() As String
            Get
                Return Me.bRANCHCODEField
            End Get
            Set
                Me.bRANCHCODEField = value
                Me.RaisePropertyChanged("BRANCHCODE")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property BRANCHNAME() As String
            Get
                Return Me.bRANCHNAMEField
            End Get
            Set
                Me.bRANCHNAMEField = value
                Me.RaisePropertyChanged("BRANCHNAME")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property GSTINNUM() As String
            Get
                Return Me.gSTINNUMField
            End Get
            Set
                Me.gSTINNUMField = value
                Me.RaisePropertyChanged("GSTINNUM")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property ADDRESS() As String
            Get
                Return Me.aDDRESSField
            End Get
            Set
                Me.aDDRESSField = value
                Me.RaisePropertyChanged("ADDRESS")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property PINCODE() As String
            Get
                Return Me.pINCODEField
            End Get
            Set
                Me.pINCODEField = value
                Me.RaisePropertyChanged("PINCODE")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property REGIONCODE() As String
            Get
                Return Me.rEGIONCODEField
            End Get
            Set
                Me.rEGIONCODEField = value
                Me.RaisePropertyChanged("REGIONCODE")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property REGIONDESC() As String
            Get
                Return Me.rEGIONDESCField
            End Get
            Set
                Me.rEGIONDESCField = value
                Me.RaisePropertyChanged("REGIONDESC")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>  _
        Public Property PAN() As String
            Get
                Return Me.pANField
            End Get
            Set
                Me.pANField = value
                Me.RaisePropertyChanged("PAN")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property MOBILENO() As String
            Get
                Return Me.mOBILENOField
            End Get
            Set
                Me.mOBILENOField = value
                Me.RaisePropertyChanged("MOBILENO")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>  _
        Public Property EMAILID() As String
            Get
                Return Me.eMAILIDField
            End Get
            Set
                Me.eMAILIDField = value
                Me.RaisePropertyChanged("EMAILID")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:rfc:functions")>  _
    Partial Public Class ZFM_SPU_CUSTOMERSResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private cUSTOMERSField() As ZSPU_CUST_STR
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property CUSTOMERS() As ZSPU_CUST_STR()
            Get
                Return Me.cUSTOMERSField
            End Get
            Set
                Me.cUSTOMERSField = value
                Me.RaisePropertyChanged("CUSTOMERS")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ZFM_SPU_CUSTOMERSRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="urn:sap-com:document:sap:rfc:functions", Order:=0)>  _
        Public ZFM_SPU_CUSTOMERS As ServiceReference4.ZFM_SPU_CUSTOMERS
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ZFM_SPU_CUSTOMERS As ServiceReference4.ZFM_SPU_CUSTOMERS)
            MyBase.New
            Me.ZFM_SPU_CUSTOMERS = ZFM_SPU_CUSTOMERS
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ZFM_SPU_CUSTOMERSResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="urn:sap-com:document:sap:rfc:functions", Order:=0)>  _
        Public ZFM_SPU_CUSTOMERSResponse As ServiceReference4.ZFM_SPU_CUSTOMERSResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ZFM_SPU_CUSTOMERSResponse As ServiceReference4.ZFM_SPU_CUSTOMERSResponse)
            MyBase.New
            Me.ZFM_SPU_CUSTOMERSResponse = ZFM_SPU_CUSTOMERSResponse
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ZWS_SPU_CUSTOMER_LIST_SRVChannel
        Inherits ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ZWS_SPU_CUSTOMER_LIST_SRVClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV)
        Implements ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference4_ZWS_SPU_CUSTOMER_LIST_SRV_ZFM_SPU_CUSTOMERS(ByVal request As ServiceReference4.ZFM_SPU_CUSTOMERSRequest) As ServiceReference4.ZFM_SPU_CUSTOMERSResponse1 Implements ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV.ZFM_SPU_CUSTOMERS
            Return MyBase.Channel.ZFM_SPU_CUSTOMERS(request)
        End Function
        
        Public Function ZFM_SPU_CUSTOMERS(ByVal ZFM_SPU_CUSTOMERS1 As ServiceReference4.ZFM_SPU_CUSTOMERS) As ServiceReference4.ZFM_SPU_CUSTOMERSResponse
            Dim inValue As ServiceReference4.ZFM_SPU_CUSTOMERSRequest = New ServiceReference4.ZFM_SPU_CUSTOMERSRequest()
            inValue.ZFM_SPU_CUSTOMERS = ZFM_SPU_CUSTOMERS1
            Dim retVal As ServiceReference4.ZFM_SPU_CUSTOMERSResponse1 = CType(Me,ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV).ZFM_SPU_CUSTOMERS(inValue)
            Return retVal.ZFM_SPU_CUSTOMERSResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference4_ZWS_SPU_CUSTOMER_LIST_SRV_ZFM_SPU_CUSTOMERSAsync(ByVal request As ServiceReference4.ZFM_SPU_CUSTOMERSRequest) As System.Threading.Tasks.Task(Of ServiceReference4.ZFM_SPU_CUSTOMERSResponse1) Implements ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV.ZFM_SPU_CUSTOMERSAsync
            Return MyBase.Channel.ZFM_SPU_CUSTOMERSAsync(request)
        End Function
        
        Public Function ZFM_SPU_CUSTOMERSAsync(ByVal ZFM_SPU_CUSTOMERS As ServiceReference4.ZFM_SPU_CUSTOMERS) As System.Threading.Tasks.Task(Of ServiceReference4.ZFM_SPU_CUSTOMERSResponse1)
            Dim inValue As ServiceReference4.ZFM_SPU_CUSTOMERSRequest = New ServiceReference4.ZFM_SPU_CUSTOMERSRequest()
            inValue.ZFM_SPU_CUSTOMERS = ZFM_SPU_CUSTOMERS
            Return CType(Me,ServiceReference4.ZWS_SPU_CUSTOMER_LIST_SRV).ZFM_SPU_CUSTOMERSAsync(inValue)
        End Function
    End Class
End Namespace
