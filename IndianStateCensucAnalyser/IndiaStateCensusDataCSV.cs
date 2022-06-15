using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensucAnalyser
{
   
        public class IndiaStateCensusDataCSV
        {
            string state;
            string population;
            int area;
            string density;
            int serialNumber;
            string stateName;
            int tin;
            string stateCode;
            public IndiaStateCensusDataCSV(string state, string population, string area, string density)
            {
                this.state = state;
                this.population=population;
                this.area = Convert.ToInt32(area);
                this.density = density;
            }
            public IndiaStateCensusDataCSV(IndiaStateCensusDataCSV indianStateCodeDataCSV)
            {
                this.stateName = indianStateCodeDataCSV.stateName;
                this.serialNumber = indianStateCodeDataCSV.serialNumber;
                this.tin = indianStateCodeDataCSV.tin;
                this.stateCode = indianStateCodeDataCSV.stateCode;
            }
        }
    
    
}
