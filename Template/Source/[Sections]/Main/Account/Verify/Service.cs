﻿using Data;
using MongoWebApiStarter;
using ServiceStack;

namespace Main.Account.Verify
{
    [Authenticate(ApplyTo.None)]
    public class Service : Service<Request, Nothing>
    {
        public override Nothing Get(Request r)
        {
            if (RepoAccount.ValidateEmail(r.ID, r.Code))
            {
                return Nothing;
            }

            throw HttpError.BadRequest("Sorry! Could not validate your email address...");
        }
    }
}
