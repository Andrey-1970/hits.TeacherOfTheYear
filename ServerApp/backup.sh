#!/bin/bash

# Параметры подключения к базе данных
HOST="db"
PORT="5432"
USER="postgres"
DB="aspnet-ProfessorOfTheYear"
BACKUP_DIR="/backup"
BACKUP_NAME="backup_$(date +'%Y%m%d%H%M%S').sql"

# Выполнение команды pg_dump для создания бекапа
PGPASSWORD="postgres" pg_dump -h $HOST -p $PORT -U $USER $DB > $BACKUP_DIR/$BACKUP_NAME

# Удаление старых бекапов (старше 7 дней)
find $BACKUP_DIR -type f -name "*.sql" -mtime +7 -exec rm {} +

echo "Backup created: $BACKUP_NAME"