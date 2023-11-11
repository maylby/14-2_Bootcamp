/// <summary> 
/// Это класс, отвечающий за создание массива
/// </summary> 
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