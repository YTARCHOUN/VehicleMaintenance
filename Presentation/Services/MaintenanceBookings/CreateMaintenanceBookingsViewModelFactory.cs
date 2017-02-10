﻿using System.Linq;
using VehicleMaintenance.Application.Maintenances.Queries;
using VehicleMaintenance.Application.Vehicles.Queries;
using VehicleMaintenance.ViewModel.MaintenanceBooking;
using Microsoft.AspNetCore.Mvc.Rendering;
using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;

namespace VehicleMaintenance.Services.MaintenanceBookings
{
    public class CreateMaintenanceBookingsViewModelFactory : ICreateMaintenanceBookingsViewModelFactoy
    {
        private readonly IGetBrandListQuery _brandQuery;
        private readonly IGetMaintenanceOptionListQuery _maintenanceOptionsQuery;

        public CreateMaintenanceBookingsViewModelFactory(
             IGetBrandListQuery brandQuery,
             IGetMaintenanceOptionListQuery maintenanceOptionsQuery
            )
        {
            _brandQuery = brandQuery;
            _maintenanceOptionsQuery = maintenanceOptionsQuery;
        }

        public CreateMaintenanceBookingViewModel Create()
        {
            var brands = _brandQuery.Execute();

            var maintenanceOptions = _maintenanceOptionsQuery.Execute();

            var createMaintenanceBookingViewModel = new CreateMaintenanceBookingViewModel();

            createMaintenanceBookingViewModel.Brands = brands.Select(
                b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                }).ToList();

            createMaintenanceBookingViewModel.MaintenanceOptions = maintenanceOptions.Select(
                m => new SelectListItem
                {
                    Value = m.Id.ToString(),
                    Text = m.Description
                }).ToList();

            createMaintenanceBookingViewModel.CreateMaintenanceBookingModel = new CreateMaintenanceBookingModel();

            return createMaintenanceBookingViewModel;
        }
    }
}
