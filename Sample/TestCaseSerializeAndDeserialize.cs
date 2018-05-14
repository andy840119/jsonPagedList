using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PagedList;

namespace Sample
{
    public class TestCaseSerializeAndDeserialize
    {
        public TestCaseSerializeAndDeserialize()
        {
            
        }

        public void Test()
        {
            var pageList = new PagedList<PageListObject>(30);
            pageList.Add(new PageListObject()
            {
                Name = "AAA"
            });
            pageList.Add(new PageListObject()
            {
                Name = "BBB"
            });
            pageList.Add(new PageListObject()
            {
                Name = "CCC"
            });

            var pageList2 = new PagedList<PageListObject>(30);
            pageList2.Add(new PageListObject()
            {
                Name = "DDD"
            });
            pageList2.Add(new PageListObject()
            {
                Name = "EEE"
            });
            pageList2.Add(new PageListObject()
            {
                Name = "FFF"
            });

            pageList.CombinePageData(pageList2);

            string jsonResult = JsonConvert.SerializeObject(pageList);
            Console.WriteLine(jsonResult);
        }

        class PageListObject
        {
            public string Name { get; set; }
        }
    }
}
