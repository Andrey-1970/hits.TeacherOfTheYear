# Руководство по развертыванию приложения

  Добро пожаловать в hits.TeacherOfTheYear! Это руководство поможет вам развернуть приложение на вашем локальном или удаленном сервере.
  
  ## Предпосылки
  
  Перед началом развертывания убедитесь, что у вас установлены следующие программные компоненты:
  
  - Git
  - Docker
  
  ## Развертывание на сервере ТИУ
  
  ### Клонирование репозитория
  
  1. Для начала склонируйте репозиторий на ваш удаленный сервер и перейдите в него
     ```
      git clone https://github.com/Andrey-1970/hits.TeacherOfTheYear.git
      cd hits.TeacherOfTheYear
     ```
  
  2. Переключитесь на ветку ProdV1-03-09-2024
     ```
       git fetch
       git checkout ProdV1-03-09-2024
     ```
  3. Обновите ветку
     ```
      git pull origin ProdV1-03-09-2024
     ```
  
  ### Настройка переменных окружения
  
  Создайте файл .env в папке ServerApp и заполните соответствующие переменные
  ```
  MailSettings__FromEmail=
  MailSettings__Host=
  MailSettings__Port=
  ```
  
  Все данные узнаются в департаменте цифровизации ТИУ
  
  ## Развертывание на локальном компьютере или собственном сервере
  
  ### Клонирование репозитория
  
  1. Для начала склонируйте репозиторий на ваш удаленный сервер и перейдите в него
     ```
      git clone https://github.com/Andrey-1970/hits.TeacherOfTheYear.git
      cd hits.TeacherOfTheYear
     ```
  
  2. Переключитесь на ветку LocalDeploy
     ```
       git fetch
       git checkout LocalDeploy
     ```
  3. Обновите ветку
     ```
      git pull origin LocalDeploy
     ```
  
  ### Настройка переменных окружения
  
  Создайте файл .env в папке ServerApp и заполните соответствующие переменные
  ```
  MailSettings__FromEmail=
  MailSettings__Host=
  MailSettings__Port=
  MailSettings__Username=
  MailSettings__Password=
  ```
  
  Есть несколько вариантов для реализации почтового сервиса, предложу один из многих: https://seatable.io/ru/docs/integrationen-innerhalb-von-seatable/gmail-fuer-den-versand-von-e-mails-per-smtp-einrichten/
  
  ### Запуск приложения
  ```
  docker compose up --build
  ```
  
  💡 **PS:** При локальном развертывании приложение будет доступно по адресу http://localhost

# Выдача роли "Админ" после развертывания

## Сперва зайти на сайт и зарегестрироваться

## После регистрации вручную присвоим роль "Админ" пользователю

1. Входим в докер контейнер postgres
   ```
   docker exec -it hitsteacheroftheyear-db-1 psql -U postgres
   ```
2. Переключаемся на нужную базу данных
   ```
   \c "aspnet-ProfessorOfTheYear";
   ```
3. Получаем Id пользователя
   ```
   select "Id" from "AspNetUsers" where "Email" = '<почта_пользователя>';
   ```
4. Получаем Id роли "Админ"
   ```
   select "Id" from "AspNetRoles" where "Name" = 'Admin';
   ```
5. Присваиваем роль "Админ" пользователю
   ```
   insert into AspNetUserRoles values ('<id_user>, <id_role>);
   ```
💡 **PS:** Если на сайте не отображается роль Админа, то необходимо перезайти в аккаунт
