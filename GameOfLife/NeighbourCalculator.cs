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
        
        public int countAliveNeighbours(Cells cell)
        {
            int cellsAlive = 0;
            int level = 0;
            DisplayProperties(cell,ref cellsAlive,level);
            if (cell.State == "X")
            {
                cellsAlive--;
            }
                
            //Console.WriteLine(cellsAlive);
            
            return cellsAlive;
        }
        static void DisplayProperties(object cell, ref int cellsAlive, int level)
        {
            int countedAlivecells= 0;

            Type type = cell.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {  
              
               // Console.WriteLine(property);
                object propertyValue = property.GetValue(cell);
                string propertyValueAsString = propertyValue != null ? propertyValue.ToString() : "null";
                //Console.WriteLine(propertyValueAsString);
                if(propertyValueAsString is "X")
                {

                    cellsAlive++;
                }
                if(propertyValueAsString == "X" || propertyValueAsString == "-" || propertyValueAsString == "#")
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
                    DisplayProperties(propertyValue, ref cellsAlive, level);
                    level = 0;

                }
                
            }
            
            return;
        }
    }
}