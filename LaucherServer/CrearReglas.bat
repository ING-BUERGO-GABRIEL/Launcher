@echo off

set "appPath=%~dp0LauncherRamses.exe"

REM Verificar si la regla UDP existe
netsh advfirewall firewall show rule name="UDPLaucherRamses" >nul 2>&1
if errorlevel 1 (
    REM La regla UDP no existe, crearla
    netsh advfirewall firewall add rule name="UDPLaucherRamses" dir=in action=allow program="%appPath%" enable=yes profile=domain,private,public protocol=udp localport=any remoteip=any
) else (
    REM La regla UDP existe, actualizar la ruta del programa
    netsh advfirewall firewall set rule name="UDPLaucherRamses" new program="%appPath%"
)

REM Verificar si la regla TCP existe
netsh advfirewall firewall show rule name="TCPLaucherRamses" >nul 2>&1
if errorlevel 1 (
    REM La regla TCP no existe, crearla
    netsh advfirewall firewall add rule name="TCPLaucherRamses" dir=in action=allow program="%appPath%" enable=yes profile=domain,private,public protocol=tcp localport=any remoteip=any
) else (
    REM La regla TCP existe, actualizar la ruta del programa
    netsh advfirewall firewall set rule name="TCPLaucherRamses" new program="%appPath%"
)

echo Reglas de firewall actualizadas o creadas exitosamente.
pause
