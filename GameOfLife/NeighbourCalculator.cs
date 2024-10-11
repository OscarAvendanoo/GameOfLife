using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class NeighbourCalculator
    {
        // counts how many of the cells neighbours that are alive
        public int countAliveNeighbours(Cells cell)
        {
            int cellsAlive = 0;
            // level is a counter which keeps track of how deep into the recursion the program is
            // in the method "Display properties"
            int level = 0;
            DisplayProperties(cell,ref cellsAlive,level);
            if (cell.State == "Alive")
            {
                cellsAlive--;
            }
                
           
            
            return cellsAlive;
        }

        // a recursive funcion which goes thorugh the cells properties (neighbour cells) and checks if their state is alive or dead
        // if the neighbour is alive, "cellsAlive" gets incremented
        static void DisplayProperties(object cell, ref int cellsAlive, int level)
        {
            int countedAlivecells= 0;

            Type type = cell.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {  
              
               
                object propertyValue = property.GetValue(cell);
                string propertyValueAsString = propertyValue != null ? propertyValue.ToString() : "null";
                
                if(propertyValueAsString is "Alive")
                {

                    cellsAlive++;
                }
                if(propertyValueAsString == "Alive" || propertyValueAsString == "Dead" || propertyValueAsString == "Border")
                {  if(level == 1)
                    {
                        return;
                    }
                    
                }
                if(propertyValue == null)
                {
                    return;
                }

               if (propertyValue != null && !property.PropertyType.IsPrimitive && property.PropertyType != typeof(string))
                {
                    if (level == 1)
                    {
                        return;
                    }
                    level++;
                    // a recursive call to the method it self, creating a new instance of the same method.
                    DisplayProperties(propertyValue, ref cellsAlive, level);
                    level = 0;

                }
                
            }
            
            return;
        }
    }
}