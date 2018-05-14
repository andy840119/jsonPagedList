using System;
using JsonPagedList;
using Newtonsoft.Json;

namespace Sample
{
    public class TestCaseSerializeAndDeserialize
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

            var jsonResult = JsonConvert.SerializeObject(pageList);

            Console.WriteLine(jsonResult);

            var deserializeResult = JsonConvert.DeserializeObject<PagedList<PageListObject>>(jsonResult);

            var serializeAgainjsonResult = JsonConvert.SerializeObject(deserializeResult);

            Console.WriteLine(serializeAgainjsonResult);
        }

        private class PageListObject
        {
            public string Name { get; set; }
        }
    }
}