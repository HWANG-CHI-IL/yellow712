using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp9
{
    /// <summary>
    /// 직렬화 커밋 테스트 -1차ㅇㅇ - 테스트 완료
    /// </summary>
    [Serializable]
    class Clone : IDisposable
    {

        public int Id { get; private set; }

        public Clone(int id)
        {
            this.Id = id;
        }


        public void Dispose()
        {
            

            //
            string fileName = "D:\\Temp\\Clone.dat";
            string dirName = "D:\\Temp\\";
            if (File.Exists(fileName) == false)
            {
                Directory.CreateDirectory(dirName);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream ouput = File.OpenWrite(fileName))
            {
                bf.Serialize(ouput, this);
            }
            MessageBox.Show(" this is" + this.Id + "  must... serialize... Object. ", "clone # " + Id + "says ...");


        }

        ~Clone()
        {
            MessageBox.Show(" Aaargh ! You got me!~", "clone # " + Id + "says ...");
        }
    }
}
