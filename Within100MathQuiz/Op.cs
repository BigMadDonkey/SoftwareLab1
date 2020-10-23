using System;
using System.Collections.Generic;
using System.Text;

namespace Within100MathQuiz
{
    public interface Op
    {
        public static Op create_Op(int i)
        {
            switch (i)
            {
                case 0:
                    return new Add();
                case 1:
                    return new Minus();
                case 2:
                    return new Multiply();
                case 3:
                    return new Divide();
            }

            return null;
        }

        void generate_Data(out int left, out int right);

        bool check(int left, int right, int ans);
    }

    internal class Divide : Op
    {
        private readonly Random _random = new Random();

        public bool check(int left, int right, int ans)
        {
            return (left / right == ans);
        }

        public void generate_Data(out int left, out int right)
        {
            right = _random.Next(1, 50);
            left = _random.Next(1, 50) * right;
        }

        public override string ToString()
        {
            return "/";
        }
    }

    internal class Multiply : Op
    {
        private readonly Random _random = new Random();

        public bool check(int left, int right, int ans)
        {
            return (left * right == ans);
        }

        public void generate_Data(out int left, out int right)
        {
            left = _random.Next(1, 50);
            right = _random.Next(1, 50);
        }

        public override string ToString()
        {
            return "*";
        }
    }

    internal class Minus : Op
    {
        private readonly Random _random = new Random();

        public bool check(int left, int right, int ans)
        {
            return (left - right == ans);
        }

        public void generate_Data(out int left, out int right)
        {
            right = _random.Next(1, 50);
            left = right + _random.Next(1, 50);
        }

        public override string ToString()
        {
            return "-";
        }
    }

    internal class Add : Op
    {
        private readonly Random _random = new Random();

        public bool check(int left, int right, int ans)
        {
            return (left + right == ans);
        }

        public void generate_Data(out int left, out int right)
        {
            left = _random.Next(1, 50);
            right = _random.Next(1, 50);
        }

        public override string ToString()
        {
            return "+";
        }
    }
}
