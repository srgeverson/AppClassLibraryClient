using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AppClassLibraryClient.mapper
{
    public class GenericMapper<TInput, TOutput> : Profile
    {
        public TOutput ToResponse(TInput input)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TInput, TOutput>());
            var mapper = new Mapper(config);
            return mapper.Map<TOutput>(input);
        }

        public TOutput ToLoginResponse(TInput input)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TInput, TOutput>());
            var mapper = new Mapper(config);
            return mapper.Map<TOutput>(input);
        }

        public IList<TOutput> ToListResponse(IList<TInput> inputs)
        {
            var outputs = new List<TOutput>();
            inputs.ToList().ForEach(input => outputs.Add(ToResponse(input)));
            return outputs;
        }

        public TOutput ToModel(TInput input)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TInput, TOutput>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<TOutput>(input);
        }

        public IList<TOutput> ToListModel(IList<TInput> inputs)
        {
            var outputs = new List<TOutput>();
            inputs.ToList().ForEach(usuarioRequest => outputs.Add(ToModel(usuarioRequest)));
            return outputs;
        }
    }
}
