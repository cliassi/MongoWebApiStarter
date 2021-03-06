﻿using ServiceStack;
using ServiceStack.Validation;
using System.Linq;

namespace MongoWebApiStarter.Tools
{
    public static class Validation
    {
        public static HttpError GetErrorResponse(ValidationError ex)
        {
            return new HttpError(
                new
                {
                    errors = ex.Violations
                               .GroupBy(f => f.FieldName)
                               .ToDictionary(x => x.Key,
                                             x => x.Select(e => e.ErrorMessage).ToArray()),
                    status = 400,
                    title = "One or more validation errors occurred."
                },
                400,
                "Validation Error");
        }
    }
}
