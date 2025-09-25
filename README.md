# LibrarySystem

Консольное приложение для управления библиотечной системой.

## Архитектура
- **Book**: Модель книги (Id, Title, Author, Year).
- **BookRepository**: Работа с базой данных SQLite.
- **LibraryService**: Логика управления книгами.
- **Program**: Консольный интерфейс.

## Диаграммы
- [Диаграмма классов](docs/class-diagram.png)
- [Диаграмма последовательности](docs/sequence-diagram.png)

## Установка и запуск
1. Склонировать: `git clone https://gitlab.com/username/LibrarySystem.git`
2. Установить зависимости: `dotnet add package System.Data.SQLite`
3. Запустить: `dotnet run`
