
using i_facilitylibrary;
using i_facilitylibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_facilitylibrary.DAO
{
   public class ReportsDao
    {
        
        IConnectionFactory _connectionFactory;
        public ReportsDao()
        {

        }
        public ReportsDao(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public List<tblmachinedetail> GettbMachineDetails(int plantId)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0  and PlantID = "+plantId+" ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> Getplant2List1(int MachineID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and MachineID = " + MachineID + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GettbMachineDetails1(int ShopId)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0  and ShopId = "+ ShopId + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GettbMachineDetails2(int CellId)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0  and CellId = "+ CellId + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GettbMachineDetails3(int MachineID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblmachinedetails WHERE ManualWCID = "+MachineID+" and IsDeleted == 0 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<int> GetmachineListforoee(int PlantID)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and PlantID =" + PlantID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            
            return macList;
        }
        public List<int> GetmachineListforoee1(int plantId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and PlantID ="+plantId+" and IsNormalWC = 1 and ManualWCID != null";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det= lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }
        public List<int> GetmachineShopListfor(int shopId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and ShopID =" + shopId + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det= lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }
        public List<int> GetmachineShopListfor1(int shopId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and ShopID =" + shopId + " and IsNormalWC = 1 and ManualWCID != null";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det= lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }
        public List<int> GetmachineCellListfor(int cellId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and CellID =" + cellId + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }
        public List<int> GetmachineCellListfor1(int cellId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and CellID =" + cellId + " and IsNormalWC = 1 and ManualWCID != null";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }
        public List<int> GetmachineListfor1(int wcId)
        {
            List<int> macList = new List<int>();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted == 0 && m.IsNormalWC = 1 and ManualWCID = "+wcId+"";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var item in det)
                {
                    macList.Add(item.MachineID);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return macList;
        }

        public List<tbl_multiwoselection> Gettbl_multiwoselectionfor1(int hmiid)
        {
            Repository<tbl_multiwoselection> lista = new Repository<tbl_multiwoselection>();
            List<tbl_multiwoselection> det = new List<tbl_multiwoselection>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_multiwoselection WHERE HMIID =" + hmiid + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmasterparts_st_sw> Gettblmasterparts_st_swDet4(string opno,string partno)
        {
            Repository<tblmasterparts_st_sw> lista = new Repository<tblmasterparts_st_sw>();
            List<tblmasterparts_st_sw> det = new List<tblmasterparts_st_sw>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE IsDeleted = 0 and OpNo ='" + opno + "' and PartNo ='" + partno + "' ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbldaytiming> GetttbldaytimingsDet4()
        {
            Repository<tbldaytiming> lista = new Repository<tbldaytiming>();
            List<tbldaytiming> det = new List<tbldaytiming>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbldaytiming WHERE IsDeleted = 0 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tbl_multiwoselection GetmultiselectionDet3(int HmiID, string PartNoS,string WorkOrderNoS,string OpNoS)
        {
            tbl_multiwoselection ddldet = new tbl_multiwoselection();
            Repository<tbl_multiwoselection> lista = new Repository<tbl_multiwoselection>();
            try
            {
                string query = "SELECT TargetQty from [i_facility_TSAL].[dbo].tbl_multiwoselection WHERE HMIID =" + HmiID+" and PartNo ='"+PartNoS+"' and WorkOrder ='"+WorkOrderNoS+"' and OperationNo ='"+OpNoS+"'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbl_multiwoselection GetmultiselectionDet4(int HmiID, string PartNoS, string WorkOrderNoS, string OpNoS)
        {
            tbl_multiwoselection ddldet = new tbl_multiwoselection();
            Repository<tbl_multiwoselection> lista = new Repository<tbl_multiwoselection>();
            try
            {
                string query = "SELECT DeliveredQty from [i_facility_TSAL].[dbo].tbl_multiwoselection WHERE HMIID =" + HmiID + " and PartNo ='" + PartNoS + "' and WorkOrder ='" + WorkOrderNoS + "' and OperationNo ='" + OpNoS + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmasterparts_st_sw Gettblmasterparts_st_swDet3(string opNo, string partNo)
        {
            tblmasterparts_st_sw ddldet = new tblmasterparts_st_sw();
            Repository<tblmasterparts_st_sw> lista = new Repository<tblmasterparts_st_sw>();
            try
            {
                string query = "SELECT MaterialRemovedQty from [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE IsDeleted = 0 and OpNo ='" + opNo + "' and PartNo ='" + partNo + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
            public tblmasterparts_st_sw Gettblmasterparts_st_swDet1(string opNo, string partNo)
            {
                tblmasterparts_st_sw ddldet = new tblmasterparts_st_sw();
                Repository<tblmasterparts_st_sw> lista = new Repository<tblmasterparts_st_sw>();
                try
                {
                    string query = "SELECT StdCuttingTime from [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE IsDeleted = 0 and OpNo ='" + opNo + "' and PartNo ='" + partNo + "'";
                    ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                }
                return ddldet;
            }
        public tblmasterparts_st_sw Gettblmasterparts_st_swDet2(string OperationNoString, string PartNoString)
        {
            tblmasterparts_st_sw ddldet = new tblmasterparts_st_sw();
            Repository<tblmasterparts_st_sw> lista = new Repository<tblmasterparts_st_sw>();
            try
            {
                string query = "SELECT StdCuttingTime from [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE OpNo ='" + OperationNoString + "' and PartNo ='" + PartNoString + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmasterparts_st_sw Gettblmasterparts_st_swDet(string OperationNoString, string PartNoString)
        {
            tblmasterparts_st_sw ddldet = new tblmasterparts_st_sw();
            Repository<tblmasterparts_st_sw> lista = new Repository<tblmasterparts_st_sw>();
            try
            {
                string query = "SELECT StdCuttingTimeUnit from [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE OpNo ='" + OperationNoString + "' and PartNo ='" + PartNoString + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }

        public tbloeedashboardvariable GettbloeedashboardvariablesDet3(int MachineID, DateTime StartDateFormatted)
        {
            tbloeedashboardvariable ddldet = new tbloeedashboardvariable();
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT MinorLosses from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE WCID =" + MachineID+" and StartDate = '"+StartDateFormatted+"'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblworeport GettblworeportsDet3(int MachineID, string correctedDate,string ProdFAI)
        {
            tblworeport ddldet = new tblworeport();
            Repository<tblworeport> lista = new Repository<tblworeport>();
            try
            {
                string query = "SELECT MinorLoss from [i_facility_TSAL].[dbo].tblworeport WHERE MachineID =" + MachineID+" and CorrectedDate ='"+correctedDate+"' and Type = '"+ProdFAI+"'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tblworeport> Gettblworeportfor1(int hmiid)
        {
            Repository<tblworeport> lista = new Repository<tblworeport>();
            List<tblworeport> det = new List<tblworeport>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblworeport WHERE HMIID =" + hmiid + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet(int? MachineID, string UsedDateForExcel)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate ='" + UsedDateForExcel + "' and MachineID = " + MachineID + " and isWorkOrder = 0 and (isWorkInProgress = 1 || isWorkInProgress = 0) order by HMIID desc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet1(DateTime startDateTimeInFormat,DateTime endDateTimeInFormat, string Prefix)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE PEStartTime > '"+startDateTimeInFormat+"' and Time < '"+endDateTimeInFormat+"' and PartNo like '"+Prefix+ "%' and IsMultiWO = 0 order by PartNo desc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet2(DateTime startDateTimeInFormat, DateTime endDateTimeInFormat, string Prefix)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE PEStartTime > '" + startDateTimeInFormat + "' and Time < '" + endDateTimeInFormat + "' and PartNo like '" + Prefix + "%' and IsMultiWO = 1 order by PartNo desc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbldailyprodstatu> Gettbldailyprodstatusfor1(int MachineID,string CorrectedDate)
        {
            Repository<tbldailyprodstatu> lista = new Repository<tbldailyprodstatu>();
            List<tbldailyprodstatu> det = new List<tbldailyprodstatu>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tbldailyprodstatu WHERE IsDeleted = 0 MachineID =" + MachineID+" and CorrectedDate = '"+CorrectedDate+ "' order by StartTime asc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmode> Gettblmodefor1(int MachineID,string CorrectedDate)
        {
            Repository<tblmode> lista = new Repository<tblmode>();
            List<tblmode> det = new List<tblmode>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmode WHERE IsDeleted =0 and MachineID ="+MachineID+" and CorrectedDate ='"+CorrectedDate+"' OrderBy InsertedOn asc ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tbllossescode GettbloeelossDet3(string settingString)
        {
            tbllossescode ddldet = new tbllossescode();
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            try
            {
                string query = "SELECT Max(Loss1Value)  from [i_facility_TSAL].[dbo].tbllossescode WHERE IsDeleted =0 and  MessageType like '%" + settingString + "%'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tblhmiscreen> Gettblhmiscreensfor1(string today,int machineid)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate ='"+today+"' and MachineID ="+machineid+" and isWorkInProgress = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblbreakdown> Gettbltblbreakdownfor1(int MachineID, string UsedDateForExcel)
        {
            Repository<tblbreakdown> lista = new Repository<tblbreakdown>();
            List<tblbreakdown> det = new List<tblbreakdown>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblhmiscreen WHERE MachineID ="+MachineID+" and CorrectedDate ='"+UsedDateForExcel+"' and DoneWithRow = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> Gettblmachinedetfor1(string countryId)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and ShopNo ='"+countryId+"' ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> Gettblmachinedet()
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbluser> Gettbluserfor1()
        {
            Repository<tbluser> lista = new Repository<tbluser>();
            List<tbluser> det = new List<tbluser>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbluser WHERE IsDeleted =0 and PrimaryRole = 3 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblworeport> Gettblworeportfor2(int MachineID,string correctedDate)
        {
            Repository<tblworeport> lista = new Repository<tblworeport>();
            List<tblworeport> det = new List<tblworeport>();
            try
            {
                string query = "SELECT HMIID From [i_facility_TSAL].[dbo].tblworeport WHERE MachineID = " + MachineID+" and CorrectedDate ='"+correctedDate+ "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblworeport> Gettblworeportfor2(string PartNoString,string WorkOrderNo,string OperationNoString)
        {
            Repository<tblworeport> lista = new Repository<tblworeport>();
            List<tblworeport> det = new List<tblworeport>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblworeport WHERE PartNo ='"+PartNoString+"' and WorkOrderNo ='"+WorkOrderNo+"' and OpNo ='"+OperationNoString+"' ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblwolossess> Gettblwolossessfor1(int hmiid)
        {
            Repository<tblwolossess> lista = new Repository<tblwolossess>();
            List<tblwolossess> det = new List<tblwolossess>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblwolossess WHERE HMIID =" + hmiid + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tblmachinedetail GettblmachineDet3(int MachineID)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT IsNormalWC from [i_facility_TSAL].[dbo].tblmachinedetails WHERE MachineID =" + MachineID + "";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbluser GetuserDet3(int OperatorID)
        {
            tbluser ddldet = new tbluser();
            Repository<tbluser> lista = new Repository<tbluser>();
            try
            {
                string query = "SELECT IsNormalWC from [i_facility_TSAL].[dbo].tbluser WHERE UserID =" + OperatorID + "";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblpartwiseworkcenter GettblpartwiseworkcenterDet3(int MachineIDRow)
        {
            tblpartwiseworkcenter ddldet = new tblpartwiseworkcenter();
            Repository<tblpartwiseworkcenter> lista = new Repository<tblpartwiseworkcenter>();
            try
            {
                string query = "SELECT IsNormalWC from [i_facility_TSAL].[dbo].tblpartwiseworkcenter WHERE WorkCenterId ="+MachineIDRow+"";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblpartwisesp GettblpartwisespDet3(string PartNumber)
        {
            tblpartwisesp ddldet = new tblpartwisesp();
            Repository<tblpartwisesp> lista = new Repository<tblpartwisesp>();
            try
            {
                string query = "SELECT SurfaceArea from [i_facility_TSAL].[dbo].tblpartwisesp WHERE PartName ='" + PartNumber+"'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblpartwisesp GettblpartwisespDet1(string PartNumber)
        {
            tblpartwisesp ddldet = new tblpartwisesp();
            Repository<tblpartwisesp> lista = new Repository<tblpartwisesp>();
            try
            {
                string query = "SELECT Perimeter from [i_facility_TSAL].[dbo].tblpartwisesp WHERE PartName ='" + PartNumber + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        //Anjali 

        public tblholdcode GetHoldCodeDetails(int HoldCodeID)
        {
            tblholdcode user = new tblholdcode();
            try
            {
                Repository<tblholdcode> lista = new Repository<tblholdcode>();

                string qry = "SELECT * FROM [i_facility_tsal].[dbo].[tblholdcode] WHERE HoldCodeID =" + HoldCodeID+"";
                user = lista.GetFirstOrDefault(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public tbllossescode GetLossCodeDetails(int LossCodeID)
        {
            tbllossescode user = new tbllossescode();
            try
            {
                Repository<tbllossescode> lista = new Repository<tbllossescode>();

                string qry = "SELECT * FROM [i_facility_tsal].[dbo].[tbllossescode] WHERE LossCodeID =" + LossCodeID+"";
                user = lista.GetFirstOrDefault(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public tbllossescode GetLossCodeDetails1(string MessageType)
        {
            tbllossescode user = new tbllossescode();
            try
            {
                Repository<tbllossescode> lista = new Repository<tbllossescode>();

                string qry = "SELECT * FROM [i_facility_tsal].[dbo].[tbllossescode] WHERE IsDeleted = 0 and LossCodesLevel1ID = 1 and MessageType ='" + MessageType+"'";
                user = lista.GetFirstOrDefault(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public List<tbllossescode> GetLossCodeDetails2(int ChangeOverid)
        {
            List<tbllossescode> user = new List<tbllossescode>();
            try
            {
                Repository<tbllossescode> lista = new Repository<tbllossescode>();

                string qry = "SELECT DISTINCT LossCodeID FROM [i_facility_tsal].[dbo].[tbllossescode] WHERE LossCodesLevel1ID = " + ChangeOverid+"";
                user = lista.GetList(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public tbllossescode GetLossCodeDetails3(string MessageType)
        {
            tbllossescode user = new tbllossescode();
            try
            {
                Repository<tbllossescode> lista = new Repository<tbllossescode>();

                string qry = "SELECT * FROM [i_facility_tsal].[dbo].[tbllossescode] WHERE IsDeleted = 0 and MessageType ='" + MessageType+"'";
                user = lista.GetFirstOrDefault(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public List<tbllivelossofentry> GetLossofEntryDetails(int MachineID, string CorrectedDate)
        {
            List<tbllivelossofentry> user = new List<tbllivelossofentry>();
            try
            {
                Repository<tbllivelossofentry> lista = new Repository<tbllivelossofentry>();

                string qry = "SELECT DISTINCT MessageCodeID FROM [i_facility_tsal].[dbo].[tbllivelossofentry] WHERE MachineID = " + MachineID + " and CorrectedDate ='" + CorrectedDate + "' and DoneWithRow = 1";
                user = lista.GetList(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }

        public List<tblbreakdown> GetBreakDownDetails(int MachineID, string CorrectedDate)
        {
            List<tblbreakdown> user = new List<tblbreakdown>();
            try
            {
                Repository<tblbreakdown> lista = new Repository<tblbreakdown>();

                string qry = "SELECT DISTINCT BreakDownCode FROM [i_facility_tsal].[dbo].[tblbreakdown] WHERE MachineID = " + MachineID + " and CorrectedDate ='" + CorrectedDate + "' and DoneWithRow = 1";
                user = lista.GetList(qry, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return user;
        }


    }
}
