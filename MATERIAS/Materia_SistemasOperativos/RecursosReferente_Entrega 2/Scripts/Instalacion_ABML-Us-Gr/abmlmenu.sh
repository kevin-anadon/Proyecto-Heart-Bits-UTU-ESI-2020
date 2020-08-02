#!/bin/bash

function salir
{
clear
echo Gracias por utilizar nuestro programa
sleep 1.2
exit
}

function menu
{
clear
echo --------------------
echo " Bienvenido al menu"
echo -e "\t\e[0;32mABML\e[0m"
echo --------------------
echo -e "1"")"" ABML \e[1;34musuarios\e[0m"
echo -e "2"")"" ABML \e[0;35mgrupos\e[0m"
echo 0")" Salir
echo --------------------
echo ""
read -p "Seleccione una opcion: " op
case $op in
1)sh abmlusuarios.sh;;
2)sh abmlgrupos.sh;;
0)salir;;
*)echo -e  "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 2
menu;;
esac
}

#VERIFICA SI EL QUE EJECUTA EL SCRIPT ES ROOT
if [ ! $(id -u) = 0 ]
then
echo "Debes ser Superusuario(root) para ejecutar el script"
sleep 1.5
exit
else
menu
fi
