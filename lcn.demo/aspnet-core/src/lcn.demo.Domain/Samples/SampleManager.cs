using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace lcn.demo.Samples
{
    public class SampleManager : DomainService
    {
        ISampleRepository _SamplesRepo;
        IRepository<SampleProvider> _SampleProvidersRepo;

        public SampleManager(ISampleRepository samplesRepo, IRepository<SampleProvider> sampleProvidersRepo)
        {
            _SamplesRepo = samplesRepo;
            _SampleProvidersRepo = sampleProvidersRepo;
        }

        public async Task ConnectSampleWithProviders(Guid sampleId, Guid providerId)
        {
            var sample = await _SamplesRepo.FindAsync(sampleId);
            var provider = await _SampleProvidersRepo.FindAsync(p => p.Id == providerId);
            sample.SampleProviders.Add(provider);
        }
    }
}
