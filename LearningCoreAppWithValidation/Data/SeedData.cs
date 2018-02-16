using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCoreAppWithValidation.DBEntitities;
using LearningCoreAppWithValidation.Repositories;

namespace LearningCoreAppWithValidation.Data
{
    public static class SeedData
    {
        public static bool Seed(this AppDbContext dbcontext)
        {
            dbcontext.Database.EnsureCreated();


            if (!dbcontext.CenterTypes.Any())
            {
                //dbcontext.Centers.FromSql("");
                dbcontext.CenterTypes.AddRange(
                        new CenterType()
                        {
                            Name = "Country",
                            ShortName = "CNT"
                        },
                        new CenterType()
                        {
                            Name = "State",
                            ShortName = "ST"
                        },
                        new CenterType()
                        {
                            Name = "District",
                            ShortName = "DI"
                        },
                        new CenterType()
                        {
                            Name = "Block",
                            ShortName = "BL"
                        },
                        new CenterType()
                        {
                            Name = "PPC",
                            ShortName = "PPC"
                        },
                        new CenterType()
                        {
                            Name = "Sub Center",
                            ShortName = "SC"
                        }
                        );

                dbcontext.SaveChanges();
            }
            if (!dbcontext.Centers.Any())
            {
                dbcontext.Centers.Add(
                        new Center()
                        {
                            Name = "India",
                            CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.Name == "Country"),
                        });
                dbcontext.SaveChanges();
                dbcontext.Centers.Add(new Center()
                {
                    Name = "Odisha",
                    CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.ShortName == "ST"),
                    CenterRefId = dbcontext.Centers.FirstOrDefault(c => c.Name == "India").Id,
                });
                dbcontext.SaveChanges();
                dbcontext.Centers.Add(new Center()
                {
                    Name = "Cuttack",
                    CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.ShortName == "DI"),
                    CenterRefId = dbcontext.Centers.FirstOrDefault(c => c.Name == "Odisha").Id,
                });
                dbcontext.SaveChanges();
                dbcontext.Centers.Add(new Center()
                {
                    Name = "Cuttack Sadar",
                    CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.ShortName == "BL"),
                    CenterRefId = dbcontext.Centers.FirstOrDefault(c => c.Name == "Cuttack").Id,
                });
                dbcontext.SaveChanges();
                dbcontext.Centers.Add(new Center()
                {
                    Name = "Cuttack Sadar PPC",
                    CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.ShortName == "PPC"),
                    CenterRefId = dbcontext.Centers.FirstOrDefault(c => c.Name == "Cuttack Sadar").Id,
                });
                dbcontext.SaveChanges();
                dbcontext.Centers.Add(new Center()
                        {
                            Name = "Chauliaganj PHC",
                            CenterType = dbcontext.CenterTypes.FirstOrDefault(ct => ct.ShortName == "SC"),
                            CenterRefId = dbcontext.Centers.FirstOrDefault(c => c.Name == "Cuttack Sadar PPC").Id,
                        });
                dbcontext.SaveChanges();
            }



            return true;
        }
    }
}
