﻿using Product_Review_Management;

ManageReview manage = new ManageReview();
List<ProductReviewModel> review = manage.AddReviews();
Console.WriteLine("1 - Add And Display Review \n2 - Get Top Three Reviews \n3 - Sort By Rating Of Products 101,103,105");
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


}



