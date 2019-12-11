using System;
using System.Linq;

namespace Sho.Dojo.Katas
{
    public class NewCashierDoesNotKnowAboutSpaceOrShift
    {
        private static readonly string[] menu = new string[]
        {
            "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"
        };

        public static string GetOrder(string input)
        {
            Array.ForEach(menu, item => input = input.Replace(item.ToLower(), $" {item}"));
            string[] items = input.Trim().Split(" ");
            var orderedItems = items.OrderBy(item => Array.IndexOf(menu, item));

            return string.Join(" ", orderedItems);
        }

        //public static string GetOrder(string input)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var item in menu)
        //    {
        //        int index = input.IndexOf(item.ToLower());

        //        while (index != -1)
        //        {
        //            sb.Append(item + " ");
        //            index = input.IndexOf(item.ToLower(), index + item.Length);
        //        }
        //    }

        //    return sb.ToString().Trim();
        //}
    }
}

/* New Cashier Does Not Know About Space or Shift
Some new cashiers started to work at your restaurant.
They are good at taking orders, but they don't know how to capitalize words, or use a space bar!
All the orders they create look something like this:
"milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"
The kitchen staff are threatening to quit, because of how difficult it is to read the orders.
Their preference is to get the orders as a nice clean string with spaces and capitals like so:
"Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
The kitchen staff expect the items to be in the same order as they appear in the menu.
The menu items are fairly simple, there is no overlap in the names of the items:
1. Burger
2. Fries
3. Chicken
4. Pizza
5. Sandwich
6. Onionrings
7. Milkshake
8. Coke
*/
