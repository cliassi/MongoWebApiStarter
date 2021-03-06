﻿using Data;
using MongoWebApiStarter;

namespace Main.Image.Delete
{
    public class Service : Service<Request, Nothing>
    {
        public override Nothing Delete(Request r)
        {
            _ = RepoImage.DeleteAsync(r.ID);

            return Nothing;
        }
    }
}
