using Product_Review_Management;
using System.Data;

ManageReview manage = new ManageReview();
List<ProductReviewModel> review = manage.AddReviews();
var table = manage.ReviewUsingTable();
Console.WriteLine("1 - Add And Display Review \n2 - Get Top Three Reviews \n3 - Sort By Rating Of Products 101,103,105" +
    "\n4 - Get Product Review Count \n5 - Select Specific Column \n6 - Skip Top Five Review \n7 - Add And Display Review Usign DataTable" +
    "\n8 - Sort By Is Like");
int select = Convert.ToInt32(Console.ReadLine());
switch(select)
{
    case 1:
        manage.Display(review);
        break;
    case 2:
        manage.TopThree(review);
        break;
    case 3:
        manage.SortByRating(review);
        break;
    case 4:
        manage.GetCount(review);
        break;
    case 5:
        manage.SelectSpecificColumn(review);
        break;
    case 6:
        manage.SkipTopFive(review);
        break;
    case 7:
        manage.DisplayReviewFromTable(table);
        break;
    case 8:
        manage.SortByIsLike(table);
        break;
    case 9:
        manage.RatingAverage(table);
        break;
}




