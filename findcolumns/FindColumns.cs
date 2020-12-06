using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace findcolumns
{
    public class FindColumns
    {
        public static int CountColumns(DataGridView dgw)
        {
            bool swichCounter;
            int counter = 0;          
            
            for(int i = 0; i < dgw.ColumnCount; i++)
            {
                swichCounter = true;
                for(int j = 1; j < dgw.RowCount; j++)
                {
                    if((int)dgw.Rows[j - 1].Cells[i].Value < (int)dgw.Rows[j].Cells[i].Value)
                    {
                        swichCounter = false;                        
                    }
                    
                }                
                if(swichCounter == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
