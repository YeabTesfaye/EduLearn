using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services;

internal sealed class ReviewService : IReviewService
{

    private IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public ReviewService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
}

