#!/bin/bash

function conexion
{
clear
checkestado=$(ping -c1 192.168.0.1 | grep "Unreachable")
if [ -z "$checkestado" ]
then
echo "Hay conexion a Internet!!"
sleep 1.4
exit
else
echo "No hay conexion a Internet!!"
sleep 1.4
exit
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
conexion
fi
