using StackExchange.Redis;
using System;
using System.Collections.Generic;

namespace RedislabsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis-19032.c73.us-east-1-2.ec2.cloud.redislabs.com:19032,password =<keyhere>");
            var db = redis.GetDatabase();
            bool success = db.StringSet("key","value");
            string redisValue = db.StringGet("key");
            Console.WriteLine(redisValue);
        }
    }
}
