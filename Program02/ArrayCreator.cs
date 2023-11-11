/// <summary> // Три слеша автоматически открывают функцию "summary" для комментирования
/// Это класс, отвечающий за создание массива
/// </summary> // Функция будет выводить комментарии о записанных операторах в файле "Program.cs" 
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>Новый массив</returns>
    public static int[] Create(int n)
    {
        return new int[n];
    }
}