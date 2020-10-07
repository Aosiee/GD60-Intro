namespace adventure
{
    
    public class Location
    {
        //Properties
        private string _description;
        public bool CanGoUp {get; set;}
        public bool CanGoDown {get; set;}
        public bool CanGoLeft {get; set;}
        public bool CanGoRight {get; set;}

        //Constructor
        public Location(string desc)
            {
                _description = desc;
                CanGoUp = true;
                CanGoDown = true;
                CanGoLeft = true;
                CanGoRight = true;
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
    }
}