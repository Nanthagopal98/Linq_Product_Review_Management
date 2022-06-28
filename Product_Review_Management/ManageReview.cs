using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class ManageReview
    {
        public List<ProductReviewModel> AddReviews()
        {
            List<ProductReviewModel> review = new List<ProductReviewModel>() {
            new ProductReviewModel() { ProductId = 101, UserId = 1, Rating = 4, Review = "Good", isLike = true },
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
            new ProductReviewModel() { ProductId = 105, UserId = 25, Rating = 5, Review = "Excellent", isLike = true } 
            };      
            
            return review;
        }
        public void Display(List<ProductReviewModel> review)
        {
            foreach (var feedBack in review)
            {
                Console.WriteLine("Product ID : " + feedBack.ProductId + " User ID : " + feedBack.UserId + " Rating : " + feedBack.Rating +
                    " Review : " + feedBack.Review + " IsLike : " + feedBack.isLike);
            }
        }
        public void TopThree(List<ProductReviewModel> review)
        {
            var topThree = (from ProductReviewModel in review orderby ProductReviewModel.Rating descending select ProductReviewModel).Take(3);
            Console.WriteLine("Top Three Reviews Are");
            foreach (var top in topThree)
            {               
                Console.WriteLine("Product ID : " + top.ProductId + " User ID : " + top.UserId + " Rating : " + top.Rating +
                    " Review : " + top.Review + " IsLike : " + top.isLike);
            }
        }
        public void SortByRating(List<ProductReviewModel> review)
        {
            var sort = from ProductReviewModel in review where ((ProductReviewModel.Rating > 3 && ProductReviewModel.ProductId == 101) || (ProductReviewModel.Rating > 3 && ProductReviewModel.ProductId == 103) ||
                       (ProductReviewModel.Rating > 3 && ProductReviewModel.ProductId == 105)) select ProductReviewModel;
            foreach(var sorting in sort)
            {
                Console.WriteLine("Product ID : " + sorting.ProductId + " User ID : " + sorting.UserId + " Rating : " + sorting.Rating +
                       " Review : " + sorting.Review + " IsLike : " + sorting.isLike);
            }
        }
        public void GetCount(List<ProductReviewModel> review)
        {
            var reviewCount = review.GroupBy(x => x.ProductId).Select( x => new { ProductId = x.Key, count = x.Count() });
            foreach(var count in reviewCount)
            {
                Console.WriteLine("Product ID : " + count.ProductId + " Count : " + count.count);
            }
        }
        public void SelectSpecificColumn(List<ProductReviewModel> review)
        {
            //var list = from ProductReviewModel in review select (ProductReviewModel.ProductId, ProductReviewModel.Rating);
            var list = review.Select(x => (x.ProductId, x.Rating));
            foreach (var products in list)
            {
                Console.WriteLine("Product ID : " + products.ProductId + " Rating : " + products.Rating );
            }
        }
        public void SkipTopFive(List<ProductReviewModel> review)
        {
            var list = (from ProductReviewModel in review select ProductReviewModel).Skip(5);
            foreach (var skip in list)
            {
                Console.WriteLine("Product ID : " + skip.ProductId + " User ID : " + skip.UserId + " Rating : " + skip.Rating +
                    " Review : " + skip.Review + " IsLike : " + skip.isLike);
            }
        }
        public DataTable ReviewUsingTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Product ID",typeof(int));
            table.Columns.Add("User ID",typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            table.Rows.Add(101, 1, 4, "Good", true);
            table.Rows.Add(102, 2, 5, "Excellent", true);
            table.Rows.Add(103, 3, 4.5, "Good", true);
            table.Rows.Add(104, 4, 3.5, "Good", true);
            table.Rows.Add(105, 5, 2, "Worst", false);
            table.Rows.Add(105, 6, 1, "Worst", false);
            table.Rows.Add(103, 7, 1, "Worst", false);
            table.Rows.Add(104, 8, 2.5, "Average", false);
            table.Rows.Add(101, 9, 1.5, "Worst", false);
            table.Rows.Add(102, 10, 3.5, "Average", true);
            table.Rows.Add(105, 11, 5, "Good", true);
            table.Rows.Add(103, 12, 4.5, "Good", true);
            table.Rows.Add(104, 13, 3, "Average", true);
            table.Rows.Add(102, 14, 3, "Good", true);
            table.Rows.Add(103, 15, 1, "Worst", false);
            table.Rows.Add(102, 16, 2, "Average", false);
            table.Rows.Add(105, 17, 2.5, "Average", false);
            table.Rows.Add(103, 18, 5, "Good", true);
            table.Rows.Add(105, 19, 4, "Good", true);
            table.Rows.Add(103, 20, 4, "Good", true);
            table.Rows.Add(102, 21, 4, "Good", true);
            table.Rows.Add(102, 22, 5, "Good", true);
            table.Rows.Add(102, 23, 5, "Good", true);
            table.Rows.Add(104, 24, 2, "Average", false);
            table.Rows.Add(103, 25, 3, "Average", false);           
            return table;
        }
        public void DisplayReviewFromTable(DataTable table)
        {
            IEnumerable<DataRow> list = from dataTable in table.AsEnumerable() select dataTable;
            foreach (var items in list)
            {
                Console.WriteLine("Produce ID : "+items.Field<int>("Product ID")+ " User ID : "+ items.Field<int>("User ID")+
                    " Rating : "+ items.Field<double>("Rating")+" Review : "+ items.Field<string>("Review")+" IsLike : "+ items.Field<bool>("IsLike"));
            }
        }
        public void SortByIsLike(DataTable table)
        {
            var list = from dataTable in table.AsEnumerable() where dataTable.Field<bool>("IsLike") == true select dataTable;
            foreach (var items in list)
            {
                Console.WriteLine("Produce ID : " + items.Field<int>("Product ID") + " User ID : " + items.Field<int>("User ID") +
                    " Rating : " + items.Field<double>("Rating") + " Review : " + items.Field<string>("Review") + " IsLike : " + items.Field<bool>("IsLike"));
            }
        }
        public void RatingAverage(DataTable table)
        {            
            var list = table.AsEnumerable().GroupBy(x => x.Field<int>("Product ID")).Select(x => new { ProductID = x.Key, average = x.Average(y => (y.Field<double>("Rating"))) });
            foreach (var items in list)
            {
                Console.WriteLine("Product ID : " + items.ProductID + " Count : "+ items.average);
            }                     
        }
        public void SortByReview(DataTable table)
        {
            var list = from dataTable in table.AsEnumerable() where dataTable.Field<string>("Review") == "Good" select dataTable;
            foreach(var items in list)
            {
                Console.WriteLine("Produce ID : " + items.Field<int>("Product ID") + " User ID : " + items.Field<int>("User ID") +
                    " Rating : " + items.Field<double>("Rating") + " Review : " + items.Field<string>("Review") + " IsLike : " + items.Field<bool>("IsLike"));
            }
        }
    }
}
