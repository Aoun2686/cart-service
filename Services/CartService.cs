﻿using Grpc.Core;
using Grpc.Net.Client;
using Users_Service;


namespace Cart_Service.Services
{
      public class CartService
        {
            public UserResponse GetUserById(int userId)
            {
                var channel = GrpcChannel.ForAddress("https://user-microservice.azurewebsites.net");
                var client = new User.UserClient(channel);
                var request = new UserRequest { Id = userId };
                var response = client.GetUserById(request);
                channel.ShutdownAsync().Wait();
            return response;
            }
        }
    }
