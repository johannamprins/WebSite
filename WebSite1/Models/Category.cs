using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebSite1.Models
{
    public class Category 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Item> Items { get; set; }



        //models store all the data we need to work with our application
        // in order to process the data, we will need repositories - dependency injection
        // creating interfaces for each repo first and then registering interface with corresponding repository 
        //as a service and inject them into the application 

    } 
}
