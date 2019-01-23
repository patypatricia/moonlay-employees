﻿using GraphQL.Types;
using Moonlay.Employees.Domain.Entities;

namespace Moonlay.Baas.Employees.Models
{
    public class DepartmentType : ObjectGraphType<Department>
    {
        public DepartmentType()
        {
            Field<StringGraphType>("identity", resolve: context => context.Source.Identity.ToString());
            Field<StringGraphType>("name", resolve: context => context.Source.Name);
            Field<BooleanGraphType>("status", resolve: context => context.Source.Status);
        }
    }
}