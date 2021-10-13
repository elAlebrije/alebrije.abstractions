using System.Collections.Generic;
using System.Linq;

namespace Alebrije.Abstractions.Result
{
    public class PagedServiceResult<THeader, TData> : BaseServiceResult<IEnumerable<TData>>
    {
        private IEnumerable<TData> _data = new List<TData>();
        private Pagination.Info _pageInfo;

        public THeader Header { get; set; }

        public Pagination.Info PageInfo
        {
            get
            {
                _pageInfo ??= new Pagination.Info
                {
                    TotalPages = 1,
                    DisplayPage = 1
                };

                _pageInfo.RecordsDisplayed = Data.Count();
                if (_pageInfo.PageSize <= 0)
                {
                    _pageInfo.PageSize = Data.Count();
                }

                return _pageInfo;
            }
            set => _pageInfo = value ??
                               new Pagination.Info
                               {
                                   TotalPages = 1,
                                   DisplayPage = 1,
                                   RecordsDisplayed = Data.Count(),
                                   PageSize = Data.Count()
                               };
        }

        public override IEnumerable<TData> Data
        {
            get => _data;
            set
            {
                if (value == null)
                {
                    return;
                }

                _data = value.ToList();

                PageInfo.PageSize = PageInfo.PageSize > 0 ? PageInfo.PageSize : _data.Count();
                PageInfo.RecordsDisplayed = _data.Count();
            }
        }
    }
}