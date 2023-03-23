## Контрольное задание

**Задание**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры результатов работы программы**

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]


**Алгоритм решения**
1. Первоначально создаем два строчных массива. Первый задаем, второй определяем такой же длины, как и первый.
2. Используем метод NewArray, с помощью которого вычисляем количество строк, с количеством символов меньше или равно 3.
Инициализируем переменную count, в которую будем записывать количество строк, подходящее под условие. 
3. Далее с помощью цикла for проходим по каждой строке массива.
Если строка подходит под условие, увеличиваем count и увеличиваем i. Если не подходит, то увеличиваем только счетчик i.
4. Далее используем метод PrintArray для второго массива. Данный метод позволит нам вывести результаты в терминал.

