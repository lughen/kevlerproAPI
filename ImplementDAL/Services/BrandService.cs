using DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDAL.Services
{
    public class BrandService : IBrandService
    {
        private readonly IUnitofWork _unitOfWork;

        public BrandService(IUnitofWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }
        public async Task<Brand> Create(Brand model)
        {

            try
            {
                model.Updated_At = null;
                await _unitOfWork.BrandRepository.AddAsync(model);
                await _unitOfWork.CommitAsync();
                return model;
            }
            finally
            {

            }
        }

        public async Task<Brand> Delete(Brand model)
        {
            try
            {
                model.IsDeleted = true;
                await _unitOfWork.CommitAsync();
                return model;
            }
            finally { }
        }

        public async Task<IEnumerable<Brand>> Get()
        {
            try
            {

                return await _unitOfWork.BrandRepository.GetAllAsync();
            }
            finally
            {

            }
        }

        public async Task<Brand> Get(int id)
        {
            try
            {

                return await _unitOfWork.BrandRepository.GetByIdAsync(id);
            }
            finally
            {

            }
        }

        public async Task<List<Brand>> SearchBrandData(string name)
        {
            return null;

        }

        public async Task<Brand> Update(Brand update, Brand model)
        {
            try
            {

                update.Name = model.Name;
                update.ImageUrl = model.ImageUrl;
                update.Updated_At = model.Updated_At;
                await _unitOfWork.CommitAsync();
                return update;
            }
            finally { }

        }
    }
}