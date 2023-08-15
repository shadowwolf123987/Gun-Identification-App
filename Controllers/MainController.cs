using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gun_Identification_App.Data;
using Newtonsoft.Json.Linq;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Gun_Identification_App.Controllers
{
    public class MainController : Controller
    {
        private readonly DBContext _context;

        public MainController(DBContext context)
        {
            _context = context;
        }

        public IActionResult GunView(string gun) 
        {

            if (gun == "handguns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Handguns.Count()+1);

                try
                {
                    List<int> Ids = ((int[])TempData["ids"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["ids"] = Ids;
                }

                List<int> ids = ((int[])TempData["ids"]).ToList();

                if (ids == null || ids.Count() >= _context.Handguns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["ids"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Handguns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["ids"] = ids;
                }
                

                var name = (from z in _context.Handguns
                           where z.Id == randId
                           select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Handguns
                            where z.Id == randId
                            select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "rifles")
            {
                var random = new Random();
                int randId = random.Next(1, _context.AssaultRifles.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["ids"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["ids"] = Ids;
                }

                List<int> ids = ((int[])TempData["ids"]).ToList();

                if (ids == null || ids.Count() >= _context.AssaultRifles.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["ids"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.AssaultRifles.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["ids"] = ids;
                }


                var name = (from z in _context.AssaultRifles
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.AssaultRifles
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "snipers")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Snipers.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["ids"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["ids"] = Ids;
                }

                List<int> ids = ((int[])TempData["ids"]).ToList();

                if (ids == null || ids.Count() >= _context.Snipers.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["ids"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Snipers.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["ids"] = ids;
                }


                var name = (from z in _context.Snipers
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Snipers
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "machine guns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.MachineGuns.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["ids"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["ids"] = Ids;
                }

                List<int> ids = ((int[])TempData["ids"]).ToList();

                if (ids == null || ids.Count() >= _context.MachineGuns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["ids"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.MachineGuns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["ids"] = ids;
                }


                var name = (from z in _context.MachineGuns
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.MachineGuns
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "shotguns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Shotguns.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["ids"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["ids"] = Ids;
                }

                List<int> ids = ((int[])TempData["ids"]).ToList();

                if (ids == null || ids.Count() >= _context.Shotguns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["ids"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Shotguns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["ids"] = ids;
                }


                var name = (from z in _context.Shotguns
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Shotguns
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            return View();
        }

        public IActionResult GunQuiz(string gun)
        {


            if (gun == "handguns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Handguns.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["idsQ"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    Ids.Add(random.Next(1, _context.Handguns.Count() + 1));
                    TempData["idsQ"] = Ids;
                }

                List<int> ids = ((int[])TempData["idsQ"]).ToList();

                if (ids == null || ids.Count() >= _context.Handguns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Handguns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }


                var name = (from z in _context.Handguns
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Handguns
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "rifles")
            {
                var random = new Random();
                int randId = random.Next(1, _context.AssaultRifles.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["idsQ"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["idsQ"] = Ids;
                }

                List<int> ids = ((int[])TempData["idsQ"]).ToList();

                if (ids == null || ids.Count() >= _context.AssaultRifles.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.AssaultRifles.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }


                var name = (from z in _context.AssaultRifles
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.AssaultRifles
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "snipers")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Snipers.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["idsQ"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["idsQ"] = Ids;
                }

                List<int> ids = ((int[])TempData["idsQ"]).ToList();

                if (ids == null || ids.Count() >= _context.Snipers.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Snipers.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }


                var name = (from z in _context.Snipers
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Snipers
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "machine guns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.MachineGuns.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["idsQ"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["idsQ"] = Ids;
                }

                List<int> ids = ((int[])TempData["idsQ"]).ToList();

                if (ids == null || ids.Count() >= _context.MachineGuns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.MachineGuns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }


                var name = (from z in _context.MachineGuns
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.MachineGuns
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            if (gun == "shotguns")
            {
                var random = new Random();
                int randId = random.Next(1, _context.Shotguns.Count() + 1);

                try
                {
                    List<int> Ids = ((int[])TempData["idsQ"]).ToList();
                }

                catch
                {
                    List<int> Ids = new List<int>();
                    Ids.Add(randId);
                    TempData["idsQ"] = Ids;
                }

                List<int> ids = ((int[])TempData["idsQ"]).ToList();

                if (ids == null || ids.Count() >= _context.Shotguns.Count())
                {
                    ids = new List<int>();
                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }

                else
                {
                    while (ids.Contains(randId))
                    {
                        randId = random.Next(1, _context.Shotguns.Count() + 1);
                    };

                    ids.Add(randId);
                    TempData["idsQ"] = ids;
                }


                var name = (from z in _context.Shotguns
                            where z.Id == randId
                            select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Shotguns
                             where z.Id == randId
                             select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            return View();
        }


    }
}
