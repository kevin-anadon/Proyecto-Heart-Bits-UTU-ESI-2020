#!/bin/bash

function salir
{
clear
echo Gracias por utilizar nuestro programa
sleep 1.2
clear
exit
}

function menu
{
clear
echo --------------------------
echo -e "\e[1m INSTALACION DE SERVICIOS\e[0m"
echo --------------------------
echo 1")" MYSQL"("Mariadb")"				
echo 2")" FTP
echo 3")" SSH
echo 4")" NET-TOOLS
echo 5")" HTOP
echo 0")" Salir	
echo ""
read -p "Seleccione una opcion: " op
case $op in
1)yum -y install mariadb-server
menu;;
2)yum -y install vsftpd
menu;;
3)yum -y install openssh-server
menu;;
4)yum -y install net-tools
menu;;
5)yum -y install htop
menu;;
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
