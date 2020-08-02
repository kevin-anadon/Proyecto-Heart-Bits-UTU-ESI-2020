#!/bin/bash

function menu
{
clear

contfails=$(cat /var/log/secure | grep -c "Failed password")
contexito=$(cat /var/log/secure | grep -c "Accepted password")
lastlog=$(cat /var/log/lastlog)
echo ----------
echo " REPORTES"
echo ----------
echo Cantidad de logs fallidos: $contfails
echo Cantidad de logs exitosos: $contexito
echo Ultimo log: $lastlog
echo ""
echo Presione enter para continuar...
read
sh menulog.sh
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
menu
fi
