using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTowerAssignment
{
    class DiskMove
    {
        private string diskIDStr, pegNumStr;


        public DiskMove(Int32 aDisk, Int32 aPeg)
        {
            diskIDStr = aDisk.ToString();
            pegNumStr = aPeg.ToString();
        }
        public DiskMove(string diskMoveStr)
        {
            string[] parts = diskMoveStr.Split();
            diskIDStr = parts[0];
            pegNumStr = parts[1];
        }


        public string OutputAsText()
        {
            return ("Disk " + diskIDStr + " to Peg " + pegNumStr);
        }

        public string SaveAsText()
        {
            return (diskIDStr + pegNumStr);
        }
        
    }
}
