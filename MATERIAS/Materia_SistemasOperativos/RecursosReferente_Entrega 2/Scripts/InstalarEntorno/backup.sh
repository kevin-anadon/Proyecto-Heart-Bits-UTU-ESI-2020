#!/bin/bash
#Se hace un reload
. $HOME/.bashrc

#Exporto un respaldo de la base de datos, hacia el directorio Backup
mysqldump -u root -pheartbits2002 --database TelediagnosticoMedico_HeartBits > /Telediagnostico/Backup/RespaldoTelediagnostico_v.$CANTBACKUP.sql

#Aumento en 1 la variable de entorno CANTBACKUP
let Contador=$CANTBACKUP+1
sed -i "/export CANTBACKUP=$CANTBACKUP/d" $HOME/.bashrc
echo "export CANTBACKUP=$Contador" >> $HOME/.bashrc

#Respaldo en segundo disco
rsync -av /Telediagnostico/Backup/ /discos/ppl/Respaldo/
#Respaldo remoto se encuentra en el cliente
#Utilizando un .bat
