using Falcons.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatBookingController : ControllerBase
    {
        FalconsDBContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public SeatBookingController(IWebHostEnvironment hostingEnvironment, FalconsDBContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: api/<SeatBookingController>
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("Hello World!");
        }
        [HttpPost]
        public IActionResult PostCheckoutMovieSeats(List<SelectedSeat> selectedSeats)
        {
            BookedSeat bookedSeat;

            string webRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            string filePath = webRootPath + "/SelectedSeatsRpt.json";

            List<JObject> SelectedSeatsReport = new List<JObject>();
            foreach (SelectedSeat ss in selectedSeats)
            {
                SelectedSeatsReport.Add(new JObject(
                    new JProperty("SeatID", ss.SeatID),
                    new JProperty("SeatPrice", ss.SeatPrice)
                    ));

                bookedSeat = new BookedSeat();
                bookedSeat.SeatID = ss.SeatID;
                _context.BookedSeats.Add(bookedSeat);
            }

            _context.SaveChanges();

            // write JSON directly to a file

            using (StreamWriter file = System.IO.File.CreateText(filePath))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                file.WriteLine("[");
                int i = 0;
                foreach (JObject jo in SelectedSeatsReport)
                {
                    jo.WriteTo(writer);
                    if (i < SelectedSeatsReport.Count - 1)
                    {
                        file.WriteLine(",");
                        i++;
                    }
                }
                file.WriteLine("]");
            }

            var _ReturnedValue = selectedSeats != null ? "ok" : "failed";

            return new JsonResult(_ReturnedValue);

        }
    }

}
