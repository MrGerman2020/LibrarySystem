# LibrarySystem

Консольное приложение для управления библиотечной системой.

## Архитектура
- **Book**: Модель данных книги (Id, Title, Author, Year).
- **BookRepository**: Работа с базой данных SQLite (создание таблицы, добавление, чтение).
- **LibraryService**: Логика управления книгами (добавление, получение списка).
- **Program**: Консольный интерфейс для взаимодействия с пользователем.

## Диаграммы
- [Диаграмма классов](docs/class-diagram.png)
- [Диаграмма последовательности](docs/sequence-diagram.png)
- [Диаграмма взаимодействия](docs/collaboration-diagram.png)
- [Диаграмма деятельности](docs/activity-diagram.png)
- [Диаграмма пакетов](docs/package-diagram.png)

## Установка и запуск
1. Склонировать: `git clone https://gitlab.com/username/LibrarySystem.git`
2. Установить зависимости: `dotnet add package System.Data.SQLite`
3. Запустить: `dotnet run`
