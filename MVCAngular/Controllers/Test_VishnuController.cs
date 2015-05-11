using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAngular.Controllers
{
    public class Test_VishnuController : Controller
    {
        //
        // GET: /Test_Vishnu/

        public ActionResult Index()
        {
            string[,] GeoLocation = new string[,] { { "-0.174464", "51.542180" }, { "-0.172925", "51.548507" }, { "-0.178464", "51.556919" }, { "-0.178487", "51.556902" } };
            Random random = new Random();
            int index = new Random().Next(0, GeoLocation.Length - 1);
            string lat = GeoLocation[index, 0];
            string lng = GeoLocation[index, 1];
            //int dim = 1000;
            //string[,] headerImageArray = {
            //                           { "/images/lightboxHeaderLowPrice.jpg", "/hardware/backlit/lightboxLowestPriceGuarantee.asp", "#CCCCCC", "20" },
            //                           { "/images/lightboxHeaderSameDay.jpg", "/hardware/backlit/lightboxSameDayShipping.asp", "#000000", "33" },
            //                           { "/images/EdgeLyteSeriesHeader.jpg", "showEdgeLyte()", "#FFFFFF", "47"},
                                      
            //                         };
            //List<string> iList = new List<string>();
            //Random random = new Random();
            //int values = headerImageArray.GetLength(1);
            //int v = values - 1;
            //int i1 = random.Next(v);


            //for (int c = 0; c < values; c++)
            //{
            //    string value = headerImageArray[i1, c];
            //    iList.Add(value);
            //}

            //Random rand = new Random();
            //foreach (string value in headerImageArray)
            //{
            //    int row = rand.Next(0, 4);
            //    int col = rand.Next(0, 4);
            //    if (headerImageArray[row, col] == ".")
            //    {
            //        headerImageArray[row, col] = value;
            //    }
            //}

            //for (int r = 0; r < dim; r++)
            //{
            //    for (int c = 0; c < 4; c++)
            //    {
            //        headerImageArray[r, c] = (random.Next(dim).ToString()); // fill it with random numbers.
            //    }
            //}


            //int values = headerImageArray.GetLength(0) * headerImageArray.GetLength(1);
            //int index = random.Next(values);
            //var list= headerImageArray[index / headerImageArray.GetLength(0), index % headerImageArray.GetLength(0)];
            return View();
        }
        public ActionResult AddNewTest_Vishnu()
        {
            return PartialView("AddTest_Vishnu");
        }

        public ActionResult ShowTest_Vishnu()
        {
            return PartialView("ShowTest_Vishnu");
        }

        public ActionResult EditTest_Vishnu()
        {
            return PartialView("EditTest_Vishnu");
        }

        public ActionResult DeleteTest_Vishnu()
        {
            return PartialView("DeleteTest_Vishnu");
        }


    }
}
