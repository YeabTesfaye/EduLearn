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
    public ReviewService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}

