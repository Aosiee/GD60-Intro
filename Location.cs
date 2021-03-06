namespace adventure
{
    
    public class Location
    {

        public enum Direction {UP, DOWN, LEFT, RIGHT, NONE};
        //Properties
        private bool[] _allowable = new bool[4];
        public string Title {get; set;}
        public string Description {get; set;}
        public string _description;
        public bool CanGoUp {get; set;}
        public bool CanGoDown {get; set;}
        public bool CanGoLeft {get; set;}
        public bool CanGoRight {get; set;}
        public bool ItIsRiddle {get; set;}

        //Constructor
        public Location(string desc = "default_desc")
            {
                _description = desc;
                CanGoUp = false;
                CanGoDown = false;
                CanGoLeft = false;
                CanGoRight = false;
            }

        //Methods

        public string Desc()
        { return _description;}

        public void SetAllowableDirections(bool up, bool down, bool left, bool right)
            {
                CanGoUp = up;
                CanGoDown = down;
                CanGoLeft = left;
                CanGoRight = right;
            }
        public void IsRiddle(bool Riddle)
            {
                ItIsRiddle = Riddle;
            }
    }
}