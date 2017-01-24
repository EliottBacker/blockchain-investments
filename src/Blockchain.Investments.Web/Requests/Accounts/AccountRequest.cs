using System;
using Blockchain.Investments.Core.Domain;
using Blockchain.Investments.Core.Infrastructure;
using Blockchain.Investments.Core.ReadModel.Dtos;
using Blockchain.Investments.Core.Repositories;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Blockchain.Investments.Api.Requests.Accounts
{
    public class AccountRequest
    {
        public Guid Id {get;set;}
        public string UserId {get;set;}
        public string Title {get;set;}
        public string Description {get;set;}
        public string Notes {get;set;}
        public string Code {get;set;}
        public AccountType Type {get;set;}
        public CounterpartyType CounterpartyType {get;set;}
        public Security Security {get;set;}
        public string ParentAccountId {get;set;}
        
    }

    public class AccountRequestValidator : AbstractValidator<AccountRequest> 
    {
        public AccountRequestValidator(IRepository<AccountDto> repo, IOptions<AppConfig> optionsAccessor)
        {
            //RuleFor(x => x.Id).Must(x => !repo.Exists(x)).WithMessage("An Account with this ID already exists.");
            //RuleFor(x => x.EmployeeID).Must(x => !employeeRepo.Exists(x)).WithMessage("An Employee with this ID already exists.");
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("The Title cannot be blank.");
            //RuleFor(x => x.DateOfBirth).LessThan(DateTime.Today.AddYears(-16)).WithMessage("Employees must be 16 years old or older.");
        }
    }
}