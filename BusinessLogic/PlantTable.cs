using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class PlantTable
    {
        private string PlantID;
        private string Name;
        private string ScientifiName;
        private string Description;
        private double LightIntensity;
        private double PhotoPeriod;
        private double Temperature;
        private string Solution;
        private double PH;
        private int PlantFamilyID;
        public List<PlantTable> Plants = new List<PlantTable>();

        public string PlantID1 { get => PlantID; set => PlantID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string ScientifiName1 { get => ScientifiName; set => ScientifiName = value; }
        public string Description1 { get => Description; set => Description = value; }
        public double LightIntensity1 { get => LightIntensity; set => LightIntensity = value; }
        public double PhotoPeriod1 { get => PhotoPeriod; set => PhotoPeriod = value; }
        public double Temperature1 { get => Temperature; set => Temperature = value; }
        public string Solution1 { get => Solution; set => Solution = value; }
        public double PH1 { get => PH; set => PH = value; }
        public int PlantFamilyID1 { get => PlantFamilyID; set => PlantFamilyID = value; }

        public PlantTable()
        {

        }
        public PlantTable(object ID, object name, object Sname, object description, object light, object photoperiod, object temp, object solution, object phlevel, object familyID)
        {
            this.PlantID = (string)(ID);
            this.Name = name.ToString();
            this.ScientifiName = Sname.ToString();
            this.Description = description.ToString();
            this.LightIntensity = (double)(light);
            this.PhotoPeriod = (double)(photoperiod);
            this.Temperature = (double)(temp);
            this.Solution = solution.ToString();
            this.PH = (double)(phlevel);
            this.PlantFamilyID = (Int16)(familyID);
        }

        public List<PlantTable> GetPlants()
        {
            DataSet Planttable = new DataSet();

            foreach (DataRow Plant in Planttable.Tables["PlantTable"].Rows)
            {
                Plants.Add(new PlantTable(Plant["PlantID"], Plant["Name"], Plant["ScientifiName"], Plant["Description"], Plant["LightIntensity"], Plant["PhotoPeriod"], Plant["Temprature"], Plant["Solution"], Plant["PH"], Plant["PlantFamilyID"]));

            }
            return Plants;
        }
        
    }
}
