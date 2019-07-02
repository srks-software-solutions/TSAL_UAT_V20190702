﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using i_facilitylibrary.DAO;
using i_facilitylibrary;

namespace i_facility.Controllers
{
    public class MachineStatusController : Controller
    {
        IConnectionFactory _conn;
        Dao1 obj = new Dao1();
        // GET: /AllMachineStatus/
        public ActionResult Index()
        {
            _conn = new ConnectionFactory();
            obj = new Dao1(_conn);
            if ((Session["UserId"] == null) || (Session["UserId"].ToString() == String.Empty))
            {
                return RedirectToAction("Login", "Login", null);
            }

            Session["colordata"] = null;
            ViewBag.Logout = Session["Username"];
            ViewBag.roleid = Session["RoleID"];

            //calculating Corrected Date
            TimeSpan currentHourMint = new TimeSpan(05, 59, 59);
            TimeSpan RealCurrntHour = System.DateTime.Now.TimeOfDay;
            string CorrectedDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
            if (RealCurrntHour < currentHourMint)
            {
                CorrectedDate = DateTime.Now.AddDays(-1).Date.ToString("yyyy-MM-dd");
            }

            // getting all machine details and their count.
            var macData = obj.GettbMachineDetails();
           // var macData = db.tblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWC == 0);
            int mc = macData.Count();
            ViewBag.macCount = mc;

            int[] macid = new int[mc];
            int macidlooper = 0;
            foreach (var v in macData)
            {
                macid[macidlooper++] = v.MachineID;
            }
            Session["macid"] = macid;
            ViewBag.macCount = mc;

            int[,] maindata = new int[mc, 5];
            //int[,] maindata = new int[mc, 6];
            // write a raw query to get sum of powerOff, Operating, Idle, BreakDown, PlannedMaintenance. 

            using (MsqlConnection mc1 = new MsqlConnection())
            {
                mc1.open();
                SqlCommand cmd1 = new SqlCommand("SELECT MachineID,sum(MachineOffTime) as op,sum(OperatingTime)as o,sum(IdleTime) as it,sum(BreakdownTime)as bt FROM i_facility_tsal.dbo.tblmimics where CorrectedDate='" + CorrectedDate + "'and MachineID IN (select distinct(MachineID) from tblmachinedetails where IsDeleted = 0 and IsNormalWC = 0) group by MachineID", mc1.msqlConnection);
                SqlDataReader datareader = cmd1.ExecuteReader();
                int maindatalooper1 = 0;

                while (datareader.Read())
                {
                    int maindatalooper2 = 0;
                    maindata[maindatalooper1, maindatalooper2++] = datareader.GetInt32(0);
                    maindata[maindatalooper1, maindatalooper2++] = datareader.GetInt32(1);
                    maindata[maindatalooper1, maindatalooper2++] = datareader.GetInt32(2);
                    maindata[maindatalooper1, maindatalooper2++] = datareader.GetInt32(3);
                    maindata[maindatalooper1, maindatalooper2++] = datareader.GetInt32(4);
                    maindatalooper1++;
                }
                mc1.close();
            }
            Session["colordata"] = maindata;
            var tblMainDT = obj.GetdailyprodstatusDetails(CorrectedDate);
            //var tblMainDT = db.tbllivedailyprodstatus.Include(t => t.tblmachinedetail).Where(m => m.CorrectedDate == CorrectedDate).OrderBy(m => m.StartTime);
            return View(tblMainDT.ToList());
        }

    }
}
