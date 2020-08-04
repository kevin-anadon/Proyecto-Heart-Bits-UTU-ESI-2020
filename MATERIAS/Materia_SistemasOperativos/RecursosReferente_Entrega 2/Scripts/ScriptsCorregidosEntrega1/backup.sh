#!/bin/bash
#Se hace un reload
. $HOME/.bashrc

#Exporto un respaldo de la base de datos, hacia el directorio Backup
mysqldump -u root -pheartbits2002 --database TelediagnosticoMedico_HeartBits > /Telediagnostico/Backup/RespaldoTelediagnostico_v.$CANTBACKUP.sql

#Aumento en 1 la variable de entorno CANTBACKUP
Contador=(expr $CANTBACKUP + 1)
echo "export CANTBACKUP=$Contador >> $HOME/.bashrc
echo La base de datos ha sido respaldado con exito!!
sleep 2 
exit
