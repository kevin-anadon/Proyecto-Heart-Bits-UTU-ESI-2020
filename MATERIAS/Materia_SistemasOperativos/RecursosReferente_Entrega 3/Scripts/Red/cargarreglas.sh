#!/bin/bash

function cargar
{
## FLUSH de reglas
iptables -F
iptables -X
iptables -Z
iptables -t nat -F
## Establecemos politica por defecto
iptables -P INPUT ACCEPT
iptables -P OUTPUT ACCEPT
iptables -P FORWARD ACCEPT
iptables -P OUTPUT ACCEPT
iptables -t nat -P PREROUTING ACCEPT
iptables -t nat -P POSTROUTING ACCEPT
## Empezamos a filtrar
# El localhost se deja (por ejemplo conexiones locales a mysql)
/sbin/iptables -A INPUT -i lo -j ACCEPT
# A nuestra IP le dejamos todo
iptables -A INPUT -s 192.168.0.0 -j ACCEPT
# A un colega le dejamos entrar al mysql para que mantenga la BBDD
iptables -A INPUT -s 192.168.1.0 -p tcp --dport 3306 -j ACCEPT
# A un colega le dejamos usar el FTP
iptables -A INPUT -s 192.168.1.0 -p tcp --dport 20:21 -j ACCEPT
# A un colega le dejamos usar el SSH
iptables -A INPUT -s 192.168.1.0 -p tcp --dport 2222 -j ACCEPT
# A un colega le dejamos usar el PROXY
iptables -A INPUT -s 192.168.1.0 -p tcp --dport 3128 -j ACCEPT
# Deshabilitamos las peticiones icmp, para evitar posibles ataques DDOS
iptables -A INPUT -p icmp -j DROP
# Cerramos rango de los puertos privilegiados. Cuidado con este tipo de
# barreras, antes hay que abrir a los que si tienen acceso.
iptables -A INPUT -p tcp --dport 1:1024
iptables -A INPUT -p udp --dport 1:1024
# Cerramos otros puertos que estan abiertos
iptables -A INPUT -p tcp --dport 80 -j DROP
iptables -A INPUT -p tcp --dport 22 -j DROP
iptables -A INPUT -p tcp --dport 3306 -j DROP
iptables -A INPUT -p tcp --dport 10000 -j DROP
iptables -A INPUT -p udp --dport 10000 -j DROP
}

#VERIFICA SI EL USUARIO QUE EJECUTA EL SCRIPT ES ROOT
if [ ! $(id -u) = 0 ]
then
clear
echo "Debes ser Superususario(root) para ejecutar el script"
sleep 1.5
exit
else
#En caso de serlo ejecuta la función cargar
cargar
fi
