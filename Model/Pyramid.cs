using System;

namespace Model 
{
    [Serializable]
    public class Pyramid : Ball, IFigures
    {
        //S1 - площадь основания, S2 - высота
        protected float s2;

        public float S2
        {
            get { return s2; }
            set
            {
                if (value > 0)
                    s2 = value;
                else throw new ArgumentOutOfRangeException("Отрицательное значение второго аргумента");
            }
        }

        public Pyramid(float s, float h) : base(s) {
            if (h < 10000)
            {
                S2 = h;
            }
            else throw new ArgumentException("Передано значние, превышающее допустимое");
        }

        public new float Volume() { return (float)(1.0 / 3.0 * S1 * S2); }

        public new string Output()
        {
            return ($"Площадь основания: {S1}; Высота {S2}; Объем: {Volume()}");
        }

        public new string Name()
        {
            return "Пирамида";
        }
    }
}
