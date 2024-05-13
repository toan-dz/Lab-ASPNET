﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeXuanToan_Lab_5.Controllers
{
    public class LxtCustomerController : Controller
    {
        // GET: LxtCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerDetail()
        {
            Customer cus = new Customer()
            {
                CustomerId = "2210900069",
                FullName = "Lê Xuân Toàn",
                Address = "Hải Phòng",
                Email = "ltoan5861@gmail.com",
                Phone = "0842.806.904",
                Balance = 0
            };
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            //tạo một danh sách khách hàng
            List<Customer> listcustomer = new List<Customer>(){
            new Customer(){ CustomerId = "2210900069",
            FullName = "Lê Xuân Toàn",
            Address = "Hải Phòng",Email = "ltoan5861@gmail.com",
            Phone = "0842.806.904",Balance = 0},
            new Customer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
            Address = "Hà Nội",Email = "cucdt@gmail.com",
            Phone = "0986.767.444",Balance = 2200000},
            new Customer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",
            Address = "Nam Định",Email = "thangnt@gmail.com",
            Phone = "0924.656.542",Balance = 1200000},
            new Customer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
            Address = "Hà Nội",Email = "hailn@gmail.com",
            Phone = "0996.555.267",Balance = 6200000 }
            };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}