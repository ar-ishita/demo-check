using AutoMapper;
using CarManagementSystem.Models;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.Middleware
{
    public class MapperConfig : Profile
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring Customers and CustomerDTO
                cfg.CreateMap<Admin, AdminDTO>().ReverseMap();
                cfg.CreateMap<Car, CarDTO>().ReverseMap();
                cfg.CreateMap<Customer, CustomerDTO>().ReverseMap();
                cfg.CreateMap<Rental, RentalDTO>().ReverseMap();   
                cfg.CreateMap<Return, ReturnDTO>().ReverseMap();   
                cfg.CreateMap<Admin,AdminDTO>().ReverseMap();

                //Any Other Mapping Configuration ....
            });
            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
