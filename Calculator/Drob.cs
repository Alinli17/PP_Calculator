using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Drob
    {
        public double c = 0;
        public double z = 0;

        public Drob(double c, double z)
        {
            this.c = c;
            this.z = z;
        }
        public Drob (double a, double c, double z)
        {
            this.c = a * z + c;
            this.z = z;
        }
        public Drob() { }

        public override string ToString()//cтроковое представление
        {
            return "(" + c.ToString() + "/" + z.ToString() + ")";
        }

        public static Drob operator +(Drob a, Drob b)//сложение дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z + a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator -(Drob a, Drob b)//вычитание дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z - a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator *(Drob a, Drob b)//умножение дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator /(Drob a, Drob b)//деление дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z);//числитель новой дроби
            t.z = a.z * b.c;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат
        }
        public Drob sqrt() // извлечение корня
        {
            Drob t = new Drob(Math.Sqrt(c),Math.Sqrt(z));
            Drob.SetFormat(t);//сокращаем дробь
            return t;
        }
        public Drob Pow(int x) // степень 
        {
            Drob t = new Drob(Math.Pow(c,x), Math.Pow(z,x));
            Drob.SetFormat(t);//сокращаем дробь
            return t;
        }
        //процедура по сокращению дроби
        public static Drob SetFormat(Drob a)
        {

            double max = 0;

            //выбираем что больше числитель или знаменатель
            if (a.c > a.z)
                max = Math.Abs(a.z);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
            else
                max = Math.Abs(a.c);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
                                    //поиск от максимума до 2
            for (double i = max; i >= 2; i--)
            {
                //такого числа, поделив на которое бы делилось без
                //остатка и на числитель и на знаменатель
                if ((a.c % i == 0) & (a.z % i == 0))
                {
                    a.c = a.c / i;
                    a.z = a.z / i;
                }

            }
            //Определяемся со знаком
            //если в знаменателе минус, поднимаем его наверх
            if ((a.z < 0))
            {
                a.c = -1 * (a.c);
                a.z = Math.Abs(a.z);
            }
            return (a);//возращаем результат
        }
    }
}
