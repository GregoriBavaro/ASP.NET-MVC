using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class OrdersDb
    {
        public static List<Orders> Orders = new List<Orders> {
        new Orders()
        {
            Id =1,
            Price = 300,
            RecipientPhoneNumber = 070359569,
            RecipientName = "Greg",
            RecipientAdress = "Ulica Esperanto Br 14a",
            NameOfOrder = "Capri"


        },
        new Orders()
        {
            Id =2,
            Price = 350,
            RecipientPhoneNumber = 070789465,
            RecipientName = "Darko",
            RecipientAdress = "Ulica Forza Milan per Sempre Br 19a",
            NameOfOrder = "Mexicana"

        }
        };
    }
}
