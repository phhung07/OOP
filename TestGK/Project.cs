using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGK
{
    internal class Project
    {
        private string maduan;
        public string Maduan
        {
            get { return maduan; }
            set { if (!string.IsNullOrEmpty(value)) maduan = value; }
        }
        private string tenduan;
        public string Tenduan
        {
            get { return tenduan; }
            set { if (!string.IsNullOrEmpty(value)) tenduan = value; }
        }
        private List<Member> members;
        public Project(string maduan, string tenduan)
        {
            this.maduan = maduan;
            this.tenduan = tenduan;
            this.members = new List<Member>();
        }
        public void AddMember(Member m)
        {
            members.Add(m);
        }  
        public virtual void ShowProjectDetails()
        {
            Console.WriteLine($"Ma du an: {Maduan}");
            Console.WriteLine($"Ten du an: {Tenduan}");
            Console.WriteLine("Danh sach thanh vien:");
            Console.WriteLine();
           foreach(var member in members)
            {
                member.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
