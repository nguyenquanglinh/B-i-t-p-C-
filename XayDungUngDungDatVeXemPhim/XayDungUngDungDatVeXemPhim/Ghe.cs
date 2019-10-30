namespace XayDungUngDungDatVeXemPhim
{
    public class Ghe
    {
        private string j;

        public Ghe(int i, string j)
        {
            this.So = i;
            this.Ten = j;
        }

        public int So { get;  set; }
        public string Ten
        {
            get
            {
                return j;
            }
            set
            {
                if (value == "0") j = "A";
                else if (value == "1") j = "B";
                else if (value == "2") j = "C";
                else if (value == "3") j = "D";
                else if (value == "4") j = "E";
                else  j = "F";
            }
        }

        public override string ToString()
        {
            return Ten+ So.ToString();
        }
    }
}