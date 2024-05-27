using AutoMapper;
using Business.Abstract;
using DataAccess.Entity;
using DataAccess.MyContext;
using DTO.EntityDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PostService : BaseSevice<PostDTO, Post, PostDTO>, IPost
    {
        public PostService(IMapper mapper, AppDbContext context) : base(mapper, context)
        {
        }

        public IEnumerable<PostDTO> GetAllInclude()
        {
            var value = _dbSet.Include(c=>c.Category).ToList();//Include hamsini getirmekden oteri bir metoddur
            var bringDTO = _mapper.Map<IEnumerable<PostDTO>>(value);
            return bringDTO;
        }

		public IEnumerable<PostDTO> GetAllCategory(int id)
		{
            var value = _dbSet.Where(c => c.CategoryID == id).ToList();
            var bringDTO=_mapper.Map<IEnumerable<PostDTO>>(value);
            return bringDTO;
		}
	}
}
