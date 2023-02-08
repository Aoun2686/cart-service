using Grpc.Core;
using Grpc.Net.Client;
using Users_Service;


namespace Cart_Service.Services
{
      public class CartService
        {
            public async Task<UserResponse> GetUserById(int userId)
            {
                var channel = GrpcChannel.ForAddress("https://user-microservice.azurewebsites.net");
                var client = new User.UserClient(channel);
                var request = new UserRequest { Id = userId };
                var response = await client.GetUserByIdAsync(request);
                channel.ShutdownAsync().Wait();
                return response;
            }
        }
    }
