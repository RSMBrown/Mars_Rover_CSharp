﻿using System;
using System.Runtime.CompilerServices;
using RoverNamespace;
using PlateauNamespace;

namespace NewPositionNamespace
{
    internal static class NewPosition
    {
        public static void Move(string[] setMovement, ref Rover rover, Plateau plateau)
        {
            foreach (string mov in setMovement)
            {
                string direction = rover.direction; 
                if (direction == "N")
                {
                    if (mov == "L")
                    {
                        rover.direction = "W";
                    } else if (mov == "R")
                    {
                        rover.direction = "E";
                    }
                }

                if (direction == "E")
                {
                    if (mov == "L")
                    {
                        rover.direction = "N";
                    } else if (mov == "R")
                    {
                        rover.direction = "S";
                    }
                }

                if (direction == "S")
                {
                    if (mov == "L")
                    {
                        rover.direction = "E";
                    } else if (mov == "R")
                    {
                        rover.direction = "W";
                    }
                }

                if (direction == "W")
                {
                    if (mov == "L")
                    {
                        rover.direction = "S";
                    } else if (mov == "R")
                    {
                        rover.direction = "N";
                    }
                }

                if (mov == "M" &&  rover.direction == "N" )
                {
                    if (rover.posy + 1 <= plateau.width )
                    {
                        rover.posy += 1;
                    }
                } else if (mov == "M" && rover.direction == "S" )
                {
                    if (rover.posy - 1 >= 0 )
                    {
                        rover.posy -= 1;
                    }
                }

                if (mov == "M" && rover.direction == "E")
                {
                    if (rover.posx + 1 <= plateau.height)
                    {
                        rover.posx += 1;
                    }
                }
                else if (mov == "M" && rover.direction == "W")
                {
                    if (rover.posx - 1 >= 0)
                    {
                        rover.posx -= 1;
                    }
                }
            }           
        }
    }
}