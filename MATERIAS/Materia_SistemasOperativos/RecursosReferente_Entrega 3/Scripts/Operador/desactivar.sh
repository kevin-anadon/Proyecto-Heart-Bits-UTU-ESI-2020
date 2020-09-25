#!/bin/bash

function desactivar
{
clear
servicio=$(cat tmp2.txt)
rm tmp2.txt
checkactivo=$(systemctl status $servicio | grep "Active: active")
if [ -z "$checkactivo" ]
then
echo "El servicio ya se encuentra desactivado"
sleep 1.4
exit
fi

systemctl stop $servicio
checkafter=$(systemctl status $servicio | grep "Active: inactive")
if [ -z "$checkafter" ]
then
echo "El servicio ingresado no ha podido ser activado"
else
echo "El servicio ha sido desactivado con exito!"
sleep 1.3
echo ""
systemctl status $servicio
fi
}

function inicio
{
clear
read -p "Ingrese el nombre del servicio que desea deshabilitar: " servicio
checkexist=$(systemctl list-unit-files | grep $servicio)

if [ ! -z "$checkexist" ]
then
echo $servicio >> tmp2.txt
desactivar
else
echo -e "\e[1;31mEl servicio ingresado no existe\e[0m"
sleep 1.4
sh menuservicios.sh
fi
}

#VERIFICA SI EL USUARIO QUE EJECUTA EL SCRIPT ES ROOT
if [ ! $(id -u) = 0 ]
then
clear
echo "Debes ser Superususario(root) para ejecutar el script"
sleep 1.5
exit
else
#En caso de serlo ejecuta la funcion menu
inicio
fi
