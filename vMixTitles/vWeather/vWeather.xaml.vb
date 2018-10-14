Imports System
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization


Public Class vWeather
    Dim ReqURL As String = "https://api.openweathermap.org/data/2.5/forecast?id=3620298&lang=es&APPID=f1949b5b703d54cd62246717d12367d1"
    Dim webReq As WebRequest = WebRequest.Create(ReqURL)

    Dim ResBody = webReq.GetResponse.GetResponseStream()

End Class
