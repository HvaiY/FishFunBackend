using Dapr.Client;


const string storeName = "statestore";
const string key = "counter";
const string customer = "customer";

var daprClient = new DaprClientBuilder().Build();
var counter = await daprClient.GetStateAsync<int>(storeName, key);
var customerValue = await daprClient.GetStateAsync<int>(storeName, customer);

while(true)
{
    Console.WriteLine($"Counter = {counter++}");
    Console.WriteLine($"CustomerX2  = {customerValue+=2} ");

    await daprClient.SaveStateAsync(storeName, key, counter);
    await daprClient.SaveStateAsync(storeName, customer, customerValue);
    await Task.Delay(1000);
} 

// 只有指定了app 名称  即 -a 等于 --app-id 定义服务名称  才能状态有效，否则都是默认的app 名称 ，那么就无法确定是谁的状态
// dapr run -a myApp dotnet run  