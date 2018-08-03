using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.构造函数
{
    class Ticket
    {
        // 距离设置只读
        // 价格设置只读
        private int distance;

        public int Distance
        {
            get { return distance; }
        }
        private double price;

        public double Price
        {
            get { return price; }
        }

        // 为价格字段赋值
        private void SetPrice()
        {
            if (this.distance >= 0 && this.distance <= 100)
            {
                this.price = distance * 1;
            }
            else if (this.distance > 100 && this.distance<=200)
            {
                this.price = distance * 0.95;
            }
            else if (this.distance > 200 && this.distance <= 300)
            {
                this.price = distance * 0.9;
            }
            else
            {
                this.price = distance * 0.8;
            }
        }
        // 构造函数
        public Ticket(int distance)
        {
            if (distance < 0)
            {
                distance = 100;
            }
            this.distance = distance;
            this.SetPrice();
            this.ShowInfo();
        }
        public void ShowInfo()
        {
            Console.WriteLine("公里数：{0}，票价：{1}", distance, price);
        }

    }
}
