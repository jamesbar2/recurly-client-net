﻿using System;
using Recurly;
using Recurly.Resources;

namespace RecurlyTestRig
{
    class Program
    {
        static void Main(string[] args)
        {
          try {
            var subdomain = Environment.GetEnvironmentVariable("RECURLY_SUBDOMAIN");
            var apiKey = Environment.GetEnvironmentVariable("RECURLY_API_KEY");
            var client = new Recurly.Client(subdomain, apiKey);
            var site = client.GetSite(subdomain);
            Console.WriteLine(site.Id);

            var account = client.GetAccount(subdomain, "code-benjamin-du-monde");
            Console.WriteLine(account.CreatedAt);

            var createAccount = new CreateAccount() {
                Code = "abcsdaskdljsda",
                Username = "myuser",
                Address = new Address() {
                    City = "New Orleans",
                    Street1 = "1 Canal St.",
                    Region = "LA",
                    Country = "US",
                    PostalCode = "70115"
                }
            };

            var createdAccount = client.CreateAccount(subdomain, createAccount);
            Console.WriteLine(createdAccount.CreatedAt);

            try {
                var nonexistentAccount = client.GetAccount(subdomain, "idontexist");
            } catch (Recurly.ApiError err) {
                Console.WriteLine(err);
            }
          } catch (Recurly.ApiError err) {
                Console.WriteLine(err);
          }
        }
    }
}