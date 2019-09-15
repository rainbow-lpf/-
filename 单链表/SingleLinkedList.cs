using System;
using System.Collections.Generic;
using System.Text;

namespace 单链表
{
    //定义SingleLinkedList 管理我们的英雄
    public class SingleLinkedList
    {

        //初始化一个头节点
        HeroNode head = new HeroNode(0, "", "");

        //添加节点
        //添加节点到单向链表
        //思路，当不考虑编号顺序时
        //1. 找到当前链表的最后节点
        //2. 将最后这个节点的next 指向 新的节点
        /// <summary>
        ///    无序插入
        /// </summary>
        /// <param name="heroNode"></param>
        public void Add(HeroNode heroNode)
        {
            HeroNode temp = head;

            while (true)
            {
                if (temp.next == null)
                {
                    break;
                }

                temp = temp.next;
            }

            temp.next = heroNode;
        }


        //第二种方式在添加英雄时，根据排名将英雄插入到指定位置
        //(如果有这个排名，则添加失败，并给出提示)

        /// <summary>
        /// 有序插入
        /// </summary>
        /// <param name="heroNode"></param>
        public void AddOrderBy(HeroNode heroNode)
        {
            HeroNode temp = head;

            bool flag = false;

            while (true)
            {
                //说明temp已经在链表的最后
                if (temp.next == null)
                {
                    break;
                }

                //位置找到，就在temp的后面插入  当前的下一个节点大于插入的节点
                if (temp.next.no > heroNode.no)
                {
                    break;

                }
                else if (temp.next.no == heroNode.no)
                {

                    flag = true;  //说明编号存在
                    break;
                }

                temp = temp.next;
            }

            if (flag)
            {
                Console.WriteLine("当前英雄已存在");
            }
            else
            {

                //插入到链表中, temp的后面
                heroNode.next = temp.next;
                temp.next = heroNode;
            }
        }

        /// <summary>
        ///     修改节点信息
        ///     	//修改节点的信息, 根据no编号来修改，即no编号不能改.
        ///     说明
        ///         1. 根据 newHeroNode 的 no 来修改即可
        /// </summary>
        /// <param name="heroNode"></param>
        public void Update(HeroNode newHeroNode)
        {
            //判断是否为空
            if (head.next==null)
            {
                Console.WriteLine("链表为空");

                return;
            }

            //找到需要修改的节点, 根据no编号
            //定义一个辅助变量

            HeroNode temp = head.next;
            bool flag = false;

            while (true)
            {
                if (temp == null)
                {
                    break;
                }

                if (temp.no == newHeroNode.no)
                {
                    //说明已经找到了
                    flag = true;
                    break;
                }

                temp = temp.next;
            }

            if (flag)
            {
                temp.nickname = newHeroNode.nickname;
                temp.name = newHeroNode.name;
            }
            else {

                Console.WriteLine("没有找到对应的信息");
            }

        }


        public void Delete(int no)
        {
            HeroNode temp = head;
            bool flag = false;

            while (true)
            {
                if (temp.next == null)
                {
                    break;
                }

                //说明已经找到
                if (temp.next.no == no)
                {
                    flag = true;
                    break;
                }

                temp = temp.next;
            }

            //判断flag

            if (flag)
            {
                temp.next = temp.next.next;
            }
            else
            {
                Console.WriteLine("你需要删除的节点不存在");
            }
        }


        public void List()
        {
            if (head.next == null)
            {
                Console.WriteLine("你的链表为null;");
                return;
            }

            HeroNode temp = head.next;

            while (true)
            {
                if (temp == null)
                {
                    break;
                }

                Console.WriteLine(temp.toString());

                temp = temp.next;
            }
        }
    }
}
