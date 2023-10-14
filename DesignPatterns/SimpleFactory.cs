namespace DesignPatterns
{
    /// <summary>
    /// 菜抽象类
    /// </summary>
    public abstract class Food
    {
        // 输出点了什么菜
        public abstract void Print();
    }
    /// <summary>
    /// 西红柿炒鸡蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }

    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }

    public class Customer
    {
        static void CreateFood()
        {
            // 客户想点一个西红柿炒蛋        
            Food food1 = SimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();

            // 客户想点一个土豆肉丝
            Food food2 = SimpleFactory.CreateFood("土豆肉丝");
            food2.Print();

            Console.Read();
        }
    }
    public class SimpleFactory
    {
        /// <summary>
        /// 根据菜名创建具体的实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Food CreateFood(string type)
        {
            Food food = null;

            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambledEggs();
            }

            return food;
        }
    }
}
