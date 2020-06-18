#!/bin/bash

function salida
{
clear
#Luego de terminar de eliminar y volver a la anterior configuracion sale del programa
echo Se ha desinstalado correctamente
sleep 1.5
exit
}

function desinstalar
{
#Cambio el valor de la variable, para indicar que el programa se desinstalo
#Elimino la variable de entorno de backups realizados
sed -i "s/export INSTALL=1/export INSTALL=0/" $HOME/.bashrc
sed -i "/export CANTBACKUP=*/d" $HOME/.bashrc

#Borro el directorio Scripts con sus archivos adentros
rm -R /Telediagnostico/

#Borro los scripts que no se encuentran en el arbol de directorios
rm /etc/cron.daily/backup.sh

#Elimino los usuarios y grupos instalados
userdel -fr Administrador
userdel -fr Medico
userdel -fr Paciente
groupdel Necesario

#Al finalizar su respectiva desinstalacion, se ejecuta la funcion salida
salida
}

function verificacion
{
#Se verifica si el programa se encuentra instalado
if [ $INSTALL -eq 1 ]
then
clear
echo Esta seguro que desea desinstalar el programa"("s/n")"
read -p ": " op
case $op in
s)desinstalar;;
n)sh menu.sh;;
S)desinstalar;;
N)sh menu.sh;;
*)echo -e "\e[1m;31mOpcion incorrecta\e[0m";;
esac
else
echo El programa no se encuentra instalado
sleep 2
exit
fi
}

#SE EJECUTA EL CODIGO SI EL USUARIO QUE EJECUTO ES ROOT
while [ $(id -u) = 0 ]
do
#Hago un reload al archivo donde se econtraran las variables de entorno
#Se hace para refrescar el valor de las variables antes de utilizarlas
. $HOME/.bashrc
verificacion
done
clear
echo "Debe ser Superusuario(root) para ejecutar este script"
sleep 1.5
exit
