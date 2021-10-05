namespace Alebrije.Abstractions.Result
{
    public class Pagination
    {
        public class Filter
        {
            private int _pageSize;
            private int _displaying;

            public int PageSize
            {
                get
                {
                    if (_pageSize <= 10)
                    {
                        _pageSize = 10;

                    }
                    return _pageSize;
                }
                set
                {
                    if (value > 1)
                    {
                        _pageSize = value;
                    }
                }
            }

            public int DisplayPage
            {
                get
                {
                    if (_displaying < 1)
                    {
                        _displaying = 1;
                    }

                    return _displaying;
                }
                set
                {
                    if (value > 1)
                    {
                        _displaying = value;
                    }
                }
            }
        }

        public class Info : Filter
        {
            public int TotalPages { get; set; }
            public int RecordsDisplayed { get; set; }
        }
    }
}