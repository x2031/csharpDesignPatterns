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

    /// <summary>
    /// 调用方
    /// </summary>
    public class Customer
    {
        public static void CreateFood()
        {
            // 客户想点一个西红柿炒蛋        
            #region 简单工厂模式
            Food food1 = SimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();

            // 客户想点一个土豆肉丝
            Food food2 = SimpleFactory.CreateFood("土豆肉丝");
            food2.Print();
            #endregion

            #region 工厂方法模式
            Creator tomatorFactory = new TomatoScrambledEggsFactory();
            tomatorFactory.CreateFoddFactory().Print();

            Creator shreddedPorkFactory = new ShreddedPorkWithPotatoesFactory();
            shreddedPorkFactory.CreateFoddFactory().Print();
            #endregion

            Console.Read();
        }
    }
    /// <summary>
    /// 简单工厂类
    /// </summary>
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
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Creator
    {
        // 工厂方法
        public abstract Food CreateFoddFactory();
    }

    /// <summary>
    /// 西红柿炒蛋工厂类
    /// </summary>
    public class TomatoScrambledEggsFactory : Creator
    {
        /// <summary>
        /// 负责创建西红柿炒蛋这道菜
        /// </summary>
        /// <returns></returns>
        public override Food CreateFoddFactory()
        {
            return new TomatoScrambledEggs();
        }
    }

    /// <summary>
    /// 土豆肉丝工厂类
    /// </summary>
    public class ShreddedPorkWithPotatoesFactory : Creator
    {
        /// <summary>
        /// 负责创建土豆肉丝这道菜
        /// </summary>
        /// <returns></returns>
        public override Food CreateFoddFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }
}
