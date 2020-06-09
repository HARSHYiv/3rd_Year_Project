using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class PSystems
    {
        private string systemID;
        private string userID;
        private string plantID;
        private string HarvestYeild;

        List<PSystems> pSystems = new List<PSystems>();

        public string SystemID { get => systemID; set => systemID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string PlantID { get => plantID; set => plantID = value; }
        public string HarvestYeild1 { get => HarvestYeild; set => HarvestYeild = value; }

        public PSystems(string systemID, string userID, string plantID, string harvestYeild)
        {
            this.systemID = systemID;
            this.userID = userID;
            this.plantID = plantID;
            HarvestYeild = harvestYeild;
        }

        public PSystems()
        {

        }

        public List<PSystems> GetSystems() 
        {
            //get info from data handler
            DataSet userdata = new DataSet();
            foreach (DataRow pSys in userdata.Tables["System_tbl"].Rows)
            {
                pSystems.Add(new PSystems(pSys["SystemID"].ToString(), pSys["UserID"].ToString(), pSys["PlantID"].ToString(), pSys["HarvestYeild"].ToString())); ;

            }

            return pSystems;
        }
    }
}
