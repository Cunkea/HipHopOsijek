using HipHopOsijek.DAL.Entities;
using HipHopOsijek.Model.Common;
using HipHopOsijek.Repository.Common;
using HipHopOsijek.Common.Filters;
using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Security.Claims;
using System.Data.SqlTypes;

namespace HipHopOsijek.Repository
{
    class CommentRepository : ICommentRepository
    {
        #region Properties

        protected IRepository Repository { get; set; }

        #endregion Properties


        #region Constructors

        public CommentRepository(IRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors


        #region Methods

        public virtual Task<int> DeleteAsync(Guid? id)
        {
            try
            {
                return Repository.DeleteAsync<Comment>(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<IComment> GetAsync(Guid? id)
        {
            try
            {
                return Mapper.Map<IComment>(await Repository.GetByIDAsync<Comment>(id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<List<IComment>> GetAsync(CommentFilter filter = null)
        {
            try
            {
                if (filter != null)
                {
                    return Mapper.Map<List<IComment>>(
                        await Repository.GetWhere<Comment>()
                        .OrderBy(c => c.DateCreated)
                        .Skip((filter.PageNumber - 1) * filter.PageSize)
                        .Take(filter.PageSize)
                        .ToListAsync());
                }
                else
                {
                    return Mapper.Map<List<IComment>>(
                        await Repository.GetWhere<Comment>()
                        .ToListAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<List<IComment>> GetCurrentAsync()
        {
            throw new NotImplementedException();
        }
        /*
         * 
public virtual async Task<List<IComment>> GetCurrentAsync()
{
   throw new NotImplementedException();

   try
   {
       var currentUser = ClaimsPrincipal.Current.Identity.GetUserId();/*
       return AutoMapper.Mapper.Map<List<IComment>>(await Repository.GetWhere<Comment>().Where(c =>m c.PersonId = currentUser).ToListAsync());
       return "";
   }
   catch (Exception e)

   {
       throw e;
   }

}*/

        #endregion Methods
    }
}
