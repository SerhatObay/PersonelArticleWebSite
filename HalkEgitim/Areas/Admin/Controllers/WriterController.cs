﻿using HalkEgitim.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalkEgitim.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.ID == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);

        }
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.ID == id);
            writers.Remove(writer);
            return Json(writer);
        }
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.ID == w.ID);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                ID=1,
                Name="Serhat"
            },
             new WriterClass
            {
                ID=2,
                Name="Burak"
            },
            new WriterClass
            {
                ID=3,
                Name="Murat"
            }
            
        };
    }
}
