﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class i_facility_tsalEntities : DbContext
    {
        public i_facility_tsalEntities()
            : base("name=i_facility_tsalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alarm_history_master> alarm_history_master { get; set; }
        public virtual DbSet<alarm_master> alarm_master { get; set; }
        public virtual DbSet<alarm_report> alarm_report { get; set; }
        public virtual DbSet<automaticjobcard> automaticjobcards { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<code_master> code_master { get; set; }
        public virtual DbSet<cutting_time_report> cutting_time_report { get; set; }
        public virtual DbSet<cutting_time_report_pdf> cutting_time_report_pdf { get; set; }
        public virtual DbSet<day_st_end_time> day_st_end_time { get; set; }
        public virtual DbSet<frommail> frommails { get; set; }
        public virtual DbSet<handle_no_ping> handle_no_ping { get; set; }
        public virtual DbSet<jobcard_details> jobcard_details { get; set; }
        public virtual DbSet<machine_master> machine_master { get; set; }
        public virtual DbSet<mailmaster> mailmasters { get; set; }
        public virtual DbSet<mailmasterprogesc> mailmasterprogescs { get; set; }
        public virtual DbSet<main_time_rep> main_time_rep { get; set; }
        public virtual DbSet<message_code_master> message_code_master { get; set; }
        public virtual DbSet<message_history_master> message_history_master { get; set; }
        public virtual DbSet<opcuttimereport> opcuttimereports { get; set; }
        public virtual DbSet<opcuttimereport_pdf> opcuttimereport_pdf { get; set; }
        public virtual DbSet<operating_time_report> operating_time_report { get; set; }
        public virtual DbSet<operating_time_report_pdf> operating_time_report_pdf { get; set; }
        public virtual DbSet<operationlog> operationlogs { get; set; }
        public virtual DbSet<parameter> parameters { get; set; }
        public virtual DbSet<parameters_master> parameters_master { get; set; }
        public virtual DbSet<pcb> pcbs { get; set; }
        public virtual DbSet<pcb_details> pcb_details { get; set; }
        public virtual DbSet<pcb_parameters> pcb_parameters { get; set; }
        public virtual DbSet<pcbdaq> pcbdaqs { get; set; }
        public virtual DbSet<pcbdaqin_tbl> pcbdaqin_tbl { get; set; }
        public virtual DbSet<pcbdps_master> pcbdps_master { get; set; }
        public virtual DbSet<program_master> program_master { get; set; }
        public virtual DbSet<program_temp> program_temp { get; set; }
        public virtual DbSet<recipientmailid> recipientmailids { get; set; }
        public virtual DbSet<role_master> role_master { get; set; }
        public virtual DbSet<shift_master> shift_master { get; set; }
        public virtual DbSet<tbl_autoreport_log> tbl_autoreport_log { get; set; }
        public virtual DbSet<tbl_autoreportbasedon> tbl_autoreportbasedon { get; set; }
        public virtual DbSet<tbl_autoreportsetting> tbl_autoreportsetting { get; set; }
        public virtual DbSet<tbl_autoreporttime> tbl_autoreporttime { get; set; }
        public virtual DbSet<tbl_multiwoselection> tbl_multiwoselection { get; set; }
        public virtual DbSet<tbl_reportmaster> tbl_reportmaster { get; set; }
        public virtual DbSet<tblactivitylog> tblactivitylogs { get; set; }
        public virtual DbSet<tblapp_paths> tblapp_paths { get; set; }
        public virtual DbSet<tblbreakdown> tblbreakdowns { get; set; }
        public virtual DbSet<tblbreakdowncode> tblbreakdowncodes { get; set; }
        public virtual DbSet<tblcell> tblcells { get; set; }
        public virtual DbSet<tblcustomer> tblcustomers { get; set; }
        public virtual DbSet<tbldailyprodstatu> tbldailyprodstatus { get; set; }
        public virtual DbSet<tbldailyprodstatushi> tbldailyprodstatushis { get; set; }
        public virtual DbSet<tbldaytiming> tbldaytimings { get; set; }
        public virtual DbSet<tblddl> tblddls { get; set; }
        public virtual DbSet<tbldowntimecategory> tbldowntimecategories { get; set; }
        public virtual DbSet<tbldowntimedetail> tbldowntimedetails { get; set; }
        public virtual DbSet<tblemailescalation> tblemailescalations { get; set; }
        public virtual DbSet<tblemailreporttype> tblemailreporttypes { get; set; }
        public virtual DbSet<tblendcode> tblendcodes { get; set; }
        public virtual DbSet<tblescalationlog> tblescalationlogs { get; set; }
        public virtual DbSet<tblgenericworkcode> tblgenericworkcodes { get; set; }
        public virtual DbSet<tblgenericworkentry> tblgenericworkentries { get; set; }
        public virtual DbSet<tblhmiscreen> tblhmiscreens { get; set; }
        public virtual DbSet<tblholdcode> tblholdcodes { get; set; }
        public virtual DbSet<tbllivedailyprodstatu> tbllivedailyprodstatus { get; set; }
        public virtual DbSet<tbllivehmiscreen> tbllivehmiscreens { get; set; }
        public virtual DbSet<tbllivehmiscreenrep> tbllivehmiscreenreps { get; set; }
        public virtual DbSet<tbllivelossofentry> tbllivelossofentries { get; set; }
        public virtual DbSet<tbllivelossofentryrep> tbllivelossofentryreps { get; set; }
        public virtual DbSet<tbllivemanuallossofentry> tbllivemanuallossofentries { get; set; }
        public virtual DbSet<tbllivemanuallossofentryrep> tbllivemanuallossofentryreps { get; set; }
        public virtual DbSet<tbllivemode> tbllivemodes { get; set; }
        public virtual DbSet<tbllivemodedb> tbllivemodedbs { get; set; }
        public virtual DbSet<tbllivemultiwoselection> tbllivemultiwoselections { get; set; }
        public virtual DbSet<tbllossescode> tbllossescodes { get; set; }
        public virtual DbSet<tbllossofentry> tbllossofentries { get; set; }
        public virtual DbSet<tblmachine_master> tblmachine_master { get; set; }
        public virtual DbSet<tblmachineallocation> tblmachineallocations { get; set; }
        public virtual DbSet<tblmachinecategory> tblmachinecategories { get; set; }
        public virtual DbSet<tblmachinedetail> tblmachinedetails { get; set; }
        public virtual DbSet<tblmachinedetailsnew> tblmachinedetailsnews { get; set; }
        public virtual DbSet<tblmailid> tblmailids { get; set; }
        public virtual DbSet<tblmanuallossofentry> tblmanuallossofentries { get; set; }
        public virtual DbSet<tblmasterparts_st_sw> tblmasterparts_st_sw { get; set; }
        public virtual DbSet<tblmimic> tblmimics { get; set; }
        public virtual DbSet<tblmode> tblmodes { get; set; }
        public virtual DbSet<tblmodulehelper> tblmodulehelpers { get; set; }
        public virtual DbSet<tblmodulemaster> tblmodulemasters { get; set; }
        public virtual DbSet<tblmultipleworkorder> tblmultipleworkorders { get; set; }
        public virtual DbSet<tblnetworkdetailsforddl> tblnetworkdetailsforddls { get; set; }
        public virtual DbSet<tbloeedashboardfinalvariable> tbloeedashboardfinalvariables { get; set; }
        public virtual DbSet<tbloeedashboardvariable> tbloeedashboardvariables { get; set; }
        public virtual DbSet<tbloeedashboardvariablestoday> tbloeedashboardvariablestodays { get; set; }
        public virtual DbSet<tblpart> tblparts { get; set; }
        public virtual DbSet<tblpartwisesp> tblpartwisesps { get; set; }
        public virtual DbSet<tblpartwiseworkcenter> tblpartwiseworkcenters { get; set; }
        public virtual DbSet<tblplannedbreak> tblplannedbreaks { get; set; }
        public virtual DbSet<tblplant> tblplants { get; set; }
        public virtual DbSet<tblpriorityalarm> tblpriorityalarms { get; set; }
        public virtual DbSet<tblreportholder> tblreportholders { get; set; }
        public virtual DbSet<tblroleplaymaster> tblroleplaymasters { get; set; }
        public virtual DbSet<tblrole> tblroles { get; set; }
        public virtual DbSet<tblsendermailid> tblsendermailids { get; set; }
        public virtual DbSet<tblshift_breaks> tblshift_breaks { get; set; }
        public virtual DbSet<tblshift_mstr> tblshift_mstr { get; set; }
        public virtual DbSet<tblshiftdetail> tblshiftdetails { get; set; }
        public virtual DbSet<tblshiftdetails_machinewise> tblshiftdetails_machinewise { get; set; }
        public virtual DbSet<tblshiftmethod> tblshiftmethods { get; set; }
        public virtual DbSet<tblshiftplanner> tblshiftplanners { get; set; }
        public virtual DbSet<tblshop> tblshops { get; set; }
        public virtual DbSet<tbltosapfilepath> tbltosapfilepaths { get; set; }
        public virtual DbSet<tbltosapshopname> tbltosapshopnames { get; set; }
        public virtual DbSet<tblunit> tblunits { get; set; }
        public virtual DbSet<tbluser> tblusers { get; set; }
        public virtual DbSet<tblwolossess> tblwolossesses { get; set; }
        public virtual DbSet<tblworeport> tblworeports { get; set; }
        public virtual DbSet<user_master> user_master { get; set; }
        public virtual DbSet<main_time_view> main_time_view { get; set; }
        public virtual DbSet<parametermaster_view> parametermaster_view { get; set; }
        public virtual DbSet<person> people { get; set; }
    }
}
