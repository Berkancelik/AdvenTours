﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFreamework
{
    public class EfAnnoucmenetDal : GenericRepository<Annoucement>, IAnnoucementDal
    {
    }
}
