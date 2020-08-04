#!/bin/bash

function salir
{
clear
echo Volviendo al menu abml...
sleep 1.5
sh abmlmenu.sh
}

function agrupo
{
clear
read -p "Ingrese el nombre del grupo a crear: " agnom
checkgroup=$(grep $agnom /etc/group | cut -d ":" -f1)
#Chequea si existe el grupo ingresado
if [ -z $checkgroup ]
then
groupadd $agnom 
echo Grupo creado con exito!!
sleep 1.4 
abmlgrupos
else
echo El grupo ya existe!!
sleep 1.4
abmlgrupos
fi
}

function bgrupo
{
clear
read -p "Ingrese el nombre del grupo que desea eliminar: " bgnom
verificar=$(grep $bgnom /etc/group|cut -d ":" -f1)
#Chequea si existe el grupo ingresado
if [ ! -z $verificar ]
then
#Se verifica que el grupo a eliminar existe
groupdel $bgnom
echo Se ha eliiminado el grupo solicitado.
sleep 1.5
abmlgrupos 
else
echo El grupo que desea eliminar no existe.
sleep 1.4
abmlgrupos
fi

}

function mgrupo
{
clear
read -p "Ingrese nombre del grupo que quiere modificar:" mgnom
comprobar=$(grep $mgnom /etc/group|cut -d ":" -f1)
#Chequea si existe el grupo ingresado
if [ ! -z $comprobar ]
then
#Se verifica que el grupo a modificar existe
read -p "Ingrese el nuevo nombre que se asignará al grupo:" ngnom 
groupmod -n $ngnom $mgnom
echo Nombre cambiado con exito!!
sleep 1.4
abmlgrupos 
else
echo El grupo que desea modificar no existe.
sleep 1.4
abmlgrupos
fi
}

function lgrupo
{
clear
#Lista todos los grupos del sistema
cat /etc/group | cut -d ":" -f1 |more
sleep 1.5
abmlgrupos
}

function abmlgrupos
{
clear
echo --------------------
echo " Bienvenido al menu"
echo -e "  ABML de \e[0;35mGrupos\e[0m"
echo --------------------
echo 1")" Crear Grupo
echo 2")" Eliminar Grupo
echo 3")" Modificar Grupo
echo 4")" Listar Grupo
echo 0")" Salir
echo --------------------
echo ""
read -p "Seleccione una opcion: " opg
case $opg in
1)agrupo;;
2)bgrupo;;
3)mgrupo;;
4)lgrupo;;
0)salir;;
*)echo -e "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 2
abmlgrupos;;
esac
}

#VERIFICA SI EL USUARIO QUE EJECUTO EL SCRIPT ES ROOT
if [ ! $(id -u) = 0 ]
then
clear
echo "Debe ser Superusuario(root) para ejecutar este script"
sleep 1.5
exit
else
abmlgrupos
fi
