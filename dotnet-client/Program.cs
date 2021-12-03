using dotnet_client;
using Grpc.Net.Client;


// See https://aka.ms/new-console-template for more information
Console.WriteLine(".:: dotnet GRPC Client ::.");

using var channel = GrpcChannel.ForAddress("http://localhost:5087");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest() { Name = "Teste GRPC" });
Console.WriteLine("Retorno: " + reply.Message);

// Se a conexão com o servidor estabelecida pelo "channel" cair, irá dar "HttpRequestException" aqui.
// Para simular coloque um break point aqui e reinicie o GrpcServer.
var reply2 = await client.SayHelloAsync(new HelloRequest() { Name = "Teste GRPC 2" });
Console.WriteLine("Retorno2: " + reply2.Message);


// Console.WriteLine("Pressione qualquer tecla para sair.");
// Console.ReadKey();
