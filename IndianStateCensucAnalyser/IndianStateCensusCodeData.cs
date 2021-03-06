using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class IndianStateCensusCodeData
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        public IndianStateCensusCodeData(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}
