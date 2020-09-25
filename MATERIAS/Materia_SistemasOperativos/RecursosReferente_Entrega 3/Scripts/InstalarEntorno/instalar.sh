#!/bin/bash

function salida
{
#Al finalizar las configuraciones necesarias sale del programa
clear
echo Se ha instalado correctamente el Programa
sleep 1.5
exit
}

function instalar
{
#Variables de entorno
#Utilizada para saber si el programa ya se encuentra instalado
sed -i "/export INSTALL=0/d" $HOME/.bashrc
echo "export INSTALL=1" >> $HOME/.bashrc    

#Utilizada para saber el numero de backups realizados hasta la fecha
echo "export CANTBACKUP=0" >> $HOME/.bashrc   

#Directorios
#Creo el arbol de directorios que sera necesario
mkdir -p /Telediagnostico/Usuarios/Medicos
mkdir /Telediagnostico/Usuarios/Administradores
mkdir /Telediagnostico/Usuarios/Pacientes
mkdir /Telediagnostico/Scripts
mkdir /Telediagnostico/Backup
chmod -R 775 /Telediagnostico/

#Backup
#Se envia la orden de que 1 vez al dia, todos los dias a las 23hs se ejecute el script backup.sh
echo "0 23 * * * root /Telediagnostico/Scripts/backup.sh" >> /etc/crontab
  
#Copia de los archivos a el arbol de directorios realizado
cp abmlmenu.sh /Telediagnostico/Scripts
cp abmlusuarios.sh /Telediagnostico/Scripts
cp abmlgrupos.sh /Telediagnostico/Scripts  
cp backup.sh /Telediagnostico/Scripts  
cp menu.sh /Telediagnostico/Scripts 
cp instalar.sh /Telediagnostico/Scripts 

#Usuarios de la aplicacion
#Creo grupo Necesario para el funcionamiento del sistema
groupadd Necesario
#Creo usuarios Necesarios para el funcionamiento del sistemta
useradd -d /Telediagnostico/Usuarios/Medicos -g Necesario Medico
useradd -d /Telediagnostico/Usuarios/Administradores -g Necesario Administrador
useradd -d /Telediagnostico/Usuarios/Pacientes -g Necesario Paciente
salida
}

function verificacion
{
#Se verifica si el programa ya se encuentra instalado
if [ $INSTALL -eq 1 ]
then
clear
echo El programa ya se encuentra instalado.
sleep 2
exit
else
instalar
fi
}

#SE EJECUTA EL CODIGO MIENTRAS EL USUARIO SEA ROOT
while [ $(id -u) = 0 ] 
do
#Hago un reload al archivo donde se encontran las variables de entorno
#Se hace para que se refresquen los valores de las mismas
. $HOME/.bashrc
verificacion
done
clear
echo "Debes ser Superusuario(root) para ejecutar este scritp"
sleep 1.4
exit
