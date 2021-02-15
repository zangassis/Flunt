﻿using Flunt.Validations;

namespace Flunt.Samples.Handlers.Requests.Contracts
{
    public class CreateCustomerRequestContract : Contract<CreateCustomerRequest>
    {
        public CreateCustomerRequestContract(CreateCustomerRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Name, "Name")
                .IsEmail(request.Email, "Email");
        }
    }
}
