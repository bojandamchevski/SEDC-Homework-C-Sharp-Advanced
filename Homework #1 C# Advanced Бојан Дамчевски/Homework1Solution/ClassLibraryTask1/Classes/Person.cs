using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTask1.Classes
{
    public class Person : Player
    {
        public Person(string nickName) : base(nickName)
        {
            NickName = nickName;
        }
    }
}
