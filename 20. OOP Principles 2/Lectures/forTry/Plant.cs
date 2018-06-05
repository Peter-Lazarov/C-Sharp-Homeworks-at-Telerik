namespace forTry
{
    public class Plant
    {
        private int hght;
        private int wneed;

        public int Height
        {
            get
            {
                return this.hght;
            }
            protected set
            {
                this.hght = value;
            }
        }
        public int WaterNeed
        {
            get
            {
                return this.wneed;
            }
            protected set
            {
                this.wneed = value;
            }
        }

        public Plant(int height)
        {
            this.hght = height;
        }

        public void Grow()
        {
            this.hght += 1;
        }
    }
}
