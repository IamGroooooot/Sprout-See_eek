using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            //save파일 불러오기
            bool saveFileExists = true;
            string data= "0,0,0,1,2,2,1,1,1,100,100,13,false";

            if (saveFileExists)
            {
                var splittedData = data.Split(',');
                
                Vector3 savedPos = new Vector3(Convert.ToSingle(splittedData[0]), Convert.ToSingle(splittedData[1]), Convert.ToSingle(splittedData[2]));
                Charater groot = new Charater(savedPos, new Vector3(0, 0, 0), new Vector3(1, 1, 1), 100, 100, 10, false, "그루트", new Image("/data/char.jpg"));
            }
            else
            {
                Charater groot = new Charater(new Vector3(0, 0, 0), new Vector3(0, 0, 0), new Vector3(1, 1, 1), 100, 100, 10, false, "그루트", new Image("/data/char.jpg"));
            }


        }
    }


    
}
