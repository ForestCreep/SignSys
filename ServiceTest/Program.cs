using Person;
using SeverToDB;
using SeverToDB.DataFromDB;
using SeverToDB.SendToDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //以下均是测试代码
            //PersonInfo person = new PersonInfo()
            //{
            //    UserNickName = "Fighter",
            //    UserRealName = "ZWJ",
            //    PassWord = "0000"
            //};
            //DataHelper data = new DataHelper();
            //try
            //{
            //    if (data.SendNewPersonInfoToDB(person))
            //    {
            //        Console.WriteLine("Suceess!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //UpdateConfigFile updateConfigFile = new UpdateConfigFile();
            //updateConfigFile.UpdateStr(@"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Oracle.ManagedDataAccess.Client;provider connection string=""DATA SOURCE = 192.168.20.1:1521 / orcl; USER ID = SCOTT;PASSWORD=0000""", "System.Data.EntityClient");
            //var connStr = @"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Oracle.ManagedDataAccess.Client;provider connection string=&quot;DATA SOURCE=localhost:1521/orcl;PASSWORD=0000;USER ID=SCOTT&quot;" ;

            //var data = dbContext.MANAGERS.Where(x => x.MANAGERNAME == "SCOTT" && x.PASSWORD == "0000").ToList().First();
            //var state = entities2.Database.Connection.State;
            //Console.WriteLine(state);
            //entities2.Database.Connection.Open();
            //var state1= entities2.Database.Connection.State;
            //Console.WriteLine(state1);

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            //var filePic = openFileDialog.ShowDialog();
            //var fileName = "";
            //if (filePic == DialogResult.OK)
            //{
            //    fileName = openFileDialog.FileName;
            //}
            ////获得上传图片的二进制信息
            //byte[] buffer = File.ReadAllBytes(fileName.Trim());
            //PICTUREINFO picture = new PICTUREINFO()
            //{
            //    NICKNAME = "fighter",
            //    COURSE = buffer
            //};
            //dbContext.PICTUREINFO.Add(picture);
            //var num = dbContext.SaveChanges();
            //if (num == 1)
            //    Console.WriteLine("Success!");


            //GetDataHelper getData = new GetDataHelper();
            //var macAdd = getData.ReceiveMacAddress("Marry");
            //var picture = getData.ReceivePictureFromServer("fighter", TimetableAndExpPic.课程表);
            //var signInfo = getData.ReceiveSignInfoFromServer(new PersonInfo() { UserNickName = "YCL" });
            //var signinfo1= getData.ReceiveSignInfoFromServer(new PersonInfo() { UserNickName = "Piter" });
            //var signinfo2 = getData.ReceiveSignInfoFromServer(new PersonInfo() { UserNickName = "Team" });
            //var allSignInfo = getData.ReceiveAllSignInfoFromServer(new PersonInfo() { UserNickName = "YCL" });
            //var allSignInfo1 = getData.ReceiveAllSignInfoFromServer(new PersonInfo() { UserNickName = "Piter" });

            Entities1 dbContext = EntityHelper.GetEntities();
            //SendDataHelper sender = new SendDataHelper();
            //var num = sender.SendChangePersonInfoToDB(new PersonInfo() { UserNickName = "WGWXGG", UserRealName = "WGW" });

            GetDataHelper getData = new GetDataHelper();
            PersonInfo personInfo = new PersonInfo()
            {
                UserNickName = "fighter",
                PassWord = "123456",
                MacAddress = null
            };
            var flag = getData.SendPerosnInfoToServer(personInfo);

            Console.ReadKey();
        }
    }
}
