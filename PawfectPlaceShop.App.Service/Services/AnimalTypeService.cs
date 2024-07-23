using AutoMapper;
using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.Entity.UnitOfWorks;
using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Service.Services
{
    public class AnimalTypeService : IAnimalTypeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public AnimalTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AnimalTypeViewModel>> GetAllAsync()
        {
            var AnimalTypes=await unitOfWork.GetRepository<AnimalType>().GetAllAsync();
            return _mapper.Map<List<AnimalTypeViewModel>>(AnimalTypes);

        }

        public async Task<AnimalTypeViewModel> GetByIdAsync(int id)
        {
            var AnimalType=await unitOfWork.GetRepository<AnimalType>().GetByIdAsync(id);
            return _mapper.Map<AnimalTypeViewModel>(AnimalType);
        }
    }
}
