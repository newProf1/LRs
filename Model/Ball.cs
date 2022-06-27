using System;

namespace Model
{
    [Serializable]
    public class Ball : IFigures
    {
        //S1 - Радиус
        protected float s1;

        public float S1
        {
            get { return s1; }
            set
            {
                if (value > 0)
                    s1 = value;
                else throw new ArgumentOutOfRangeException("Отрицательное значение первого аргумента");
            }
        }

        public Ball(float r) {
            if (r < 10000)
                S1 = r;
            else throw new ArgumentException("Передано значние, превышающее допустимое");
        }

        public float Volume() { return (float)(1.0 / 3.0 * Math.PI * S1 * S1 * S1); }

        public string Output()
        {
            return ($"Радиус: {S1}; Объем: {Volume()}");
        }

        public string Name()
        {
            return "Шар";
        }
    }
}
