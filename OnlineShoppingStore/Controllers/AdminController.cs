﻿using OnlineShoppingStore.DAL;
using OnlineShoppingStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class AdminController : Controller
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
            
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Categories()
        {
            List<Tbl_Category> allCategories = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecordsIQueryable().Where(i => i.IsDelete == false).ToList();
            return View(allCategories);
        }
    }
}