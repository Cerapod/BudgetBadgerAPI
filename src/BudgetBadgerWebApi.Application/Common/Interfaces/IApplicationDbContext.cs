﻿using BudgetBadgerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<HouseMember> HouseMembers { get; set; }
        DbSet<Household> Households { get; set; }
        DbSet<Income> Incomes { get; set; }
        DbSet<Expense> Expenses { get; set; }
        DbSet<HouseMemberExpense> HouseMemberExpenses { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
