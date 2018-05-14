using System;
using JsonPagedList;
using Newtonsoft.Json;

namespace Sample
{
    public class TestCasePagedListExtension
    {
        public void Test()
        {
            var pageList = new PagedList<PageListObject>(30);
            pageList.Add(new PageListObject
            {
                Name = "AAA"
            });
            pageList.Add(new PageListObject
            {
                Name = "BBB"
            });
            pageList.Add(new PageListObject
            {
                Name = "CCC"
            });

            var pageList2 = new PagedList<PageListObject>(30);
            pageList2.Add(new PageListObject
            {
                Name = "DDD"
            });
            pageList2.Add(new PageListObject
            {
                Name = "EEE"
            });
            pageList2.Add(new PageListObject
            {
                Name = "FFF"
            });

            pageList.CombinePageData(pageList2);

            var jsonResult = JsonConvert.SerializeObject(pageList);
            Console.WriteLine(jsonResult);
        }

        private class PageListObject
        {
            public string Name { get; set; }
        }
    }
}