﻿using BookCatalog_API.Contexts;
using BookCatalog_API.Models;
using BookCatalog_API.Repositories;

namespace BookCatalog_API.Repositories.Data;

public class ProfileRepository : GeneralRepository<int, Profile>
{
    public ProfileRepository(MyContext context) : base(context)
    {
    }
}
