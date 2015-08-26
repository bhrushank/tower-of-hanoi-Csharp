using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HanoiTowerAssignment
{
    public partial class MainForm : Form
    {
        private Board board;
        private Disk selectedDiskObj;
        private int toPegNum;
        private bool gameSaved = true;
   
        private Label[] lbl_Disks = new Label[4];
        int tmrCount = 0;
        string allMovesStringFromAni = "";
        int lastGameCount = 0;

        public MainForm()
        {
            InitializeComponent();
            makeGame();
        }

        public void makeGame()
        {
            Disk disk1 = new Disk(1, lbl_Disk1.Width, lbl_Disk1.BackColor, 1);
            Disk disk2 = new Disk(2, lbl_Disk2.Width, lbl_Disk2.BackColor, 1);
            Disk disk3 = new Disk(3, lbl_Disk3.Width, lbl_Disk3.BackColor, 1);
            Disk disk4 = new Disk(4, lbl_Disk4.Width, lbl_Disk4.BackColor, 1);
            board = new Board(disk1, disk2, disk3, disk4);

            lbl_Disks[0] = lbl_Disk1;
            lbl_Disks[1] = lbl_Disk2;
            lbl_Disks[2] = lbl_Disk3;
            lbl_Disks[3] = lbl_Disk4;
        }

        private void anyDisk_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropEffects result = DragDropEffects.None;

            Label lbl_Disk = sender as Label;
            selectedDiskObj = board.FindDisk(lbl_Disk);

            if (board.CanStartMove(selectedDiskObj))
            {
                result = lbl_Disk.DoDragDrop(0, DragDropEffects.All);
            }
            else 
            {
                MessageBox.Show("The movement is invalid !");
            }

            if (result != DragDropEffects.None)
            {
                ExecuteMove(lbl_Disk, selectedDiskObj.getDiskID());
            }

        }


        private void peg_DragEnter(object sender, DragEventArgs e)
        {
            Panel peg = sender as Panel;
            int chkPegNum = board.FindPegNum(peg);// checks move is valid
            if (board.CanDrop(selectedDiskObj, chkPegNum))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void peg_DragDrop(object sender, DragEventArgs e)
        {
            Panel peg = sender as Panel;
            toPegNum = board.FindPegNum(peg);
        }


        public void ExecuteMove(Label alblDisk, int aDiskID)
        {
            Label lbl_Disk = alblDisk;
            int diskID = aDiskID;

            board.Move(diskID, toPegNum);

            Point newPt = new Point();
            newPt = board.DisplayPosition(diskID, toPegNum); // calculates co-ordinates of new disk location
            lbl_Disk.Location = newPt;
            //gameSaved = false;
            MoveOutput(); // adds new move to text box

            // check last move finished game
            bool gameFinished = board.GameFinished();
            if (gameFinished)
            {
                if (txt_Count.Text == "15")
                {
                    MessageBox.Show("You have successfully completed the game with the minimum number of moves!");//show the user the game is finished in minimum moves
                }
                else
                {
                    MessageBox.Show("You have successfully completed the game but not with the minimum number of moves!");//show the user the game is finished but could be better
                }
            }
        }

        public void MoveOutput()
        {
            txt_Moves.Clear();
            txt_Count.Clear();
            if (!gameSaved)
            {
                txt_Count.Text = (board.GetMoveCount() + lastGameCount).ToString();
            }
            else
            {
                txt_Count.Text = (board.GetMoveCount()).ToString();
            }
           
            txt_Moves.Text = board.AllMovesAsString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset() //reset the game
        {
            board.ResetBoard();
            txt_Count.Text = "0";
            txt_Moves.Text = "";
            Disk disk1 = new Disk(1, lbl_Disk1.Width, lbl_Disk1.BackColor, 1);
            Disk disk2 = new Disk(2, lbl_Disk2.Width, lbl_Disk2.BackColor, 1);
            Disk disk3 = new Disk(3, lbl_Disk3.Width, lbl_Disk3.BackColor, 1);
            Disk disk4 = new Disk(4, lbl_Disk4.Width, lbl_Disk4.BackColor, 1);
            board = new Board(disk1, disk2, disk3, disk4);

            lbl_Disk1.Location = new Point(195, 190);
            lbl_Disk2.Location = new Point(182, 230);
            lbl_Disk3.Location = new Point(165, 270);
            lbl_Disk4.Location = new Point(146, 310);
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            SaveGame();
            Reset();
            //isDemo = true;
            saveData();
            tmrCount = 0;
            
                allMovesStringFromAni = "";
            
            MakeNextMove();
            timer.Enabled = true;
        }

        private void SaveGame()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor          
                StreamWriter streamWriter = new StreamWriter("movements.txt");
                //Write a line of text               
                String content = board.SaveString();
                streamWriter.WriteLine(content);

                //Close the file            
                streamWriter.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(("Exception: " + e1.Message));
            }
        }
        private bool MakeNextMove()
        {
            DiskMove diskMove = (DiskMove)board.getMovesMade()[tmrCount];
            string diskMoveStr = diskMove.SaveAsText();
            
            int diskID_1 = Convert.ToInt32(diskMoveStr.Substring(0,1));
            int toPegNum_1 = Convert.ToInt32(diskMoveStr.Substring(diskMoveStr.Length-1, 1));
            Point newPt = new Point();
            newPt = board.DisplayPosition(diskID_1, toPegNum_1); // calculates co-ordinates of new disk location

            newPt.Y=newPt.Y-40;

            lbl_Disks[diskID_1 - 1].Location = newPt;
            board.FindDisk(lbl_Disks[diskID_1 - 1]).setPegNum(toPegNum_1);

            gameSaved = false;

            txt_Count.Text = (tmrCount+1).ToString();
            tmrCount++;
            int i = board.getMovesMade().Count;
            allMovesStringFromAni+=((tmrCount) + ". " + (diskMove.OutputAsText() + "\r\n"));
            txt_Moves.Text = allMovesStringFromAni;
            
            if (tmrCount >= board.getMovesMade().Count)
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveGame();
            MessageBox.Show("Game Saved !");
        }
       private void saveData()
        {
            String ReadLine;
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("movements.txt");
                while ((ReadLine = streamReader.ReadLine()) != null)
                {
                   int diskID = Convert.ToInt32(ReadLine.Substring(0, 1));
                   int toPegNum = Convert.ToInt32(ReadLine.Substring(ReadLine.Length - 1, 1));
                   DiskMove move = new DiskMove(diskID, toPegNum);
                   board.getMovesMade().Add(move);
                }
            }
            catch (Exception)
            { 
            }
            finally
            {
                streamReader.Close();
            }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!MakeNextMove())
            {
                timer.Enabled = false;
                MessageBox.Show("Animation finished! You can continue the game if the game is not finished! ");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
