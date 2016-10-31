//
//Controller to choose the mission

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        

        // GET: Default
        public ActionResult Mission()
        {
            return View();
        }

        //If statement for the 3 different missions and their viewbags
        public ActionResult MissionFAQ (string MissNumber)
        {
            ViewBag.Mission_Name = MissNumber;
            if (MissNumber == "1")
            {
                ViewBag.MissionName = "Milwaukee, Wisconsin";
                ViewBag.PresidentPic = "/Content/Pictures/Milwaukee/Cutler.jpeg";
                ViewBag.President = "President:  Raymond Cutler";
                ViewBag.Wife = "President's Wife: Sister Lorie Cutler";
                ViewBag.Winter = "Winter: Snow, Freezing";
                ViewBag.Summer = "Summer: Hot and Humid";
                ViewBag.Language = "English, Spanish, Hmong";
                ViewBag.City = "Greenfield, WI";
                ViewBag.Street = "7111 W. Edgerton Ave Ste.100";
                ViewBag.Country = "United States";
                ViewBag.Flag = "/Content/Pictures/Milwaukee/Wisconsin_flag.jpg";
                ViewBag.Religion = "Catholic and Lutheran";
                ViewBag.Pic1 = "/Content/Pictures/Milwaukee/Wisconsin_1.jpg";
                ViewBag.Pic2 = "/Content/Pictures/Milwaukee/Wisconsin_2.jpg";
                ViewBag.Pic3 = "/Content/Pictures/Milwaukee/Wisconsin_3.jpg";
                ViewBag.Pic4 = "/Content/Pictures/Milwaukee/Wisconsin_4.jpg";
                ViewBag.Source = "https://www.google.com/maps/embed/v1/place?q=place_id:ChIJr-OEkw_0qFIR1kmG-LjV1fI&key=AIzaSyDHkSckF7J0xgBlozb1AKVqMz5WdbbHFRk";
               
              

            }


            else if (MissNumber == "2")
            {
                ViewBag.MissionName = "Cusco, Peru";
                ViewBag.PresidentPic = "/Content/Pictures/Peru/perupres.jpg";
                ViewBag.President = "President: Coolio";
                ViewBag.Wife = "President's Wife: Sister Coolio";
                ViewBag.Winter = "Winters: Chilly, rare snow";
                ViewBag.Summer = "Summers: Humid, Extremely Hot, Rainy";
                ViewBag.Language = "Spanish";
                ViewBag.Street = "Avenida la cultura 2417";
                ViewBag.City = "Al frente de la urbanizacion santa ursula capilla mormona";
                ViewBag.Country = "Peru";
                ViewBag.Flag = "/Content/Pictures/Peru/peruflag.GIF";
                ViewBag.Religion = "Catholic";
                ViewBag.Pic1 = "/Content/Pictures/Peru/Peru1.jpeg";
                ViewBag.Pic2 = "/Content/Pictures/Peru/peru2.jpeg";
                ViewBag.Pic3 = "/Content/Pictures/Peru/peru3.jpg";
                ViewBag.Pic4 = "/Content/Pictures/Peru/peru4.jpg";
                ViewBag.Source = "https://www.google.com/maps/embed/v1/place?q=place_id:ChIJMYRZJtjVbZERXTEYI8yWqSo&key=AIzaSyDHkSckF7J0xgBlozb1AKVqMz5WdbbHFRk";
            }
            else
            {
                ViewBag.MissionName = "Sydney South, Australia";
                ViewBag.PresidentPic = "/Content/Pictures/Australia/back.jpeg";
                ViewBag.President = "President: Daryl Back";
                ViewBag.Wife = "President's Wife: Sister MaryAnne Back";
                ViewBag.Winter = "Winters: Chilly, rare snow";
                ViewBag.Summer = "Summers: Humid, Extremely Hot, Rainy";
                ViewBag.Language = "English, Samoan, Tongan, Spanish, Mandarian, Cantonese";
                ViewBag.Street = "PO Box 456";
                ViewBag.City = "Mortdale NSW 2223";
                ViewBag.Country = "Australia";
                ViewBag.Flag = "/Content/Pictures/Australia/AustraliaFlad.png";
                ViewBag.Religion = "Athiest";
                ViewBag.Pic1 = "/Content/Pictures/Australia/sydney1.jpg";
                ViewBag.Pic2 = "/Content/Pictures/Australia/sydney2.jpg";
                ViewBag.Pic3 = "/Content/Pictures/Australia/sydney3.jpg";
                ViewBag.Pic4 = "/Content/Pictures/Australia/sydney4.jpg";
                ViewBag.Source = "https://www.google.com/maps/embed/v1/place?q=place_id:ChIJP5iLHkCuEmsRwMwyFmh9AQU&key=AIzaSyDHkSckF7J0xgBlozb1AKVqMz5WdbbHFRk";
            }
            return View();
        }
    }

  
}