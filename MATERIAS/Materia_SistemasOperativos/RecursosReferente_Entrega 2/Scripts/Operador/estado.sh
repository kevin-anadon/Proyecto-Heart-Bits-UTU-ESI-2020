#!/bin/bash

function consumo
{
clear
echo "Para salir presione 'q'"
sleep 1.4
systemd-cgtop
menu
}

function inactivos
{
clear
systemctl --all | grep "inactive" | grep ".service" | more
echo ""
echo "Presione enter para continuar..."
read
menu
}

function activos
{
clear
systemctl | grep "loaded active" | grep ".service" | more
echo ""
echo "Presione enter para continuar..."
read
menu
}

function todos
{
clear
systemctl list-unit-files
echo ""
echo "Presione enter para continuar..."
read
menu
}

function busqueda
{
clear
read -p "Ingrese el servicio que desea ver: " search
checkexist=$(systemctl list-unit-files |grep $search)
while [ ! -z "$checkexist" ]
do
echo ""
systemctl status $search
echo ""
echo "Pulse enter para continuar..."
read
exit
done
echo ""
echo -e "\e[1;31mEl servicio ingresado no existe!\e[0m"
sleep 1.4
menu
}

function menu
{
clear
echo --------------------
echo -e "\e[1m  ESTADO SERVICIOS\e[0m"
echo --------------------
echo 1")" Busqueda
echo 2")" Todos
echo 3")" Activos
echo 4")" Inactivos
echo 5")" Consumo en memoria
echo 0")" Volver	
echo ""
read -p "Seleccione una opcion: " op
case $op in
1)busqueda;;
2)todos;;
3)activos;;
4)inactivos;;
5)consumo;;
0)sh menuoperador.sh;;
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
