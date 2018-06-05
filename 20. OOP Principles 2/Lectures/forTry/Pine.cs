namespace forTry
{
    public class Pine : Plant
    {
        public int shisharka { get; private set; }
        public Pine(int visoko)
            : base(visoko)
        {
            ShisharkaBirth();
        }
        private void ShisharkaBirth()
        {
            this.shisharka = this.Height * 50;
        }
        public string ShisharkaDrop()
        {
            int drop = this.Height * 5;
            this.shisharka -= drop;
            return string.Format("{0} shisharki padnaha ot {1}", drop, this.GetType().Name);
        }
    }
}
