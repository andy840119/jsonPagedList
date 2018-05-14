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
            var pageList = new PagedList<PageListObject>();
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
            pageList.MetaData.HasNextPage = true;
            pageList.MetaData.HasNextPage = true;

            string jsonResult = JsonConvert.SerializeObject(pageList);

            Console.WriteLine(jsonResult);

            var deserializeResult = JsonConvert.DeserializeObject<PagedList<PageListObject>>(jsonResult);

            string serializeAgainjsonResult = JsonConvert.SerializeObject(deserializeResult);

            Console.WriteLine(serializeAgainjsonResult);
        }

        class PageListObject
        {
            public string Name { get; set; }
        }
    }
}
