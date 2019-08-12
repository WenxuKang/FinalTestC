using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestC.Object
{

    //student name:Wenxu Kang
    //student ID: 300943385
    //Description: This is the characterPortfolio class for the app



    public class CharacterPortfolio
    {

        //identity
        public Identity Identity { get; set; }

        //characteristics
        public string strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string intellect { get; set; }
        public string Education { get; set; }

        public string SocialStanding { get; set; }

        //skill list

        List<Skill> Skills;

        //constructor
        CharacterPortfolio()
        {
            Skills = new List<Skill>();
            this.Identity = new Identity();

        }
    }
}
