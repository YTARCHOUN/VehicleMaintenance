﻿using Microsoft.EntityFrameworkCore;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.Maintenances;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Customer> Customers { get; set; }

        DbSet<Employee> Employees { get; set; }

        DbSet<MaintenanceBooking> MaintenanceBookings { get; set; }

        DbSet<Vehicle> Vehicles { get; set; }

        DbSet<Brand> Brands { get; set; }

        DbSet<Workshop> Workshops { get; set; }

        DbSet<MaintenanceOption> MaintenanceOptions { get; set; }

        void Save();
    }
}
