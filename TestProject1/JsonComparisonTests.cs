using Newtonsoft.Json.Linq;
using NUnit.Framework;

[TestFixture]
public class JsonComparisonTests
{
    [Test]
    public void TestJsonDocumentsAreEqual()
    {
        // Load your JSON documents as strings
        string json1 = @"{ 'name': 'John', 
                            'age': 30, 
                            'city': 'New York', 
                            'address': { 
                                    'street': '5th Avenue', 
                                    'zip': '10001' }
                        }";
        string json2 = @"{'age': 30, 'city': 'New York', 'name': 'John', 'address': { 'zip': '10001', 'street': '5th Avenue' }}";

        // Parse the JSON documents
        JObject parsedJson1 = JObject.Parse(json1);
        JObject parsedJson2 = JObject.Parse(json2);

        // Compare the parsed JSON documents
        bool areEqual = JToken.DeepEquals(parsedJson1, parsedJson2);

        // Assert that the JSON documents are equal
        Assert.IsTrue(areEqual, "The JSON documents are not equal.");
    }
}