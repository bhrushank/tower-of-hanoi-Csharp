using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HanoiTowerAssignment
{
    class Disk
    {
        private int diskID,
                      disk_Diam,
                      disk_PegNum,
                      disk_Level;

        private Color disk_Colour;

        public Disk(int aDiskID, int aDiameter, Color aColour, int aPeg)
        {
            diskID = aDiskID;
            disk_Diam = aDiameter;
            disk_Colour = aColour;
            disk_PegNum = aPeg;
        }

        public void setPegNum(int newPeg)
        {
            disk_PegNum = newPeg;
        }
        public void setLevel(int newLevel)
        {
            disk_Level = newLevel;
        }
        public int getLevel()
        {
            return disk_Level;
        }

        public int getDiskID()
        {
            return diskID;
        }

        public Color getDiskColour()
        {
            return disk_Colour;
        }

        public int getDiameter()
        {
            return disk_Diam;
        }

        public int getPegNum()
        {
            return disk_PegNum;
        }

    }
}
