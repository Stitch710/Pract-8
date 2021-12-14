using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pract_8
{
    class Guy : IHuman
    {
        public Guy(string sername, string name, int age)
        {
            Sername = sername;
            Name = name;
            Age = age;
            SernamesFriends = new List<string>();
        }
        public string Sername { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsSelected { get; set; }
        public string HumanBriefInfo()
        {
            return Sername;
        }
        public string HumanFullInfo()
        {
            return $"{Sername}  {Name}  {Age}";
        }
        public List<string> SernamesFriends { get; }
        public void Meeting(IHuman human)
        {
            if (SernamesFriends.Contains(human.HumanBriefInfo())) HelloFriend(human.HumanBriefInfo());
            else AddFriend(human.HumanBriefInfo());
        }
        public void AddFriend(string SernameFriend)
        {
            SernamesFriends.Add(SernameFriend);
            MessageBox.Show($"{Sername} познакомился с {SernameFriend}");
        }
        public void HelloFriend(string SernameFriend)
        {
            MessageBox.Show($"{Sername} поздоровался с {SernameFriend}");
        }
    }
}
