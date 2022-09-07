/* Обход разных структур */

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // массив этого дерева
//                 0    1    2     3    4     5    6    7    8    9   10   11
void InOrderTraversal(int pos = 1) // метод, с которого начнем обход, pos - место с которого начнем
{
    if (pos < tree.Length)  // делаем проверку, если позиция дощла до длины дерева, рекурсия закончилась
    {
        int left = 2 * pos; // позиция левой ветки
        int right = 2 * pos + 1;  // позиция правой ветки
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если имеется левой ветки, и не пустой элемент emp, то рекурсивно проделать обход
        Console.WriteLine(tree[pos]); // выводим узел (значение)
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // также правая ветка
    }
}
InOrderTraversal();
