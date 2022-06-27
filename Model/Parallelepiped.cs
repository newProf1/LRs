using System;

namespace Model
{
    [Serializable]
    public class Parallelepiped : Pyramid, IFigures
    {
        //S1, S2, S3 - стороны
        protected float s3;

        public float S3
        {
            get { return s3; }
            set
            {
                if (value > 0)
                    s3 = value;
                else throw new ArgumentOutOfRangeException("Отрицательное значение третьего аргумента");
            }
        }

        public Parallelepiped(float st1, float st2, float st3) : base(st1, st2) {
            if (st3 < 10000)
            {
                S3 = st3;
            }
            else throw new ArgumentException("Передано значние, превышающее допустимое");
        }

        public new float Volume()
        {
            return S1 * S2 * S3;
        }

        public new string Output()
        {
            return ($"Длина: {S1}; Ширина: {S2}; Высота: {S3}; Объем: {Volume()}");
        }

        public new string Name()
        {
            return "Параллелепипед";
        }
    }
}
