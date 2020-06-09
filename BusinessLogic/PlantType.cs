using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class PlantType
    {
        private int PlantfamilyID;
        private string Plantfamliy;
        private string Description;

        public List<PlantType> PlantTypes = new List<PlantType>();

        public int PlantfamilyID1 { get => PlantfamilyID; set => PlantfamilyID = value; }
        public string Plantfamliy1 { get => Plantfamliy; set => Plantfamliy = value; }
        public string Description1 { get => Description; set => Description = value; }

        public PlantType()
        {

        }

        public PlantType(object ID, object name, object description)
        {
            this.PlantfamilyID = (Int16)(ID);
            this.Plantfamliy = name.ToString();
            this.Description = description.ToString();
        }

        public List<PlantType> GetPlantTypes()
        {
            //get info from data handler 
            DataSet planttypes = new DataSet();

            foreach (DataRow plantType in planttypes.Tables["PlantTyoes_tbl"].Rows)
            {
                PlantTypes.Add(new PlantType(plantType["PlantTypeID"].ToString(), plantType["Name"].ToString(), plantType["Description"].ToString()));

            }

            return PlantTypes;
        }

    }
}
