#!/bin/bash

function salir
{
clear
echo Gracias por utilizar nuestro programa
sleep 1.1
exit
}

function menu
{
clear
echo "    __  __                __     ____  _ __"
echo "   / / / /__  ____ ______/ /_   / __ )(_) /______"
echo "  / /_/ / _ \/ __  / ___/ __/  / __  / / __/ ___/"
echo " / __  /  __/ /_/ / /  / /_   / /_/ / / /_(__ )"
echo "/_/ /_/\___/\___ /_/   \__/  /_____/_/\__/____/"
echo --------------------------------------------------
echo -e "\e[1m MENU PRINCIPAL\e[0m"
echo -e "\e[1m  OPERADOR\e[0m"
echo ------------------
echo 1")" Usuarios y Grupos				
echo 2")" Redes
echo 3")" Servicios y Procesos
echo 4")" Logs 
echo 0")" Salir	
echo ""
read -p "Seleccione una opcion: " op
case $op in
1)cd InstalarEntorno
sh abmlmenu.sh;;
2)cd Red
sh menuredes.sh;;
3)cd Operador
sh menuservicios.sh;;
4)cd Logs
sh menulog.sh;;
0)salir;;
*)echo -e "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 2
menu;;
esac
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
