// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
// Bir nesne bir işlemi yaparken, algoritmasının değişme ihtimali varsa; bu değişikliği nasıl yönetirsiniz?

ProductCollection productCollection = new ProductCollection();
productCollection.Sort(new BubbleSort());
productCollection.Sort(new HeapSort());
