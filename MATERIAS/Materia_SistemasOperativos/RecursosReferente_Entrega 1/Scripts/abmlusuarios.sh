#!/bin/bash

function salir
{
clear
echo Volviendo al menu abml...
sleep 1.2
sh abmlmenu.sh
}

function ausuario
{
clear
read -p "Ingrese el nombre del usuario a crear: " nomusu 
checknom=$(grep $nomusu /etc/passwd | cut -d ":" -f1)
#Chequea si existe el usuario ingresado
if [ ! -z "$checknom" ]
then
echo El usuario ya existe!!
sleep 1.4
abmlusuarios 
fi
read -p "Ingrese el nombre del directorio: " dirusu
#Chequea si existe el directorio ingresado
if [ -d /home/$dirusu ]
then
echo El directorio ya existe, use otro nombre!!
sleep 1.4
ausuarios
fi
read -p "Ingrese el nombre del grupo principal al que quiera pertenecer: " groupusu
checkgroup=$(grep $groupusu /etc/group | cut -d ":" -f1)
#Chequea si existe el grupo ingresado
if [ ! -z $checkgroup ]
then
read -p "Ingrese contraseña: " contrausu
useradd -d /home/$dirusu -m -s /bin/bash -g $groupusu --password "$contrausu" $nomusu
echo Usuario creado con exito!!
sleep 1.5
abmlusuario
else 
groupadd $groupusu
read -p "Ingrese contraseña: " contrausu
useradd -d /home/$dirusu -m -s /bin/bash -g $groupusu --password "$contrausu" $nomusu
echo Usuario creado con exito!!
sleep 1.5
abmlusuarios
fi
}

function busuario
{
clear
read -p "Ingrese el nombre del usuario a eliminar: " bnomusu
checkbnom=$(grep $bnomusu /etc/passwd | cut -d ":" -f1)
#Chequea si existe el usuario ingresado
while [ ! -z "$checkbnom" ] 
do
read -p "Desea ademas eliminar el directorio(s/n) " opdir
if [ "$opdir" = "s" ]
then
userdel -fr $bnomusu
echo Usuario y directorio eliminado con exito!!
sleep 1.5
abmlusuarios
elif [ "$opdir" = "n" ]
then
userdel -f $bnomusu
echo Usuario eliminado con exito!!
sleep 1.5
abmlusuarios
fi
done
echo El usuario que desea eliminar no existe!!
sleep 1.5
abmlusuarios
}

function musuario
{
clear
read -p "Ingrese el nombre del usuario a modificar: " mnom
checkmnom=$(grep $mnom /etc/passwd | cut -d ":" -f1)
#Chequea si existe el usuario ingresado
if [ ! -z "$checkmnom" ]
then
clear
echo ------------
echo  Modificar
echo ------------
echo 1")"Nombre
echo 2")"Contraseña
echo 3")"Grupo
echo 4")"Directorio
echo ""
read -p "Seleccione lo que desee modificar: " opmod
case $opmod in

1)clear
read -p "Ingrese el nuevo nombre del usuario: " nuevonom
usermod -l $nuevonom $mnom 
echo Nombre cambiado con exito!!
sleep 1.5
abmlusuarios;;

2)clear
echo "Ingrese la nueva contraseña del usuario"
sleep 1.2
passwd $mnom
echo Contrasena cambiada con exito!!
sleep 1.5
abmlusuarios;; 

3)clear
read -p "Ingrese el nuevo grupo del usuario: " nuevogroup
usermod -g $nuevogroup $mnom
echo Grupo cambiado con exito!!
sleep 1.5
abmlusuarios;; 

4)clear
read -p "Ingrese el nuevo directorio del usuario: " nuevodir
usermod -d /home/$nuevodir -m $mnom
echo Directorio cambiado con exito!!
sleep 1.5
abmlusuarios;;  

*)echo -e "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 1.5
musuario;; 
esac
else
echo El usuario que desea modificar no existe!!
sleep 1.5
abmlusuarios
fi
}

function lusuario
{
clear
#Lista todos los usuarios del sistema
less /etc/passwd | cut -d ":" -f1
sleep 3
abmlusuarios
}

function abmlusuarios
{
clear
echo --------------------
echo " Bienvenido al menu"
echo -e "  ABML de \e[1;34mUsuarios\e[0m"
echo --------------------
echo 1')' Crear Usuario
echo 2')' Eliminar Usuario
echo 3')' Modificar Usuario
echo 4')' Listar Usuario
echo 0')' Salir
echo --------------------
echo ""
read -p "Seleccione una opcion: " opu
case $opu in
1)ausuario;;
2)busuario;;
3)musuario;;
4)lusuario;;
0)salir;;
*)echo -e "\e[1;31mOpcion Incorrecta!!\e[0m"
sleep 2
abmlusuarios;;
esac
}

#VERIFICA SI EL USUARIO QUE EJECUTA EL SCRIPT ES ROOT
if [ ! $(id -u) = 0 ]
then
clear
echo "Debe ser Superusuario(root) para ejecutar este script"
sleep 1.5
exit
else
abmlusuarios
fi
