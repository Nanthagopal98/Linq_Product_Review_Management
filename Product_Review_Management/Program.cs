using Product_Review_Management;
using System.Collections.Generic;

public class mainClass {
    public static void Main(string[] args)
    {
        Console.WriteLine("Entered");
        List<ProductReviewModel> review = new List<ProductReviewModel>()
        {
            new ProductReviewModel() { ProductId = 101, UserId = 1, Rating = 4.5, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 102, UserId = 2, Rating = 4, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 103, UserId = 3, Rating = 4, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 104, UserId = 4, Rating = 3.5, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 105, UserId = 5, Rating = 1.5, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 101, UserId = 6, Rating = 1, Review = "No Comments", isLike = false },
            new ProductReviewModel() { ProductId = 102, UserId = 7, Rating = 2, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 103, UserId = 8, Rating = 3, Review = "Simply Ok", isLike = false },
            new ProductReviewModel() { ProductId = 104, UserId = 9, Rating = 5, Review = "Excellent", isLike = true },
            new ProductReviewModel() { ProductId = 105, UserId = 10, Rating = 5, Review = "Excellent", isLike = true },
            new ProductReviewModel() { ProductId = 101, UserId = 11, Rating = 4, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 102, UserId = 12, Rating = 3.5, Review = "Average", isLike = false },
            new ProductReviewModel() { ProductId = 103, UserId = 13, Rating = 3, Review = "Simply Ok", isLike = false },
            new ProductReviewModel() { ProductId = 104, UserId = 14, Rating = 4.5, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 105, UserId = 15, Rating = 4, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 101, UserId = 16, Rating = 5, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 102, UserId = 17, Rating = 2, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 103, UserId = 18, Rating = 2.5, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 104, UserId = 19, Rating = 2.5, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 105, UserId = 20, Rating = 3, Review = "Average", isLike = false },
            new ProductReviewModel() { ProductId = 101, UserId = 20, Rating = 3, Review = "Average", isLike = false },
            new ProductReviewModel() { ProductId = 102, UserId = 22, Rating = 2, Review = "Average", isLike = false },
            new ProductReviewModel() { ProductId = 103, UserId = 23, Rating = 2, Review = "Worst", isLike = false },
            new ProductReviewModel() { ProductId = 104, UserId = 24, Rating = 4, Review = "Good", isLike = true },
            new ProductReviewModel() { ProductId = 105, UserId = 25, Rating = 5, Review = "Excellent", isLike = true },
        };
        foreach (var feedBack in review)
        {
            Console.WriteLine("Product ID : " + feedBack.ProductId + " User ID : " + feedBack.UserId + " Rating : " + feedBack.Rating +
                " Review : " + feedBack.Review + " IsLike : " + feedBack.isLike);
        }
    }
}