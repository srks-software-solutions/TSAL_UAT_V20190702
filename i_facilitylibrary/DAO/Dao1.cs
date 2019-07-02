using Dapper;
using i_facilitylibrary;
using i_facilitylibrary.DAL;
using i_facilitylibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_facilitylibrary.DAO
{
    public class Dao1 : ConnectionFactory
    {
        IConnectionFactory _connectionFactory;
        public Dao1()
        {

        }
        public Dao1(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public List<tbl_autoreportsetting> GetautoreportList()
        {
            Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
            List<tbl_autoreportsetting> det = new List<tbl_autoreportsetting>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_autoreportsetting WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbl_reportmaster> GetreportmasterList()
        {
            Repository<tbl_reportmaster> lista = new Repository<tbl_reportmaster>();
            List<tbl_reportmaster> det = new List<tbl_reportmaster>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_reportmaster WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbl_autoreportbasedon> GetreportbasedonList()
        {
            Repository<tbl_autoreportbasedon> lista = new Repository<tbl_autoreportbasedon>();
            List<tbl_autoreportbasedon> det = new List<tbl_autoreportbasedon>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_autoreportbasedon WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbl_autoreporttime> GetreporttimeList()
        {
            Repository<tbl_autoreporttime> lista = new Repository<tbl_autoreporttime>();
            List<tbl_autoreporttime> det = new List<tbl_autoreporttime>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_autoreporttime WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblplant> GetPlantList()
        {
            Repository<tblplant> lista = new Repository<tblplant>();
            List<tblplant> det = new List<tblplant>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblplant WHERE IsDeleted = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tblshop> GetShopList()
        {
            Repository<tblshop> lista = new Repository<tblshop>();
            List<tblshop> det = new List<tblshop>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblshop WHERE IsDeleted = 0 and PlantID = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblshop> GetShop1List(int PlantID)
        {
            Repository<tblshop> lista = new Repository<tblshop>();
            List<tblshop> det = new List<tblshop>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblshop WHERE IsDeleted = 0 and PlantID = " + PlantID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbllossescode> GetLossList(int RL2ID)
        {
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            List<tbllossescode> det = new List<tbllossescode>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbllossescode WHERE IsDeleted = 0 and LossCodesLevel = 3 and LossCodesLevel2ID = " + RL2ID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbllossescode> GetLoss1List(int RL1ID)
        {
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            List<tbllossescode> det = new List<tbllossescode>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbllossescode WHERE IsDeleted = 0 and LossCodesLevel = 2 and LossCodesLevel1ID = " + RL1ID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tblcell> GetCellList()
        {
            Repository<tblcell> lista = new Repository<tblcell>();
            List<tblcell> det = new List<tblcell>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblcell WHERE IsDeleted = 0 and PlantID = 999";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblshop> GetShopList1()
        {
            Repository<tblshop> lista = new Repository<tblshop>();
            List<tblshop> det = new List<tblshop>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblshop WHERE IsDeleted = 0 and PlantID = 999";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblcell> GetCell1List(int ShopID)
        {
            Repository<tblcell> lista = new Repository<tblcell>();
            List<tblcell> det = new List<tblcell>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblcell WHERE IsDeleted = 0 and ShopID =" + ShopID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblcell> GetCellList1(int ShopID, int PlantID)
        {
            Repository<tblcell> lista = new Repository<tblcell>();
            List<tblcell> det = new List<tblcell>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblcell WHERE IsDeleted = 0 and PlantID = " + PlantID + " and ShopID =" + ShopID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetmachineList(int PlantID, int ShopID, int MachineID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and PlantID = " + PlantID + " and ShopID = " + ShopID + " and  MachineID =" + MachineID + " and IsNormalWC = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tblmachinedetail GetmachineList1(string WCInvNoStringOverAll)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineID From [i_facility_TSAL].[dbo].tblmachinedetails WHERE MachineInvNo = '" + WCInvNoStringOverAll + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmachinedetail GetmachineList2(string WCInvNoStringOverAll)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineDispName From [i_facility_TSAL].[dbo].tblmachinedetails WHERE MachineInvNo = '" + WCInvNoStringOverAll + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }

        public List<tblmachinedetail> GetmachinecellList(int CellID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and  CellID =" + CellID + " and IsNormalWC = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tblmachinedetail> GetmachineshopcellList(int ShopID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and  ShopID=" + ShopID + " and CellID =null and IsNormalWC = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetmachineshopcellList1()
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmode> GetmodeList(int MachineID, string CorrectedDate)
        {
            Repository<tblmode> lista = new Repository<tblmode>();
            List<tblmode> det = new List<tblmode>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmode WHERE IsDeleted = 0 and MachineID = " + MachineID + " and CorrectedDate ='" + CorrectedDate + "' order by InsertedOn";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetmachineList()
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and PlantID = 999";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetmachineList1()
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and PlantID = 999";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tbl_autoreportsetting Gettbl_autoreportsettingDet(int? ReportID, int? BasedOn, int? AutoReportTimeID, int? PlantID, int? ShopID, int? CellID, int? MachineID)
        {
            tbl_autoreportsetting ddldet = new tbl_autoreportsetting();
            Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbl_autoreportsetting WHERE ReportID = " + ReportID + " and BasedOn = " + BasedOn + " and AutoReportTimeID = " + AutoReportTimeID + " and PlantID =" + PlantID + " and ShopID =" + ShopID + " and CellID =" + CellID + " and MachineID =" + MachineID + "";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbl_autoreportsetting Gettbl_autoreportsettingDet1(int id, int? ReportID, int? BasedOn, int? AutoReportTimeID, int? PlantID, int? ShopID, int? CellID, int? MachineID)
        {
            tbl_autoreportsetting ddldet = new tbl_autoreportsetting();
            Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbl_autoreportsetting WHERE AutoReportID != " + id + " and ReportID = " + ReportID + " and BasedOn = " + BasedOn + " and AutoReportTimeID = " + AutoReportTimeID + " and PlantID =" + PlantID + " and ShopID =" + ShopID + " and CellID =" + CellID + " and MachineID =" + MachineID + "";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbl_autoreportsetting GetoneautoreportsettingDet(int id)
        {
            tbl_autoreportsetting ddldet = new tbl_autoreportsetting();
            Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbl_autoreportsetting WHERE AutoReportID = " + id + "";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public int Inserttbl_autoreportsettingDetails(int? ReportID, int? BasedOn, int? AutoReportTimeID, int? PlantID, int? ShopID, int? CellID, int? MachineID, int CreatedBy, DateTime CreatedOn)
        {
            int res = 0;
            try
            {
                Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
                string query = "INSERT INTO  [i_facility_TSAL].[dbo].tbl_autoreportsetting(ReportID,BasedOn,AutoReportTimeID,PlantID,ShopID,CellID,MachineID,CreatedBy,CreatedOn,IsDeleted)" +
                                        "VALUES(" + ReportID + "," + BasedOn + "," + AutoReportTimeID + "," + PlantID + "," + ShopID + "," + CellID + "," + MachineID + "," + CreatedBy + ",'" + CreatedOn + "',0)";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public int Updatetbl_autoreportsettingDetails(int id, int? ReportID, int? BasedOn, int? AutoReportTimeID, int? PlantID, int? ShopID, int? CellID, int? MachineID, int ModifiedBy, DateTime ModifiedOn)
        {
            int res = 0;
            try
            {
                Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
                string query = "Update  [i_facility_TSAL].[dbo].tbl_autoreportsetting SET ReportID = " + ReportID + ",BasedOn =" + BasedOn + ",AutoReportTimeID =" + AutoReportTimeID + ",PlantID =" + PlantID + ",ShopID =" + ShopID + ",CellID=" + CellID + ",MachineID=" + MachineID + ",ModifiedBy = " + ModifiedBy + ",ModifiedOn ='" + ModifiedOn + "',IsDeleted = 0 WHERE AutoReportID = " + id + "";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public int Updatetbl_autoreportsettingDetailsTodelete(int id, int ModifiedBy, DateTime ModifiedOn)
        {
            int res = 0;
            try
            {
                Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
                string query = "Update  [i_facility_TSAL].[dbo].tbl_autoreportsetting SET IsDeleted = 1,ModifiedBy = " + ModifiedBy + ",ModifiedOn ='" + ModifiedOn + "' WHERE AutoReportID = " + id + "";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public List<tblshop> GetShopwithshopList(int? PlantID)
        {
            Repository<tblshop> lista = new Repository<tblshop>();
            List<tblshop> det = new List<tblshop>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblshop WHERE IsDeleted = 0 and PlantID = " + PlantID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbl_autoreportsetting> Gettbl_autoreportsettingList(int RepID, int BasedOnID, int ReportTimeID)
        {
            Repository<tbl_autoreportsetting> lista = new Repository<tbl_autoreportsetting>();
            List<tbl_autoreportsetting> det = new List<tbl_autoreportsetting>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tbl_autoreportsetting WHERE IsDeleted = 0 and ReportID = " + RepID + " and BasedOn =" + BasedOnID + " and AutoReportTimeID =" + ReportTimeID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmailid> GetMailList(List<string> existingMailIds)
        {
            Repository<tblmailid> lista = new Repository<tblmailid>();
            List<tblmailid> det = new List<tblmailid>();
            try
            {
                string xyz = string.Join<string>(",", existingMailIds);
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmailid WHERE IsDeleted = 0 and EmailID not like in('%" + xyz + "%')";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> Getmachine1List(int? ShopID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and ShopID =" + ShopID + " and CellID =null";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetShopList(int? ShopID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and ShopID =" + ShopID + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tblmachinedetail> GetmachineListforoee(int? PlantID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and PlantID =" + PlantID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetcellListforoee(int? CellID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and CellID =" + CellID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetMachineListforoee(int? MachineID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and MachineID =" + MachineID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> Getmachine2List(int? CellID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and CellID =" + CellID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblcell> GetCellwithcellList(int? PlantID, int? ShopID)
        {
            Repository<tblcell> lista = new Repository<tblcell>();
            List<tblcell> det = new List<tblcell>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblcell WHERE IsDeleted = 0 and PlantID = " + PlantID + " and ShopID =" + ShopID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GetmachinewithmachineList(int? PlantID, int? ShopID, int? CellID)
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and IsNormalWC = 0 and PlantID = " + PlantID + " and ShopID =" + ShopID + " and CellID = " + CellID + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public int deletetbloeedashboardvariablestodaysDetails2(string ipAddress)
        {
            int res = 0;
            try
            {
                Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
                string query = "delete from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IPAddress = '" + ipAddress + "'";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public int deletetbloeedashboardfinalvariablesDetails2(string ipAddress)
        {
            int res = 0;
            try
            {
                //Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
                //string query = "delete from [i_facility_TSAL].[dbo].tbloeedashboardfinalvariables WHERE IPAddress = '" + ipAddress + "'";
                //res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
                Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
                string query = "delete from [i_facility_TSAL].[dbo].tbloeedashboardfinalvariables WHERE IPAddress = '" + ipAddress + "'";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public tbloeedashboardfinalvariable GettbloeeDet(int? WorkCenterID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            tbloeedashboardfinalvariable ddldet = new tbloeedashboardfinalvariable();
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardfinalvariables WHERE IsDeleted = 0 and WCID = " + WorkCenterID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblplant GettbplantDet(int? PlantID)
        {
            tblplant ddldet = new tblplant();
            Repository<tblplant> lista = new Repository<tblplant>();
            try
            {
                string query = "SELECT PlantName from [i_facility_TSAL].[dbo].tblplant WHERE IsDeleted = 0 and PlantID = " + PlantID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblplant GettbplantDet1(int? PlantID)
        {
            tblplant ddldet = new tblplant();
            Repository<tblplant> lista = new Repository<tblplant>();
            try
            {
                string query = "SELECT PlantName from [i_facility_TSAL].[dbo].tblplant WHERE PlantID = " + PlantID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tblplant> Getplant2List1(int PlantID)
        {
            Repository<tblplant> lista = new Repository<tblplant>();
            List<tblplant> det = new List<tblplant>();
            try
            {
                string query = "SELECT * From [i_facility_TSAL].[dbo].tblplant WHERE IsDeleted = 0 and PlantID = " + PlantID + " ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tblshop GettbShopIDDet(int? ShopID)
        {
            tblshop ddldet = new tblshop();
            Repository<tblshop> lista = new Repository<tblshop>();
            try
            {
                string query = "SELECT ShopName from [i_facility_TSAL].[dbo].tblshop WHERE IsDeleted = 0 and ShopID = " + ShopID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblshop GettbShopIDDet1(int? ShopID)
        {
            tblshop ddldet = new tblshop();
            Repository<tblshop> lista = new Repository<tblshop>();
            try
            {
                string query = "SELECT ShopName from [i_facility_TSAL].[dbo].tblshop WHERE ShopID = " + ShopID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblcell GettbcellDet(int? CellID)
        {
            tblcell ddldet = new tblcell();
            Repository<tblcell> lista = new Repository<tblcell>();
            try
            {
                string query = "SELECT CellName from [i_facility_TSAL].[dbo].tblcell WHERE IsDeleted = 0 and CellID = " + CellID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblcell GettbcellDet1(int? CellID)
        {
            tblcell ddldet = new tblcell();
            Repository<tblcell> lista = new Repository<tblcell>();
            try
            {
                string query = "SELECT CellName from [i_facility_TSAL].[dbo].tblcell WHERE CellID = " + CellID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmachinedetail GettbMachineDet(int? MachineID)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineInvNo from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and MachineID = " + MachineID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmachinedetail GettbMachineDe1t(int? MachineID)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineDispName from [i_facility_TSAL].[dbo].tblmachinedetails WHERE MachineID = " + MachineID + " ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tblmachinedetail GettbMachineDet1(int? MachineID)
        {
            tblmachinedetail ddldet = new tblmachinedetail();
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            try
            {
                string query = "SELECT MachineInvNo from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0 and MachineID = " + MachineID + " and IsNormalWC = 0 ";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tbl_multiwoselection> Gettbl_multiwoselectionDet1(string woNo, string partNo, string opNo)
        {
            Repository<tbl_multiwoselection> lista = new Repository<tbl_multiwoselection>();
            List<tbl_multiwoselection> det = new List<tbl_multiwoselection>();
            try
            {
                string query = "SELECT TOP 1 * from [i_facility_TSAL].[dbo].tbl_multiwoselection WHERE WorkOrder ='" + woNo + "' and PartNo ='" + partNo + "' and OperationNo ='" + opNo + "' order by desc MultiWOID ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblmachinedetail> GettbMachineDetails()
        {
            Repository<tblmachinedetail> lista = new Repository<tblmachinedetail>();
            List<tblmachinedetail> det = new List<tblmachinedetail>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblmachinedetails WHERE IsDeleted = 0  and IsNormalWC = 0 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbllivedailyprodstatu> GetdailyprodstatusDetails(string CorrectedDate)
        {
            Repository<tbllivedailyprodstatu> lista = new Repository<tbllivedailyprodstatu>();
            List<tbllivedailyprodstatu> det = new List<tbllivedailyprodstatu>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbllivedailyprodstatu daily left outer join [i_facility_TSAL].[dbo].tblmachinedetails machine on daily.MachineID = machine.MachineID  WHERE CorrectedDate = '" + CorrectedDate + "'order by StartTime ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tbloeedashboardfinalvariable GettbloeecellDet(int? CellID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            tbloeedashboardfinalvariable ddldet = new tbloeedashboardfinalvariable();
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallCellWise = 1";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeshopDet1(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallCellWise = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDet1(int? PlantID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT PlantID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbplantListDet1(int? PlantID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT ShopID from [i_facility_TSAL].[dbo].tbloeedashboardvariablesstoday WHERE IsDeleted = 0 and PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbplantListDet3(int? PlantID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT ShopID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + "  and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeShopListDet1(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT ShopID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeecellListDet1(int? CellID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeecellvariableListDet1(int? CellID, DateTime fromdate, DateTime todate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and StartDate >= '" + fromdate + "' and StartDate <='" + todate + "'";
                //string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and StartDate >= '" + fromdate + "' and StartDate <='" + todate + "'";

                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeepalntListDet1(int? PlantID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeepalntvariableListDet1(int? PlantID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + " and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "'";
                //string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + " and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "'";

                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeshopListDet1(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tbloeedashboardvariable> GettbloeeshopvariableListDet1(int? ShopID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "'";
                //string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "'";

                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeWCListDet1(int? WCID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and WCID = " + WCID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                //return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeWCvariableListDet1(int? WCID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and WCID = " + WCID + "  and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";

                //string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and WCID = " + WCID + "  and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                // string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and WCID = " + WCID + "  and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";

                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeWCvariableListDet2(int? WCID, DateTime frmDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE WCID = " + WCID + "  and StartDate = '" + frmDate + "'";

                //string query = "SELECT DISTINCT WCID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE WCID = " + WCID + "  and StartDate = '" + frmDate + "'";
                //string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE WCID = " + WCID + "  and StartDate = '" + frmDate + "'";

                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);

                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeWCListDet2(int? WCID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and WCID = " + WCID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeShopListDet2(int? ShopID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT ShopID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and  StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeShopList1Det2(int? ShopID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE  ShopID = " + ShopID + " and  StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeShopList1Det1(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<tbloeedashboardvariablestoday> GettbloeeListDet2(int PlantID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE IsDeleted = 0 and PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDet3(int WCID, string ipAddress, DateTime frmDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE WCID = " + WCID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDetforcell(int CellID, string ipAddress, DateTime frmDate, DateTime ToDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <= '" + ToDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDetforcell1(int CellID, string ipAddress, DateTime frmDate, DateTime ToDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT CellID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <= '" + ToDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDetforshop1(int ShopID, string ipAddress, DateTime frmDate, DateTime ToDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT CellID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <= '" + ToDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariablestoday> GettbloeeListDetforplant1(int PlantID, string ipAddress, DateTime frmDate, DateTime ToDate)
        {
            Repository<tbloeedashboardvariablestoday> lista = new Repository<tbloeedashboardvariablestoday>();
            List<tbloeedashboardvariablestoday> det = new List<tbloeedashboardvariablestoday>();
            try
            {
                string query = "SELECT DISTINCT CellID from [i_facility_TSAL].[dbo].tbloeedashboardvariablestoday WHERE PlantID = " + PlantID + " and IPAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <= '" + ToDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeListDet3(int? PlantID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT PlantID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + " and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeListDetails(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT DISTINCT PlantID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE ShopID = " + ShopID + " and ipAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "' and IsOverallWCWise = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeListDetailsmacdata(int? CellID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT DISTINCT PlantID from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE CellID = " + CellID + " and ipAddress = '" + ipAddress + "' and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "' and IsOverallWCWise = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeListDet4(int? PlantID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + " and StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeshopDet2(int? CellID, int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID=" + CellID + " and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallWCWise = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tbloeedashboardfinalvariable GettbloeeshopDe2(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            tbloeedashboardfinalvariable ddldet = new tbloeedashboardfinalvariable();
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT Max(Loss1Value) from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallCellWise = 1";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbloeedashboardfinalvariable GettbloeeshopDet(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            tbloeedashboardfinalvariable ddldet = new tbloeedashboardfinalvariable();
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallShopWise = 1";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbloeedashboardfinalvariable GettbloeeshopDet3(int? ShopID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            tbloeedashboardfinalvariable ddldet = new tbloeedashboardfinalvariable();
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT Max(Loss1Value)  from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallShopWise = 1";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public tbllossescode GettbloeelossDet3(string settingString)
        {
            tbllossescode ddldet = new tbllossescode();
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            try
            {
                string query = "SELECT Max(Loss1Value)  from [i_facility_TSAL].[dbo].tbllossescode WHERE MessageType like '%" + settingString + "%'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<string> GettbllossescodeDet1(int? setupid)
        {
            List<string> losslist = new List<string>();
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            List<tbllossescode> det = new List<tbllossescode>();
            try
            {
                string query = "SELECT LossCodeID from [i_facility_TSAL].[dbo].tbllossescode WHERE LossCodesLevel1ID = " + setupid + " || LossCodesLevel2ID =" + setupid + "";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var loss in det)
                {
                    losslist.Add(Convert.ToString(loss.LossCodeID));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return losslist;
        }
        public List<string> GettbllossescodeDet2(string contribute)
        {
            List<string> losslist = new List<string>();
            Repository<tbllossescode> lista = new Repository<tbllossescode>();
            List<tbllossescode> det = new List<tbllossescode>();
            try
            {
                string query = "SELECT LossCodeID from [i_facility_TSAL].[dbo].tbllossescode WHERE ContributeTo = '" + contribute + "' and (MessageType != 'PM' || m.MessageType != 'BREAKDOWN')";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
                foreach (var loss in det)
                {
                    losslist.Add(Convert.ToString(loss.LossCodeID));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return losslist;
        }
        public List<tbllossofentry> GettbllossofentryDet1(List<string> SettingIDs, int MachineID, string CorrectedDate)
        {
            Repository<tbllossofentry> lista = new Repository<tbllossofentry>();
            List<tbllossofentry> det = new List<tbllossofentry>();
            try
            {
                string xyz = string.Join<string>(",", SettingIDs);
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbllossofentry WHERE MessageCodeID like '%" + SettingIDs + "%' and MachineID = " + MachineID + " and CorrectedDate == '" + CorrectedDate + "' and DoneWithRow == 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbllossofentry> GettbllossofentryDet2(int MachineID, string CorrectedDate)
        {
            Repository<tbllossofentry> lista = new Repository<tbllossofentry>();
            List<tbllossofentry> det = new List<tbllossofentry>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbllossofentry WHERE  MachineID = " + MachineID + " and CorrectedDate = '" + CorrectedDate + "' and DoneWithRow = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbllossofentry> GettbllossofentryDet3(int MachineID, string CorrectedDate)
        {
            Repository<tbllossofentry> lista = new Repository<tbllossofentry>();
            List<tbllossofentry> det = new List<tbllossofentry>();
            try
            {
                string query = "SELECT DISTINCT MessageCodeID from [i_facility_TSAL].[dbo].tbllossofentry WHERE  MachineID = " + MachineID + " and CorrectedDate = '" + CorrectedDate + "' and DoneWithRow = 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeecellDet1(int? CellID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallCellWise = 0";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                return lista.GetList(query, _connectionFactory.GetConnection);


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeecelllistDet1(int? CellID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT CellID  from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and  StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeplantlistDet1(int? PlantID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT CellID  from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and PlantID = " + PlantID + " and  StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardvariable> GettbloeeshoplistDet1(int? ShopID, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardvariable> lista = new Repository<tbloeedashboardvariable>();
            List<tbloeedashboardvariable> det = new List<tbloeedashboardvariable>();
            try
            {
                string query = "SELECT DISTINCT CellID  from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and ShopID = " + ShopID + " and  StartDate >= '" + frmDate + "' and StartDate <='" + toDate + "'";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet1(int? MachineID, string UsedDateForExcel)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate ='" + UsedDateForExcel + "' and MachineID = " + MachineID + " and IsMultiWO = 0 and isWorkOrder = 0 and (isWorkInProgress = 1 || isWorkInProgress = 0) order by HMIID desc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet2(int? MachineID, string UsedDateForExcel)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate = '" + UsedDateForExcel + "' and MachineID =" + MachineID + " and IsMultiWO = 1 and isWorkOrder = 0 and (isWorkInProgress = 1 || isWorkInProgress = 0)";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblhmiscreen> GettblhmiscreensDet3(int? MachineID, string UsedDateForExcel)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate = '" + UsedDateForExcel + "' and MachineID =" + MachineID + " and IsMultiWO = 1 and isWorkOrder = 1 and (isWorkInProgress = 1 || isWorkInProgress = 0)";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public tblhmiscreen GetttblhmiscreenDet3(int hmiIDFromMulitWO)
        {
            tblhmiscreen ddldet = new tblhmiscreen();
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            try
            {
                string query = "SELECT Time from [i_facility_TSAL].[dbo].tblhmiscreen WHERE HMIID = " + hmiIDFromMulitWO + "";
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
                string query = "SELECT Time from [i_facility_TSAL].[dbo].tblmasterparts_st_sw WHERE IsDeleted = 0 and OpNo ='" + opNo + "' and PartNo ='" + partNo + "'";
                ddldet = lista.GetFirstOrDefault(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return ddldet;
        }
        public List<tblhmiscreen> GettblhmiscreensDet2(int? MachineID, string UsedDateForExcel, string woNo, string partNo, string opNo)
        {
            Repository<tblhmiscreen> lista = new Repository<tblhmiscreen>();
            List<tblhmiscreen> det = new List<tblhmiscreen>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblhmiscreen WHERE CorrectedDate ='" + UsedDateForExcel + "' and MachineID =" + MachineID + " and IsMultiWO = 0 and isWorkOrder = 0 and (isWorkInProgress = 1 || isWorkInProgress = 0) and Work_Order_No = '" + woNo + "' and PartNo = '" + partNo + "' and OperationNo ='" + opNo + "') order by HMIID desc";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tblbreakdown> GettblbreakdownDet1(int? MachineID, string UsedDateForExcel)
        {
            Repository<tblbreakdown> lista = new Repository<tblbreakdown>();
            List<tblbreakdown> det = new List<tblbreakdown>();
            try
            {
                string query = "SELECT * from [i_facility_TSAL].[dbo].tblbreakdown WHERE MachineID =" + MachineID + " and CorrectedDate = '" + UsedDateForExcel + "' and DoneWithRow == 1";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                // return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeDet1(int? WorkCenterID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT Max(Loss1Value) from [i_facility_TSAL].[dbo].tbloeedashboardfinalvariables WHERE IsDeleted = 0 and WCID = " + WorkCenterID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public List<tbloeedashboardfinalvariable> GettbloeeDet2(int? CellID, string ipAddress, DateTime frmDate, DateTime toDate)
        {
            Repository<tbloeedashboardfinalvariable> lista = new Repository<tbloeedashboardfinalvariable>();
            List<tbloeedashboardfinalvariable> det = new List<tbloeedashboardfinalvariable>();
            try
            {
                string query = "SELECT Max(Loss1Value) from [i_facility_TSAL].[dbo].tbloeedashboardvariables WHERE IsDeleted = 0 and CellID = " + CellID + " and IPAddress = '" + ipAddress + "' and StartDate = '" + frmDate + "' and EndDate ='" + toDate + "' and IsOverallCellWise = 1 ";
                //det = _connectionFactory.GetConnection.QueryAsync<tblmachinedetail>(query).Result.ToList();
                //return lista.GetList(query, _connectionFactory.GetConnection);
                det = lista.GetList(query, _connectionFactory.GetConnection);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return det;
        }
        public int InsertoperationlogDetails(int? MachineID, string OpMsg, DateTime? OpDate, DateTime? OpDateTime, TimeSpan? OpTime)
        {
            int res = 0;
            try
            {
                Repository<operationlog> lista = new Repository<operationlog>();
                string query = "INSERT INTO  [i_facility_tsal].[dbo].[operationlog](MachineID,OpMsg,OpDate,PlantID,ShopID,CellID,MachineID,CreatedBy,CreatedOn,IsDeleted)" +
                                        "VALUES(" + MachineID + ",'" + OpMsg + "','" + OpDate + "','" + OpDateTime + "','" + OpTime + "')";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            return res;
        }



    }
}
