using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;

namespace MakeYourDiet.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateProduct(Product product)
        {
            if (product != null)
            {
                await _unitOfWork.ProductRepository.Add(product);

                await _unitOfWork.Complete();
            }

            return false;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            if (productId > 0)
            {
                var product = await _unitOfWork.ProductRepository.GetById(productId);

                if (product != null)
                {
                    _unitOfWork.ProductRepository.Remove(product);

                    await _unitOfWork.Complete();
                }
            }

            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _unitOfWork.ProductRepository.GetAll();
        }

        public async Task<Product> GetProductById(int productId)
        {
            if (productId > 0)
            {
                var product = await _unitOfWork.ProductRepository.GetById(productId);

                if (product != null)
                {
                    return product;
                }
            }

            return null;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            if (product != null)
            {
                var updateProduct = await _unitOfWork.ProductRepository.GetById(product.Id);
                if (updateProduct != null)
                {
                    updateProduct.Name = product.Name;
                    updateProduct.Fats = product.Fats;
                    updateProduct.Carbons = product.Carbons;
                    updateProduct.Proteins = product.Proteins;
                    updateProduct.Weight = product.Weight;

                    _unitOfWork.ProductRepository.Update(updateProduct);

                    await _unitOfWork.Complete();
                }
            }

            return false;
        }
    }
}