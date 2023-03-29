using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Table
{
    public Table()
    {

    }
      /*  public int[][] ids { get; set; }
       
        public void values() {
            for (int i = 0; i < 48; i++)
            {
                ids[i] = i;
                if (ids[i] >= 0 && ids[i] <= 36)
                {
                    ids[i][i] = 36;
                }
                if (ids[i] >= 46 && ids[i] < 48 || (ids[i] >= 37 && ids[i] <= 39))
                {
                    ids[i][i] = 3;
                }
                if (ids[i] >= 40 && ids[i] < 45)
                {
                    ids[i][i] = 2;
                }
            }
        }*/
        public ICollection<int> values { get; set; }
}
       
