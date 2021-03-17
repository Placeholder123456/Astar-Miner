﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Vupa
{
    public class Level
    {
        //int LvlNumber;
        public int LvlNumber { get; set; }
        public List<Cell> Notwalkables { get; set; }
        public Level(int lvlnumber)
        {
            this.LvlNumber = lvlnumber;
            Notwalkables = new List<Cell>();
        }

        public Point SetStart()
        {
            if (LvlNumber == 1)
            {
                return new Point(1, 1);


            }
            if (LvlNumber == 2)
            {
                return new Point(9, 7);
            }

            return new Point();
        }
        public Point SetGoal()
        {
            if (LvlNumber == 1)
            {
                return new Point(9, 7);
            }
            if (LvlNumber == 2)
            {
                return new Point(9, 1);
            }
            return new Point(5, 5);
        }
        public void SetWalls()
        {

            foreach (Cell cell in Game1.visualManager.grid)
            {
                cell.WalkAble = true;
            }

            if (LvlNumber == 1)
            {
                Notwalkables.Add(Game1.visualManager.grid[11]);

            }
            if (LvlNumber == 2)
            {
                Notwalkables.Add(Game1.visualManager.grid[95]);
                Notwalkables.Add(Game1.visualManager.grid[94]);




            }

            foreach (Cell cell in Notwalkables)
            {
                cell.WalkAble = false;
            }
           
            //Game1.visualManager.FindPath();

        }


    }
}
