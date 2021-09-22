using HotelListing___ASP_.NET.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing___ASP_.NET.IRepository
{
   public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<Country> Countries { get;}

        IGenericRepository<Hotel> Hotels { get; }

        Task Save();

    }
}
