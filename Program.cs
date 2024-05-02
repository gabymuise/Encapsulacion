using System;
using Encapsulacion_Consola;
using Encapsulacion.Models;

public class Program
{
    public static void Main()
    {
        StaticPersistence.ProductGenerate("Leche", 2.5);
        StaticPersistence.ProductGenerate("Pan", 1.0);

        
        Product leche = new Product("Leche", 2.5);
        Product pan = new Product("Pan", 1.0);
        Item item1 = StaticPersistence.CreateItem(leche, 2);
        Item item2 = StaticPersistence.CreateItem(pan, 3);

        TaxCalculator calculator = new TaxCalculator();

        Order order = new Order("US");

        order.LineItems.Add(item1);
        order.LineItems.Add(item2);

        order.TaxCalculator = calculator;

        double totalOrderAmount = order.getOrderTotal();

        //Mostramos el pedido completo

        Console.WriteLine("Orden Completa:");
        Console.WriteLine($"País: {order.Country}");
        Console.WriteLine($"Estado: {order.State}");
        Console.WriteLine($"Impuesto: {calculator.GetTaxRate(order.Country, order.State)}");
        Console.WriteLine("Ítems:");
        foreach (var item in order.LineItems)
        {
            Console.WriteLine($"- Producto: {item.Product.Name}, Precio: ${item.Product.Price}, Cantidad: {item.Quantity}");
        }

        Console.WriteLine($"Total de la orden: ${totalOrderAmount:F2}");
    }
}




