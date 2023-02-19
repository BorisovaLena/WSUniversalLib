# **WSUniversalLib**

Данный проект предназначен для подсчета необходимого сырья для производства той или иной продукции и тестировании данного подсчета.

## **Начало работы**

Для начала работы необходимо клонировать проект в Visual Studio или скачать архив и открыть его с помощью Visual Studio.

### **Необходимые условия**

Для установки приложения необходима программа Visual Studio на Вашем компьютере.

### **Установка**

Для установки Вы можете:

1. Клонировать проект в Android Studio:

    * Скопируйте [ссылку на репозиторий](https://github.com/BorisovaLena/WSUniversalLib)
    * Запустите Visual Studio
    * Нажмите на Клонирование репозитория
    * Вставьте ссылку в поле Расположение репозитория
    * Выберите папку на Вашем компьютере, куда нужно сохранить файл
    * Нажмите кнопку Клонировать
    * Можете приступить к работе
 
 2. Скачать архив с приложением:
 
    * На данной странице нажмите на кнопку Code
    * В раскрывающемся списке выберите Download ZIP
    * Перейдите в загрузки на Вашем компьютере и разархивируйте архив
    * В папке найдите файл с расширением .sln и запустите его

## **Работа программы**

Написаны тестовые методы. Один из них:

```
 [TestMethod]
 
public void GetQuantityForProduct_NonExistentProductType() // несуществующий тип продукта 
{
   int width = 10, length = 20, count = 20, productType = 10, materialType = 1;
   double execept = -1;
   Calculation calculation = new Calculation();
   double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
   Assert.AreEqual(execept, actual);
}
```

Результаты тестирования:

![img](https://github.com/BorisovaLena/WSUniversalLib/blob/master/test.png)

## **Автор**

Борисова Лена - [Ссылка на GitHab](https://github.com/BorisovaLena)

 
