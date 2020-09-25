#!/bin/bash

function todos
{
clear
cat /var/log/secure | grep "Failed password" | more
echo ""
echo "Pulse enter para continuar..."
read
menu
}

function usuario
{
clear
read -p "Ingrese el usuario del log fallido que desea ver: " user
checkuser=$(cat /var/log/secure | grep "Failed password" | grep $user)
if [ -z "$checkuser" ]
then
echo ""
echo No hay ningun log con ese usuario
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $user | more
fi
echo ""
echo "Pulse enter para continuar..."
read
sleep 1.4
menu
}

function ip
{
clear
read -p "Ingrese la ip del log fallido que desea ver: " ip
checkip=$(cat /var/log/secure | grep "Failed password" | grep $ip)
if [ -z "$checkip" ]
then
echo ""
echo No hay ningun log con esa ip
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $ip | more
fi
echo ""
echo "Pulse enter para continuar..."
read
menu
}

function fecha
{
clear
echo ------------
echo " FILTROS"
echo ------------
echo "1)" Hora
echo "2)" Dia
echo "3)" Mes
echo "4)" Hora, Mes, Dia
echo "0)" Salir
echo ""
read -p "Seleccione una opcion: " op
while [ $op -ne 0 ]
do
if [ $op -eq 1 ]
then

clear
echo "Ejemplo: 00:00...24:59"
read -p "Ingrese la hora del log fallido que quiera ver: " hora
checkhora=$(cat /var/log/secure | grep "Failed password" | grep $hora)
if [ -z "$checkhora" ]
then
echo ""
echo "No hay ningun log con esa hora"
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $hora | more
echo ""
read -p "Pulse enter para continuar..."
fi
sleep 1.4
fecha

elif [ $op -eq 2 ]
then

clear
echo "Ejemplo: 1,2,3...31"
read -p "Ingrese el dia del log fallido que quiera ver: " dia
checkdia=$(cat /var/log/secure | grep "Failed password" | grep $dia)
if [ -z "$checkdia" ]
then
echo ""
echo "No hay ningun log con esa dia"
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $dia
echo ""
read -p "Pulse enter para continuar..."
fi
sleep 1.4
fecha

elif [ $op -eq 3 ]
then

clear
echo "Ejemplo: Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dic"
read -p "Ingrese el mes del log fallido que quiera ver: " mes
checkdia=$(cat /var/log/secure | grep "Failed password" | grep -i $mes)
if [ -z "$checkdia" ]
then
echo ""
echo "No hay ningun log con esa mes"
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $mes | more
echo ""
read -p "Pulse enter para continuar..."
fi
sleep 1.4
fecha

else

clear
echo "Ejemplo 00:00...24:59"
read -p "Ingrese la hora del log fallido que quiera ver: " hora
checkhora=$(cat /var/log/secure | grep "Failed password" | grep -i $hora)
if [ -z "$checkhora" ]
then
echo ""
echo "No hay ningun log con esa dia"
sleep 1.2
fecha
fi
echo ""
echo "Ejemplo: 1,2,3...31"
read -p "Ingrese el dia del log fallido que quiera ver: " dia
checkmes=$(cat /var/log/secure | grep "Failed password" | grep $dia)
if [ -z "$checkmes" ]
then
echo ""
echo "No hay ningun log con esa dia"
sleep 1.2
fecha
fi
echo ""
echo "Ejemplo: Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dic"
read -p "Ingrese el mes del log fallido que quiera ver: " mes
checkmes=$(cat /var/log/secure | grep "Failed password" | grep -i $mes)
if [ -z "$checkmes" ]
then
echo ""
echo "No hay ningun log con esa mes"
sleep 1.2
fecha
else
echo ""
cat /var/log/secure | grep "Failed password" | grep $hora | grep $dia | grep $mes | more
echo ""
read -p "Pulse enter para continuar..."
fi
sleep 1.4
fecha

fi
done
}

function menu
{
clear
echo -------------
echo -e "\e[1mLOGS\e[0m \e[0;31mFALLIDOS\e[0m"
echo -------------
echo 1")" Fecha				
echo 2")" Usuario
echo 3")" Ip
echo 4")" Todos
echo 0")" Volver	
echo ""
read -p "Seleccione una opcion: " op
case $op in
1)fecha;;
2)usuario;;
3)ip;;
4)todos;;
0)sh menulog.sh;;
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
