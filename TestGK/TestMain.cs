using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGK
{
    internal class TestMain
    {
        static void Main(string[] args)
        {
            List<Project> p = new List<Project>();
            Project p1 = new Project("DA01", "He thong Quan ly Ban hang");
            p1.AddMember(new Member("MB01", "Nguyen Van An", "Developer"));
            p1.AddMember(new Member("MB02", "Tran Thi Binh", "Tester"));
            p1.AddMember(new Member("MB03", "Le Hoang Cuong", "Developer"));
            p.Add(p1);

            Project p2 = new Project("DA02", "Ung dụng Đat xe Cong nghe");
            p2.AddMember(new Member("MB04", "Pham Van Dung", "Developer"));
            p2.AddMember(new Member("MB05", "Hoang Thi Hoa", "Tester"));
            p2.AddMember(new Member("MB06", "Vu Minh Hung", "Developer"));
            p.Add(p2);

            Project p3 = new Project("DA03", "Website Thuong mai dien tu");
            p3.AddMember(new Member("MB07", "Ngo Thanh Long", "Developer"));
            p3.AddMember(new Member("MB08", "Đo Thi Mai", "Tester"));
            p3.AddMember(new Member("MB09", "Bui Van Nam", "Developer"));
            p.Add(p3);
            foreach (var project in p)
            {
                project.ShowProjectDetails();
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
