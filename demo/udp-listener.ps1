# PS script to listen on UDP Port and publish content in the CLI
# script originates from msxfaq.de
# https://www.msxfaq.de/code/powershell/psudp.htm

param (
   [string]$localip = "0.0.0.0",
   [string]$udplistenport=9988
)

$udpClient = New-Object system.Net.Sockets.Udpclient($udplistenport)
$RemoteIpEndPoint = New-Object System.Net.IPEndPoint([system.net.IPAddress]::Parse($localip)  , $udplistenport);

while ($true) {
   Write-host "Receive-UDP:Wait for Data on Port: $udplistenport"
   $data=$udpclient.receive([ref]$RemoteIpEndPoint)

   write-host "Received packet from IP " $RemoteIpEndPoint.address ":" $RemoteIpEndPoint.Port
   write-host "Content" ([string]::join("",([System.Text.Encoding]::ASCII.GetChars($data))))
}