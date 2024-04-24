using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping;

public class InvestorMapProfile : Profile
{
    public InvestorMapProfile()
    {
        CreateMap<CreateInvestorRequest, Investor>();

        CreateMap<Investor, GetAllInvestorResponse>()
            .ForMember(x => x.Address, opt =>
                opt.MapFrom(src => src.Address));
    }
}