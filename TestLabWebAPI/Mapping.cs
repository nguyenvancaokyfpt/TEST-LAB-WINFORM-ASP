using AutoMapper;

namespace TestLabWebAPI
{
    public class Mapping : Profile
    {
        // byte[] timestamp to string

        private static System.DateTime ConvertFromBytes(byte[] value)
        {
            long ticks = 0;
            for (int i = 0; i < 8; i++)
            {
                ticks |= (long)(value[i] & 0xff) << (i * 8);
            }
            return new System.DateTime(ticks);
        }

        public Mapping()
        {
            CreateMap<TestLabEntity.AutoDB.TlChapter, TestLabWebAPI.Response.TlChapterRes>()
                .ReverseMap();
        }
    }
}
