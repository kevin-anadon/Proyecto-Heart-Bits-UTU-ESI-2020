#!/bin/bash

function actual
{
clear
read -p "Desea ver las reglas actuales (y/n): " op
if [ "$op" = "y" ]
then
echo ""
iptables -L INPUT -n --line-numbers | more
sleep 1.2
exit
elif [ "$op" = "n" ]
then
exit
else
echo -e "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 1.3
actual
fi
}

function bloquear
{
clear
read -p "Ingrese una ip que desee bloquear: " ip
iptables -A INPUT -s $ip -p tcp --dport 2222 -j DROP
echo "La ip ha sido bloqueada con exito!"
sleep 1.5
actual
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
bloquear
fi
