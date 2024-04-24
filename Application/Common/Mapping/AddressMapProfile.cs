using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping;

public class AddressMapProfile : Profile
{
    public AddressMapProfile()
    {
        CreateMap<CreateAddressRequest, Address>();

        CreateMap<Address, SingleAddressResponse>();
    }
}