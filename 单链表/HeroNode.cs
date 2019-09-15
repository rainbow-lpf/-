using System;
using System.Collections.Generic;
using System.Text;

namespace 单链表
{

    //定义HeroNode ， 每个HeroNode 对象就是一个节点
    public class HeroNode
    {
        public int no;
        public string name;
        public string nickname;
        public HeroNode next; //指向下一个节点

        public HeroNode(int no, String name, String nickname)
        {
            this.no = no;
            this.name = name;
            this.nickname = nickname;
        }

        public String toString()
        {
            return "HeroNode [no=" + no + ", name=" + name + ", nickname=" + nickname + "]";
        }
    }
}
