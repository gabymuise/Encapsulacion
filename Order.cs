using Encapsulacion.Models;

namespace Encapsulacion_Consola
{
    public class Order
    {
        public TaxCalculator TaxCalculator { get; set; }
        public List<Item> LineItems { get; set; } = new List<Item>();
        public string Country { get; set; }
        public string State { get; set; }

        // Modificar el constructor para recibir solo un argumento
        public Order(string location)
        {
            // Supongamos que el argumento puede ser un país o un estado
            // Si es un país, asignamos el valor a la propiedad Country
            // Si es un estado, asignamos el valor a la propiedad State
            if (location == "US")
            {
                Country = location;
            }
            else
            {
                location = "EU";
                State = location;
            }
        }

        public double getOrderTotal()
        {
            double total = 0;

            foreach (var Item in LineItems)
            {
                total += Item.Product.Price * Item.Quantity;
            }

            if (TaxCalculator != null)
            {
                // Si solo se proporciona el país, asumimos que no hay estado
                string country = Country ?? "";
                string state = State ?? "";
                double taxRate = TaxCalculator.GetTaxRate(country, state);
                total += total * taxRate;
            }
            return total;
        }
    }
}

