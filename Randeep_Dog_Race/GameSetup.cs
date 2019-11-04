using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randeep_Dog_Race
{
   public class GameSetup
    {
        public int Randeep = 130, Harman = 110, Param = 150;
        Random obj_Random = new Random();
        // this method is used to move the dog from one location to another 
        public int run() {
            return obj_Random.Next(1, 30);
        }
        //  this code is used to update the value of the combo box in which the details of the players are saved 
        public void result(ComboBox cb,int winner) {
            for (int y=0;y<cb.Items.Count;y++) {
                String []data = cb.Items[y].ToString().Split(' ');
                if (data[0].Equals("Randeep")) {
                    if (data[2].Equals("" + winner))
                    {
                        Randeep = Randeep + Convert.ToInt32(data[8]);
                    }
                    else {
                        Randeep = Randeep - Convert.ToInt32(data[8]);
                    }
                    cb.Items[y] = Randeep + " Dollar in Randeep Account";
                }
                if (data[0].Equals("Harman"))
                {
                    if (data[2].Equals("" + winner))
                    {
                        Harman = Harman + Convert.ToInt32(data[8]);
                    }
                    else
                    {
                        Harman = Harman - Convert.ToInt32(data[8]);
                    }
                    cb.Items[y] = Harman + " Dollar in Harman Account";
                }

                if (data[0].Equals("Param"))
                {
                    if (data[2].Equals("" + winner))
                    {
                        Param = Param + Convert.ToInt32(data[8]);
                    }
                    else
                    {
                        Param = Param - Convert.ToInt32(data[8]);
                    }
                    cb.Items[y] = Param + " Dollar in Param Account";
                }



            }


            
        }

    }
}
