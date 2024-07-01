public class Fraction
        {
            //attributes
            private int _top;
            private int _bottom;

            //constructor that initializes the number to 1/1
           public Fraction()
           {
                _top = 1;
                _bottom = 1;

           }

           //constructor that has one parameter for ther top
           // that initializes the denominator to

           public Fraction(int wholeNumber)
           {
                _top = wholeNumber;
                _bottom = 1;
           }
            

            //constructor with teo parameters
           public Fraction(int top, int bottom)
           {

            _top = top;
            _bottom = bottom;

           }


           public void SetTop(int top)
           {
                _top = top;
           }

           public int GetTop()
           {
                return _top;
           }

           public void SetBottom(int bottom)
           {
            _bottom = bottom;
           }

           public int GetBottom()
           {
                return _bottom;
           }

           public string GetFractionString()
           {
                return $"{_top} / {_bottom}";
           }

           public double GetDecimalValue()
           {
                return (double) _top / _bottom;
           }



        }