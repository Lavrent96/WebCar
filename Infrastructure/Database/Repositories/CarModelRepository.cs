using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Application.Repositories.Interfaces;
using Domain.Entities;
using Domain.Enums;
 
namespace Infrastructure.Database.Repositories
{
    public class CarRepository
    {
        private readonly string _connectionString;

        public CarRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        private CarBrand MapToCarBrand(IDataRecord record)
        {
            return new CarBrand
            {
                Id = (int)record["id"],
                Name = (string)record["name"],
                Description = (string)record["description"],
                LogoUrl = (string)record["logo_url"]
            };
        }

        private CarModel MapToCarModel(IDataRecord record)
        {
            return new CarModel
            {
                Id = (int)record["id"],
                Name = (string)record["name"],
                EngineType = (EngineType)(int)record["engine_type"],
                Price = (decimal)record["price"],
                Year = (int)record["year"],
                Description = (string)record["description"],
                CarBrandId = (int)record["car_brand_id"]
            };
        }

        private TireSize MapToTireSize(IDataRecord record)
        {
            return new TireSize
            {
                Id = (int)record["id"],
                Diameter = (int)record["diameter"],
                Width = (int)record["width"],
                AspectRatio = (int)record["aspect_ratio"],
                TireType = (TireType)(int)record["tire_type"],
                CarModelId = (int)record["car_model_id"]
            };
        }
        public async Task<List<CarBrand>> GetAllCarBrands()
        {
            using (var connection = OpenConnection())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "GetAllCarBrands";
                command.CommandType = CommandType.StoredProcedure;

                var carBrands = new List<CarBrand>();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var carBrand = MapToCarBrand(reader);
                        carBrands.Add(carBrand);
                    }
                }

                return carBrands;
            }
        }

        public async Task<List<CarModel>> GetAllCarModels()
        {
            using (var connection = OpenConnection())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "GetAllCarModels";
                command.CommandType = CommandType.StoredProcedure;

                var carModels = new List<CarModel>();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var carModel = MapToCarModel(reader);
                        carModels.Add(carModel);
                    }
                }

                return carModels;
            }
        }

        public async Task<List<TireSize>> GetAllTireSizes()
        {
            using (var connection = OpenConnection())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "GetAllTireSizes";
                command.CommandType = CommandType.StoredProcedure;

                var tireSizes = new List<TireSize>();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var tireSize = MapToTireSize(reader);
                        tireSizes.Add(tireSize);
                    }
                }

                return tireSizes;
            }
        }

        public async Task<CarModel> GetByIdAsync(int id)
        {
            using (var connection = OpenConnection())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "GetCarModelWithDetails";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    CarModel carModel = null;

                    while (await reader.ReadAsync())
                    {
                        if (carModel == null)
                        {
                            carModel = MapToCarModel(reader);
                            carModel.CarBrand = new CarBrand
                            {
                                Id = (int)reader["brand_id"],
                                Name = (string)reader["brand_name"],
                                Description = (string)reader["brand_description"],
                                LogoUrl = (string)reader["brand_logo_url"]
                            };
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("tire_id")))
                        {
                            var tireSize = new TireSize
                            {
                                Id = (int)reader["tire_id"],
                                Diameter = (int)reader["diameter"],
                                Width = (int)reader["width"],
                                AspectRatio = (int)reader["aspect_ratio"],
                                TireType = (TireType)(int)reader["tire_type"],
                                CarModelId = carModel.Id
                            };

                            carModel.Tires.Add(tireSize);
                        }
                    }

                    return carModel;
                }
            }

            return null; // Return null if no entity with the given id is found
        }


        public async Task<List<CarModel>> GetAllByBrandIdAsync(int brandId)
        {
            var carModels = new List<CarModel>();

            using (var connection = OpenConnection())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM car_model WHERE car_brand_id = @BrandId";
                command.Parameters.AddWithValue("@BrandId", brandId);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var carModel = MapToCarModel(reader);
                        carModels.Add(carModel);
                    }
                }
            }

            return carModels;
        }

    }
}
