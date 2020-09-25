#!/bin/bash

function reglas
{
clear
echo "----------------"
echo -e "Reglas de \e[1;32mINPUT\e[0m"
echo "----------------"
sleep 1.1
iptables -L INPUT -n --line-numbers | more
sleep 1.4
echo ""
echo "-----------------"
echo -e "Reglas de \e[1;34mOUTPUT\e[0m"
echo "-----------------"
sleep 1.1
iptables -L OUTPUT -n --line-numbers | more
sleep 1.4
echo ""
echo "------------------"
echo -e "Reglas de \e[1;35mFORWARD\e[0m"
echo "------------------"
sleep 1.1
iptables -L FORWARD -n --line-numbers | more
sleep 1.4
exit
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
reglas
fi
