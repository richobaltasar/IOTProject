﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebIOT.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using WebIOT.Function;
using System.Diagnostics;

namespace WebIOT.Controllers
{
    public class HomeController : Controller
    {
        GlobalFunction GF = new GlobalFunction();
        HomeFunction f = new HomeFunction();
        
        private readonly IConfiguration _configuration;
        private IWebHostEnvironment _env;
        public HomeController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            Config.ConStr = _configuration.GetConnectionString("Db");
            
            try
            {
                if (string.IsNullOrEmpty(HttpContext.Session.GetString("_UserId")))
                {
                    var model = new LoginContent();
                    model.Alert = null;
                    return await Task.Run(() => RedirectToAction("SignIn", "Home",model));
                }
                else
                {
                    ViewData["UserId"] = HttpContext.Session.GetString("_UserId");
                    
                    return await Task.Run(() => View());
                }
            }
            catch (Exception ex)
            {
                var Error = new ErrorViewModel();
                Error.MessageContent = ex.ToString();
                Error.MessageTitle = "Error ";
                Error.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
                return await Task.Run(() => View());
            }
        }


        #region LoginPage
        public async Task<IActionResult> SignIn(LoginContent data)
        {
            Config.ConStr = _configuration.GetConnectionString("Db");
            return await Task.Run(() => View(data));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn_proccess([Bind("Username,Password,Platform")] UserLogin data)
        {
            Config.ConStr = _configuration.GetConnectionString("Db");
            var r = new alert();
            try
            {
                if (ModelState.IsValid)
                {
                    r = f.LoginProc(data);
                    if(r.status =="success")
                    {
                        string UserId = f.GetIDUser(data);
                        if(UserId!= "")
                        {
                            HttpContext.Session.SetString("_UserId", UserId);
                        }
                        else
                        {
                            HttpContext.Session.Clear();
                        }

                        return await Task.Run(() => Json(new { isValid = true, message = r.message, title = r.title }));
                    }
                    else
                    {
                        return await Task.Run(() => Json(new { isValid = false, message = r.message, title = r.title }));
                    }
                }
                else
                {
                    return await Task.Run(() => Json(new { isValid = false, message = r.message, title = r.title }));
                }
                
            }
            catch (Exception ex)
            {
                return await Task.Run(() => Json(new { isValid = false, message = "Error Syntax : "+ex.Message, title ="Error"}));
            }


        }

        public async Task<IActionResult> Logout()
        {
            try
            {
                HttpContext.Session.Clear();
                return await Task.Run(() => RedirectToAction("SignIn", "Home"));
            }
            catch (Exception ex)
            {
                var Error = new ErrorViewModel();
                Error.MessageContent = ex.ToString();
                Error.MessageTitle = "Error SignIn Function";
                return await Task.Run(() => RedirectToAction("Error", "Home", Error));
            }
        }
        #endregion



        public async Task<IActionResult> ChatApp()
        {
            return await Task.Run(() => View());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(ErrorViewModel Log)
        {
            return await Task.Run(() => View(Log));
        }
    }
}
