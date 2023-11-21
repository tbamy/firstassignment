using Wema.BIT.Models;

namespace Wema.BIT
{
    public class User
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Triangle Area Calculator");

            // Get user input for the base
            Console.Write("Enter the base length of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out double baseLength))
            {
                // Get user input for the height
                Console.Write("Enter the height of the triangle: ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    // Use the CalculateTriangleArea method from CalculateArea class
                    double TheArea = CalculateArea.CalculateTriangleArea(baseLength, height);

                    // Display the result
                    Console.WriteLine($"The area of the triangle is: {TheArea}");
                }
                else
                {
                    Console.WriteLine("Invalid height input. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid base length input. Please enter a valid number.");
            }




            List<Users> users = new List<Users>()
    {
        new Users() { Id = 1, FirstName = "Aluh", LastName = "Johnson", Email = "johnson@gmail.com" },

        new Users() { Id = 2, FirstName = "Tolu", LastName = "Obasun", Email = "toluobasun@gmail.com" },

        new Users() { Id = 3, FirstName = "Tomi", LastName = "Olaoye", Email = "tomiolaoye@gmail.com" },

        new Users() { Id = 4, FirstName = "Joseph", LastName = "Udoka", Email = "josephudoka@gmail.com" },

        new Users() { Id = 5, FirstName = "Esther", LastName = "Gbadamosi", Email = "esthergbadamosi@gmail.com" },
    };

            List<Payment> payments = new List<Payment>()
    {
        new Payment() { Id = 1, UserID = 1, Amount = 2000 },

        new Payment() { Id = 2, UserID = 1, Amount = 5000 },

        new Payment() { Id = 3, UserID = 1, Amount = 3000 },

        new Payment() { Id = 4, UserID = 2, Amount = 1500 },

        new Payment() { Id = 5, UserID = 2, Amount = 2000 },

        new Payment() { Id = 6, UserID = 2, Amount = 7000 },

        new Payment() { Id = 7, UserID = 3, Amount = 5000 },

        new Payment() { Id = 8, UserID = 3, Amount = 8000 },

        new Payment() { Id = 9, UserID = 3, Amount = 1000 },

        new Payment() { Id = 10, UserID = 4, Amount = 5000 },

        new Payment() { Id = 11, UserID = 4, Amount = 6000 },

        new Payment() { Id = 12, UserID = 4, Amount = 6000 },

        new Payment() { Id = 13, UserID = 5, Amount = 4000 },

        new Payment() { Id = 14, UserID = 5, Amount = 3000 },

        new Payment() { Id = 15, UserID = 5, Amount = 7000 },
    };

            for (int i = 0; i < users.Count; i++)
            {
                var pays = payments.Where(x => x.UserID == users[i].Id).ToList();
                Console.WriteLine("Full Details: " + users[i].FirstName + ' ' + users[i].LastName + ' ' + users[i].Email);
                foreach (var payment in pays)
                {
                    Console.WriteLine("Payment ID: " + payment.Id + ' ' + "Amount: " + payment.Amount);
                }
            }
        }

    }
}