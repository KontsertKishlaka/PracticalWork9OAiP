![image](https://github.com/user-attachments/assets/3dfd8cff-2bf3-4bd2-9176-c3d6e1b68c79)

# **Отчёт**

**Лабораторная работа №9**

- **Тема**: Конструкция try-catch-finally.
- **Выполнил**: Бедин Владислав Алексеевич.
---
1.	Я ознакомился с теоретическими сведениями и изучил принципы и использование конструкции try-catch-finally в языке программирования C#.
2.	Выполнил практические задания 1, 2.
---
Класс Program
![image](https://github.com/user-attachments/assets/34a755b2-8fe3-4861-8a9c-6ec81849f1e1)
![image](https://github.com/user-attachments/assets/a2da0b92-7b30-4616-b457-6dcc6515c72f)

# Ответы на контрольные вопросы

1. **Что такое исключение в C#?**

Исключение – это событие, которое происходит во время выполнения программы, нарушая ее нормальный ход. Обычно оно возникает из-за ошибок, таких как деление на ноль, попытка доступа к не существующему файлу или неверный формат данных.

2. **Как работают ключевые слова `try`, `catch`, `finally`, и `throw`?**

• `try`: Блок кода, который может вызвать исключение. 
• `catch`: Блок кода, который перехватывает и обрабатывает исключение, возникающее в блоке try. 
• `finally`: Блок кода, который всегда выполняется после блока try, независимо от того, произошло исключение или нет. Используется для освобождения ресурсов (закрытие файлов, освобождение памяти).
• `throw`: Ключевое слово, которое используется для генерации исключения.

3. **В чем отличие между исключениями `DivideByZeroException` и `FormatException`?**

• `DivideByZeroException`: Возникает при попытке деления на ноль.
• `FormatException`: Возникает при попытке преобразования строки в числовой тип данных, но строка содержит неверный формат.

4. **Как создать пользовательское исключение в C#?**

Для создания пользовательского исключения нужно наследовать класс Exception или один из его производных классов.

5. **Что делает блок `finally` и когда он выполняется?**

Блок finally гарантирует, что определенный код будет выполнен, независимо от того, произошло исключение в блоке try или нет. Он используется для освобождения ресурсов, таких как закрытие файлов, освобождение памяти, подключений к базе данных и т.д.

6. **Можно ли перехватить несколько типов исключений в одном блоке `try`?**

Да, можно перехватить несколько типов исключений в одном блоке try с помощью нескольких блоков catch.
Блоки catch обрабатываются последовательно. Если исключение совпадает с типом исключения в блоке catch, он выполнится.

# Вывод
В ходе выполнения данных заданий я изучил важную конструкцию обработки исключений – `try-catch-finally`: её синтаксис и применение в языке программирования C#.
