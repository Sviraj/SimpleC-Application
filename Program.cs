// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using PasswordGenerator;
using Newtonsoft.Json;
using System;
using Models;


Console.WriteLine("Hello, Beautiful World!");
var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password.ToString());
Console.WriteLine(password);

Product product = new Product();
product.name = "Lux";
product.price = "100";
 string json = JsonConvert.SerializeObject(product);
Console.WriteLine(json);
Person person = new Person();
person.name = "kamal";
person.age = 45;
Console.WriteLine(person.age);
Console.WriteLine(person.name);