using System;

class Program
{
    static void Main(string[] args) {
        int quantityPictureInRow = 3;
        int quantityPictures = 52;
        int quantityFoolRows;
        int quantityOverPictures;

        quantityFoolRows = quantityPictures / quantityPictureInRow;
        quantityOverPictures = quantityPictures % quantityPictureInRow;
        Console.WriteLine($"Количество полных рядов: {quantityFoolRows} остаток {quantityOverPictures}");
    }
}
