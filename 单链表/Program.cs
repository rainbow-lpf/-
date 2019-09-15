using System;

namespace 单链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //先创建节点
            HeroNode hero1 = new HeroNode(1, "宋江", "及时雨");
            HeroNode hero2 = new HeroNode(2, "卢俊义", "玉麒麟");
            HeroNode hero3 = new HeroNode(3, "吴用", "智多星");
            HeroNode hero4 = new HeroNode(4, "林冲", "豹子头");

            //创建要给链表
            SingleLinkedList singleLinkedList = new SingleLinkedList();


            //加入 无序添加


            // 测试一下单链表的反转功能
            Console.WriteLine("原来链表的情况~~");

            singleLinkedList.List();


            Console.WriteLine("有序添加情况");
            singleLinkedList.AddOrderBy(hero3);
            singleLinkedList.AddOrderBy(hero1);
            singleLinkedList.AddOrderBy(hero4);
            singleLinkedList.AddOrderBy(hero2);

            Console.WriteLine("无需添加后链表的情况~~");

            singleLinkedList.List();



            Console.ReadKey();


        }
    }
}
