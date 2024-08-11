namespace CSharp_HW_modul_14_part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FractionCollection fractionCollection = new FractionCollection();
            fractionCollection.Add(new Fraction(1, 2), new Fraction(1, 3));
            FractionManager.XmlSerialize(fractionCollection);
        }
    }
}

//Задание 1:
//Создайте программу для работы с массивом дробей (числитель и знаменатель). Она должна иметь такую функциональность:
//1.Ввод массива дробей с клавиатуры
//2. Сериализация массива дробей
//3. Сохранение сериализованного массива в файл
//4. Загрузка сериализованного массива из файла. После загрузки нужно произвести десериализацию
//Выбор конкретного формата сериализации необходимо сделать вам. Обращаем ваше внимание, что выбор должен быть обоснованным.