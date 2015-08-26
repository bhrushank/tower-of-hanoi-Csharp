using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace HanoiTowerAssignment
{
    class Board
    {
        private const int NUMOFDISKS = 4;
        private const int NUMOFPEGS = 3;
        private const int FINISHPEG = 3;
        private const int DISKHEIGHT = 40;
        private const int TOPOFBASE = 350;

        private int[] pegLocX = new int[] { 220, 440, 660 };

        private int moveCount = 0;
        private ArrayList movesMade = new ArrayList();  //stores each move as reference to DiskMove object
        private Disk[] diskObj = new Disk[NUMOFDISKS];
        
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            diskObj[0] = d1;
            diskObj[1] = d2;
            diskObj[2] = d3;
            diskObj[3] = d4;

        }
        public ArrayList getMovesMade()
        {
            return movesMade;
        }

        public void ResetBoard()
        {
            moveCount = 0;            
            movesMade.Clear();

            foreach (Disk disk in diskObj)
            {
                disk.setPegNum(1);                
            }
        }

        public bool GameFinished()
        {
            bool finished = false;
            int countDisks = 0;

            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == (FINISHPEG))
                {
                    countDisks++;
                }
            }
            if (countDisks == NUMOFDISKS)
            {
                finished = true;
            }

            return finished;
        }


        public bool CanStartMove(Disk aDisk)
        {
            bool isTop = true;
            Disk chkDisk = aDisk;

            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == chkDisk.getPegNum())
                {
                    if (disk.getDiameter() < chkDisk.getDiameter())
                    {
                        isTop = false;
                    }
                }

            }
            return isTop;
        }


        public bool CanDrop(Disk aDisk, int aPegNum)
        {
            Disk chkDisk = aDisk;
            int chkPegNum = aPegNum;
            bool validDrop = false;

            bool emptyPeg = true;
            bool smallestDisk = true;
            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == chkPegNum)
                {
                    emptyPeg = false;  // if a disk found on this peg then not empty

                    if (disk.getDiameter() < chkDisk.getDiameter())
                    {
                        smallestDisk = false;  // if the disk found is smaller then not smallest 
                    }
                }
            }

            if (emptyPeg || smallestDisk)
            {
                validDrop = true;
            }

            return validDrop;
        }

        public void Move(int aDiskID, int aPegNum)
        {
            // update disk object
            int movedDiskID = aDiskID;
            int newPegNum = aPegNum;
            diskObj[movedDiskID - 1].setPegNum(newPegNum);

            // record new move
            DiskMove move = new DiskMove(movedDiskID, newPegNum);
            
            movesMade.Add(move);

            // count move
            moveCount++;
        }


        public Disk FindDisk(Label aLabel)
        {
            return diskObj[Convert.ToInt32(aLabel.Text) - 1];
        }


        public int FindPegNum(Panel aPeg)
        {
            Panel peg = aPeg;
            int pegNum = 0;
            for (int i = 0; i < NUMOFPEGS; i++)
            {
                if (pegLocX[i] == (peg.Location.X+5))
                {
                    pegNum = i + 1;
                }
            }

            return pegNum;
        }




        public Point DisplayPosition(int aDiskID, int aPegNum)
        {
            int diskID = aDiskID;
            int pegNum = aPegNum;
            int ptX = 0;
            int ptY = 0;
            int countLevel = 0;

            // Calculate postion of disk working from largest to smallest on specified Peg
            for (int i = 3; i > -1; i--)
            {
                //  Determine level
                if (diskObj[i].getPegNum() == pegNum)
                {
                    countLevel++;
                }

                // Calculate position from Peg and level
                if (diskID == diskObj[i].getDiskID())
                {
                    ptX = DiskLocX(diskID, pegNum);
                    ptY = DiskLocY(diskID, countLevel);
                }
            }
            Point newPt = new Point(ptX, ptY);
            return newPt;
        }




        public int DiskLocX(int aDiskID, int aPegNum)
        {
            int movedDiskID = aDiskID;
            int toPegNum = aPegNum;

            int diskLocX = pegLocX[aPegNum - 1] - (diskObj[movedDiskID - 1].getDiameter() / 2);

            return diskLocX;
        }


        public int DiskLocY(int aDiskID, int aLevel)
        {
            int movedDiskID = aDiskID;
            int newLevel = aLevel;

            int diskLocY = TOPOFBASE - ((newLevel) * DISKHEIGHT);

            return diskLocY;
        }


        public int GetMoveCount()
        {
            return moveCount;
        }


        public string AllMovesAsString()
        {
            string allMovesString = "";
            int i = 1;
            foreach (object ob in movesMade)
            {
                allMovesString += (i + ". " + ((DiskMove)ob).OutputAsText() + "\r\n");
                i++;
            }
            return allMovesString;
        }


        public string SaveString()
        {
            string saveString = "";
            foreach (object ob in movesMade)
            {
                saveString += (((DiskMove)ob).SaveAsText()+ "\r\n");
            }
            return saveString;
        }       
    }
}
