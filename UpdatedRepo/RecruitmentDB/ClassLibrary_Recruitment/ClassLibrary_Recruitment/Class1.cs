using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace ClassLibrary_Recruitment
{
    public class Class1
    {
        RecruitmentDBEntities db = new RecruitmentDBEntities();

        public void AddBusinessUnit(string p_bname)
        {
            db.proc_add_bunit(p_bname);
        }

        public void AddNewEmplyee(int p_eid, string p_empname, int p_bid, string p_empdes, bool p_empstatus, int p_empexp)
        {
            db.proc_add_employee(p_eid,p_empname,p_bid,p_empdes,p_empstatus,p_empexp);
        }

        public void InsertRequest(int p_bid, int p_jreq, int p_dreq, int p_breq)
        {
            ObjectParameter p_rid = new ObjectParameter("rid", 0);
            db.proc_insert_req(p_rid, p_bid, p_jreq, p_dreq, p_breq);
        }

        public void DeleteBusinessRequirement(int p_rid)
        {
            db.proc_delete_BReqTable(p_rid);
        }

        public void UpdateBusinessRequirements(int p_rid, int p_bid, int p_eid, string p_etype)
        {
            db.proc_update_tables(p_rid, p_bid, p_eid, p_etype);
        }

        public List<proc_display_requrests_Result> DisplayRequests(int p_bid)
        {
            return(db.proc_display_requrests(p_bid).ToList());
        }

        public void LoginSignUp(int p_eid, string p_password, string p_etype)
        {
            db.proc_login_signup(p_eid, p_password, p_etype);
        }

        public int? LoginSignIn(int p_eid, string p_password, string p_etype)
        {
            int? result = db.proc_login_signin(p_eid, p_password, p_etype).Single();
            return result;    
        }

        public List<proc_display_pending_requests_Result> DisplayPendingRequests()
        {
            return db.proc_display_pending_requests().ToList();
        }

        public List<proc_display_available_employees_Result> DisplayAvailableEmployees()
        {
            return db.proc_display_available_employees().ToList();
        }
    }
}
