using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Milestones.Commands.CreateMilestone
{
    public partial class CreateMilestoneCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Owner { get; set; }
    }
    public class CreateMilestoneCommandHandler : IRequestHandler<CreateMilestoneCommand, Response<int>>
    {
        private readonly IMilestoneRepositoryAsync _milestoneRepository;
        private readonly IMapper _mapper;
        public CreateMilestoneCommandHandler(IMilestoneRepositoryAsync milestoneRepository, IMapper mapper)
        {
            _milestoneRepository = milestoneRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateMilestoneCommand request, CancellationToken cancellationToken)
        {
            var milestone = _mapper.Map<Milestone>(request);
            await _milestoneRepository.AddAsync(milestone);
            return new Response<int>(milestone.Id);
        }
    }
}
