using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Application.Mapping;

namespace WarehouseApp.Application.ViewModel.Customer
{
    public class CustomerForListVm : IMapFrom<WarehouseApp.Domain.Model.Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<WarehouseApp.Domain.Model.Customer, CustomerForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.NIP, opt => opt.MapFrom(s => s.NIP));
        }

    }
}
