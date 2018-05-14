using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PagedList;

namespace Sample
{
    public class TestCasePagedListExtension
    {
        public TestCasePagedListExtension()
        {

        }

        public void Test()
        {
            var pageList = new PagedList<TestCasePagedListExtension.PageListObject>();
            pageList.Add(new TestCasePagedListExtension.PageListObject()
            {
                Name = "AAA"
            });
            pageList.Add(new TestCasePagedListExtension.PageListObject()
            {
                Name = "BBB"
            });
            pageList.Add(new TestCasePagedListExtension.PageListObject()
            {
                Name = "CCC"
            });

            pageList.CombinePageData(pageList);

            string jsonResult = JsonConvert.SerializeObject(pageList);

            Console.WriteLine(jsonResult);

            
        }

        class PageListObject
        {
            public string Name { get; set; }
        }
    }
}
